using SVG.Infra.Storage;
using SVG.Domain.Services;
using SVG.Domain.Entities;

public static class PlanejamentoStorageChecks
{
    public static void Run()
    {
        var raiz=Path.Combine(Path.GetTempPath(),"svg-anexos-"+Guid.NewGuid().ToString("N"));
        var storage=new ArmazenamentoAnexosLocal(raiz);
        var caminhos=new List<string>();
        void Check(bool ok,string text){if(!ok)throw new Exception(text);}
        try
        {
            var png=new byte[]{137,80,78,71,13,10,26,10};
            var a=storage.Gravar("Alvo",1,png,"image/png"); caminhos.Add(a);
            var b=storage.Gravar("Planejamento",1,png,"image/png"); caminhos.Add(b);
            var c=storage.Gravar("Alvo",1,png,"image/png"); caminhos.Add(c);
            Check(a!=c && a.StartsWith("Imagens/Alvo/1/") && b.StartsWith("Imagens/Planejamento/1/"),"Nomes ou diretórios colidem.");
            using(var stream=storage.Abrir(a))
            {
                using var memory=new MemoryStream();stream!.CopyTo(memory);
                Check(memory.ToArray().SequenceEqual(png),"Conteúdo do arquivo alterado.");
            }
            foreach(var invalido in new[]{"../segredo","/Imagens/Alvo/1/a.png","Imagens/Alvo/1/../../segredo"})
            {
                bool rejected=false;
                try{using var stream=storage.Abrir(invalido);}catch(ArgumentException){rejected=true;}
                Check(rejected,"Caminho externo aceito.");
            }
            storage.Excluir(c);Check(storage.Abrir(c)==null,"Compensação não removeu arquivo.");
            Check(typeof(AnexoAlvo).GetProperty("Conteudo")==null && typeof(AnexoPlanejamento).GetProperty("Conteudo")==null,"Anexo persiste binário no banco.");
            var mp4=new byte[24];System.Text.Encoding.ASCII.GetBytes("ftypisom").CopyTo(mp4,4);
            Check(PlanejamentoService.TipoArquivo(mp4)=="video/mp4","MP4 não reconhecido.");
            Check(PlanejamentoService.TipoArquivo(new byte[]{0x1a,0x45,0xdf,0xa3,0x42,0x82,0x84,0x77,0x65,0x62,0x6d,0})=="video/webm","WebM não reconhecido.");
            Check(PlanejamentoService.TipoArquivo(System.Text.Encoding.UTF8.GetBytes("<script>falso.mp4</script>"))==null,"Arquivo falso aceito.");
        }
        finally
        {
            foreach(var caminho in caminhos)storage.Excluir(caminho);
            foreach(var categoria in new[]{"Alvo","Planejamento"})
            {
                var diretorio=Path.Combine(raiz,"Imagens",categoria,"1");
                if(Directory.Exists(diretorio))Directory.Delete(diretorio);
                diretorio=Path.GetDirectoryName(diretorio)!;
                if(Directory.Exists(diretorio))Directory.Delete(diretorio);
            }
            if(Directory.Exists(Path.Combine(raiz,"Imagens")))Directory.Delete(Path.Combine(raiz,"Imagens"));
            if(Directory.Exists(raiz))Directory.Delete(raiz);
        }
        Console.WriteLine("Anexos: caminhos isolados, hashes únicos, leitura, compensação e formatos verificados.");
    }
}
