using System.ComponentModel.DataAnnotations;
using System.Globalization;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Drawing;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Enums;
using SVG.Utilities.ExtensionsMethods;
namespace SVG.Infra.Documentos;

// Modelo de exportação separado da interface HTML e do armazenamento físico.
public sealed class GeradorPlanejamentoPdf(IArmazenamentoAnexos armazenamento) : IGeradorPlanejamentoPdf
{
    public byte[] Gerar(Planejamento p, IReadOnlyDictionary<int,AnexoAlvo> fotos, string urlBase)
    {
        FontesPlanejamentoPdf.Configurar();
        var doc=new Document();doc.Info.Title=p.ObterTituloExibicao();doc.Info.Author="SVG";
        var normal=doc.Styles[StyleNames.Normal]!;normal.Font.Name="DejaVu Sans";normal.Font.Size=10;
        normal.ParagraphFormat.SpaceAfter=Unit.FromPoint(5);
        var h=doc.Styles[StyleNames.Heading1]!;h.Font.Size=14;h.Font.Bold=true;h.Font.Color=Color.FromRgb(25,65,105);
        h.ParagraphFormat.SpaceBefore=Unit.FromPoint(14);h.ParagraphFormat.SpaceAfter=Unit.FromPoint(7);h.ParagraphFormat.KeepWithNext=true;
        var h2=doc.Styles[StyleNames.Heading2]!;h2.Font.Size=11;h2.Font.Bold=true;h2.ParagraphFormat.SpaceBefore=Unit.FromPoint(9);h2.ParagraphFormat.KeepWithNext=true;
        var s=doc.AddSection();s.PageSetup.PageFormat=PageFormat.A4;
        s.PageSetup.TopMargin=Unit.FromCentimeter(1.7);s.PageSetup.BottomMargin=Unit.FromCentimeter(1.7);
        s.PageSetup.LeftMargin=Unit.FromCentimeter(1.7);s.PageSetup.RightMargin=Unit.FromCentimeter(1.7);
        var rodape=s.Footers.Primary.AddParagraph();rodape.Format.Alignment=ParagraphAlignment.Right;rodape.Format.Font.Size=8;
        rodape.AddText($"SVG | Planejamento {p.ID} | Página ");rodape.AddPageField();rodape.AddText(" de ");rodape.AddNumPagesField();
        var titulo=s.AddParagraph(p.ObterTituloExibicao());titulo.Format.Font.Size=18;titulo.Format.Font.Bold=true;titulo.Format.SpaceAfter=Unit.FromPoint(12);
        long totalImagens=0;
        void Grupo(string texto)=>s.AddParagraph(texto,StyleNames.Heading1);
        void Campo(string nome, object? valor)
        {
            var par=s.AddParagraph();par.AddFormattedText(nome+": ",TextFormat.Bold);
            par.AddText(string.IsNullOrWhiteSpace(valor?.ToString())?"Não informado":valor.ToString()!);
        }
        string Rota(string action,int id)=>urlBase.TrimEnd('/')+"/Planejamento/"+action+"/"+id;
        void Link(string nome,string? url)
        {
            var par=s.AddParagraph();par.AddFormattedText(nome+": ",TextFormat.Bold);
            if(Uri.TryCreate(url,UriKind.Absolute,out var uri) && uri.Scheme is "https" or "http")
            { var link=par.AddHyperlink(uri.AbsoluteUri,HyperlinkType.Web);link.AddText("Abrir link");link.Font.Color=Colors.DarkBlue;link.Font.Underline=Underline.Single; }
            else par.AddText("Não informado");
        }
        void Foto(string? caminho,double largura=16.8,double altura=12)
        {
            if(string.IsNullOrWhiteSpace(caminho)){Campo("Imagem","Arquivo indisponível");return;}
            byte[] bytes;
            try
            {
                using var stream=armazenamento.Abrir(caminho);
                if(stream==null){Campo("Imagem","Arquivo indisponível");return;}
                using var buffer=new MemoryStream();var bloco=new byte[81920];int lidos;
                while((lidos=stream.Read(bloco,0,bloco.Length))>0)
                {
                    totalImagens+=lidos;
                    if(buffer.Length+lidos>50L*1024*1024 || totalImagens>200L*1024*1024) throw new ValidationException("As imagens excedem o limite de 200 MB para gerar um único PDF.");
                    buffer.Write(bloco,0,lidos);
                }
                bytes=buffer.ToArray();
            }
            catch(IOException){Campo("Imagem","Arquivo indisponível no armazenamento");return;}
            catch(UnauthorizedAccessException){Campo("Imagem","Arquivo indisponível no armazenamento");return;}
            double w,h;
            try
            {
                using var ms=new MemoryStream(bytes);using var img=XImage.FromStream(ms);
                var escala=Math.Min(largura*72/2.54/img.PointWidth,altura*72/2.54/img.PointHeight);
                w=img.PointWidth*escala;h=img.PointHeight*escala;
            }
            catch(Exception ex) when(ex is ArgumentException or InvalidOperationException or NotSupportedException)
            {Campo("Imagem","Formato inválido ou imagem não suportada no PDF");return;}
            var par=s.AddParagraph();par.Format.KeepTogether=true;
            var imagem=par.AddImage("base64:"+Convert.ToBase64String(bytes));imagem.Width=Unit.FromPoint(w);imagem.Height=Unit.FromPoint(h);
        }
        Grupo("Informações preliminares");
        Campo("Situação",p.Situacao);Campo("Seção",p.Secao?.Nome);Campo("OS",p.OrdemServico);Campo("Unidade de Apoio",p.UnidadeApoio);
        Campo("Data e hora do apoio",p.DataPrevista?.ToString("dd/MM/yyyy HH:mm"));Campo("MBA",p.MBA?"Sim":"Não");Campo("MP",p.MP?"Sim":"Não");Campo("Nº MBA",p.NumeroMBA);
        if(!string.IsNullOrWhiteSpace(p.Objetivo))Campo("Objetivo",p.Objetivo);
        Grupo("Endereço do alvo");Campo("Endereço",p.Endereco);Campo("Referência",p.Referencia);
        Campo("Latitude",p.Latitude?.ToString(CultureInfo.InvariantCulture));Campo("Longitude",p.Longitude?.ToString(CultureInfo.InvariantCulture));Link("Google Maps",p.Link_Endereco_Alvo);
        Grupo("Alvos");
        if(p.Alvos.Count==0)Campo("Alvos","Nenhum alvo cadastrado");
        foreach(var v in p.Alvos.OrderBy(a=>a.ID))
        {
            s.AddParagraph(v.Alvo.Nome,StyleNames.Heading2);
            if(fotos.TryGetValue(v.AlvoID,out var foto))Foto(foto.Caminho,4,4);
            Campo("Nome",v.Alvo.Nome);Campo("Alcunha",v.Alvo.Alcunha);Campo("Mãe",v.Alvo.NomeMae);Campo("Pai",v.Alvo.NomePai);
            Campo("CPF",v.Alvo.CPF);Campo("RG",v.Alvo.RG);Campo("Nascimento",v.Alvo.DataNascimento?.ToString("dd/MM/yyyy"));
            if(!string.IsNullOrWhiteSpace(v.Codigo))Campo("Código",v.Codigo);
            Campo("Observações neste planejamento",v.Observacoes);
        }
        Grupo("Imagens do planejamento");
        var subgrupos=Enum.GetValues<XSubgrupoImagemPlanejamento>();
        void Anexos(IEnumerable<AnexoPlanejamento> anexos)
        {
            var lista=anexos.OrderBy(a=>a.Ordem).ThenBy(a=>a.ID).ToList();
            if(lista.Count==0)Campo("Anexos","Nenhum arquivo cadastrado");
            foreach(var a in lista)
            {
                if(a.TipoMime is "image/jpeg" or "image/png")Foto(a.Caminho);
                else Campo("Vídeo","Disponível no sistema (requer autenticação)");
                Link("Baixar anexo",Rota("Anexo",a.ID));
            }
        }
        foreach(var grupo in subgrupos){s.AddParagraph(grupo.GetDescription(),StyleNames.Heading2);Anexos(p.Anexos.Where(a=>a.Subgrupo==grupo));}
        var antigos=p.Anexos.Where(a=>!a.Subgrupo.HasValue || !subgrupos.Contains(a.Subgrupo.Value)).ToList();
        if(antigos.Count>0){s.AddParagraph("Anexos anteriores (sem subgrupo)",StyleNames.Heading2);Anexos(antigos);}
        Grupo("Equipe e viaturas");
        var tabela=s.AddTable();tabela.Borders.Width=0.5;tabela.Borders.Color=Colors.LightGray;
        foreach(var cm in new[]{7.0,2.5,4.0,4.1})tabela.AddColumn(Unit.FromCentimeter(cm));
        var cab=tabela.AddRow();cab.HeadingFormat=true;cab.Format.Font.Bold=true;cab.Shading.Color=Color.FromRgb(230,237,244);
        var colunas=new[]{"Operador","Entrada","Função","Viatura"};for(int i=0;i<4;i++)cab.Cells[i].AddParagraph(colunas[i]);
        foreach(var membro in p.Integrantes.OrderBy(i=>i.ID))
        {
            var row=tabela.AddRow();var campos=new[]{membro.Operador?.Nome,membro.Entrada,membro.Funcao,string.IsNullOrWhiteSpace(membro.Viatura?.Prefixo)?membro.Viatura?.Placa:membro.Viatura.Prefixo};
            for(int i=0;i<4;i++)row.Cells[i].AddParagraph(campos[i]??"-");
        }
        Grupo("Quadro de Horários");Campo("Briefing na DOE",p.HorarioBriefingDOE?.ToString(@"hh\:mm"));Campo("Saída da DOE",p.HorarioSaidaDOE?.ToString(@"hh\:mm"));Campo("Briefing na DP",p.HorarioBriefingDP?.ToString(@"hh\:mm"));Campo("Local do briefing",p.LocalBriefing);
        Grupo("Comunicações Durante o Trajeto");Campo("Viaturas",p.CanalViaturas);Campo("Operadores",p.CanalOperadores);
        Grupo("APH - Médico");Campo("Socorrista APH-1",p.SocorristaAPH1);Campo("Socorrista APH-2",p.SocorristaAPH2);Campo("Viatura",p.PrefixoVtrAPH);Campo("Motorista",p.MotoristaVtrAPH);Campo("Apoio médico",p.ApoioMedico);
        Grupo("Medidas Complementares");Campo("Relatório e escritura do MBA",p.ResponsavelRelatorio);Campo("Conferência do endereço e foto do MBA",p.ResponsavelFotoMBA);Campo("Particularidades",p.Particularidades);
        Grupo("Resumo das Rotas");
        foreach(var rota in new[]{(Nome:$"DOE até {p.UnidadeApoio}",Url:p.Link_Rota_DOE_Unidade_Apoio,Km:p.DistanciaRotaDOEUnidadeApoioKm,Min:p.DuracaoRotaDOEUnidadeApoioMinutos),(Nome:"DP até desembarque",Url:p.Link_Rota_DP_Desemb,Km:p.DistanciaRotaDPDesembKm,Min:p.DuracaoRotaDPDesembMinutos)})
        {s.AddParagraph(rota.Nome,StyleNames.Heading2);Campo("Distância (km)",rota.Km);Campo("Duração (min)",rota.Min);Link("Rota",rota.Url);}
        Grupo("Resumo das Localizações");Link("Desembarque",p.Link_Localizacao_Desemb);Link("Alvo",p.Link_Endereco_Alvo);Link("Hospital 1",p.Link_Localizacao_Hospital_1);Link("Hospital 2",p.Link_Localizacao_Hospital_2);Campo("ZPH (coordenada)",p.CoordenadaZPH);
        foreach(var grupo in p.Itens.OrderBy(i=>i.ID).GroupBy(i=>i.Tipo))
        {
            Grupo(grupo.Key switch{"Horario"=>"Horários adicionais","Rota"=>"Rotas adicionais","Localizacao"=>"Localizações adicionais","Mandado"=>"Mandados","Providencia"=>"Providências",_=>grupo.Key});
            foreach(var item in grupo){Campo("Descrição",item.Descricao);Campo("Data / hora",item.DataHora?.ToString("dd/MM/yyyy HH:mm"));Campo("Responsável",item.Responsavel);Link("Referência",item.Url);if(item.DistanciaKm.HasValue)Campo("Distância (km)",item.DistanciaKm);if(item.DuracaoMinutos.HasValue)Campo("Duração (min)",item.DuracaoMinutos);}
        }
        Grupo("Registro");Campo("Cadastro",p.DataHoraCriacao.ToString("dd/MM/yyyy HH:mm"));Campo("Última alteração",p.DataHoraAtualizacao.ToString("dd/MM/yyyy HH:mm"));Link("Abrir planejamento no sistema",Rota("Detalhes",p.ID));
        var renderer=new PdfDocumentRenderer{Document=doc};renderer.RenderDocument();
        using var output=new MemoryStream();renderer.PdfDocument.Save(output,false);return output.ToArray();
    }
}
