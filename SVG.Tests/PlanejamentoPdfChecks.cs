using System.Reflection;
using PdfSharp.Pdf.IO;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.TiposEstruturados.Enums;
using SVG.Infra.Documentos;
public static class PlanejamentoPdfChecks
{
    public static void Run(string? output=null)
    {
        var storage=DispatchProxy.Create<IArmazenamentoAnexos,RepositoryProxy>();
        ((RepositoryProxy)(object)storage).Handler=(m,a)=>m=="Abrir" ? typeof(PlanejamentoPdfChecks).Assembly.GetManifestResourceStream("SVG.Tests.Fixtures.planejamento-pdf.png") : null;
        var p=new Planejamento{ID=42,DataPrevista=new DateTime(2026,11,22,4,0,0),UnidadeApoio="P30",Secao=new Sessao{Nome="SOE II"},Situacao="Rascunho",OrdemServico="OS-2026/42",MBA=true,NumeroMBA="1234",
            Endereco="Rua de demonstração, 100 - endereço fictício",Referencia="Portão azul",Latitude=-15.78m,Longitude=-47.93m,LocalBriefing="Auditório de P30",HorarioBriefingDOE=TimeSpan.FromHours(3),HorarioSaidaDOE=TimeSpan.FromHours(3.5),HorarioBriefingDP=TimeSpan.FromHours(4),
            SocorristaAPH1="Operador Exemplo",ResponsavelRelatorio="Responsável Exemplo",CanalViaturas="Canal 1",CanalOperadores="Canal 2",Particularidades=string.Join("\n",Enumerable.Repeat("Observação de demonstração com acentos: ação, atenção e localização. Texto fictício para conferir quebras de página.",30)),DataHoraCriacao=DateTime.Now,DataHoraAtualizacao=DateTime.Now};
        p.Alvos.Add(new PlanejamentoAlvo{AlvoID=1,Alvo=new Alvo{ID=1,Nome="Pessoa fictícia José",Alcunha="Exemplo",NomeMae="Mãe fictícia",NomePai="Pai fictício"},Observacoes="Informações exclusivamente de teste."});
        int id=0;
        foreach(var grupo in Enum.GetValues<XSubgrupoImagemPlanejamento>())p.Anexos.Add(new AnexoPlanejamento{ID=++id,Subgrupo=grupo,Ordem=1,Caminho="imagem-teste",TipoMime="image/png"});
        p.Anexos.Add(new AnexoPlanejamento{ID=20,Subgrupo=XSubgrupoImagemPlanejamento.PRPO,Ordem=2,TipoMime="video/mp4"});
        for(int i=0;i<65;i++)p.Integrantes.Add(new PlanejamentoIntegrante{ID=i,Operador=new Operador{Nome=$"Operador de demonstração {i+1}"},Entrada="AF 1",Funcao="Comunicação",Viatura=new Viatura{Placa="ABC1D23"}});
        var pdf=new GeradorPlanejamentoPdf(storage).Gerar(p,new Dictionary<int,AnexoAlvo>{{1,new AnexoAlvo{Caminho="foto"}}},"https://exemplo.invalid");
        using var stream=new MemoryStream(pdf);using var documento=PdfReader.Open(stream,PdfDocumentOpenMode.Import);
        if(documento.PageCount<3 || documento.Info.Title!=p.ObterTituloExibicao())throw new Exception("PDF sem paginação ou título correto.");
        if(output!=null){Directory.CreateDirectory(Path.GetDirectoryName(output)!);File.WriteAllBytes(output,pdf);}
        Console.WriteLine($"PDF: {documento.PageCount} páginas, geração em memória e leitura verificadas.");
    }
}
