using System.Security.Cryptography;
using System.Text.RegularExpressions;
using SVG.Domain.Interfaces.Services;

namespace SVG.Infra.Storage;

public sealed class ArmazenamentoAnexosLocal : IArmazenamentoAnexos
{
    private readonly string raiz;
    public ArmazenamentoAnexosLocal(string raiz) => this.raiz = Path.GetFullPath(raiz);

    public string Gravar(string categoria, int entidadeId, byte[] conteudo, string tipoMime)
    {
        if (categoria is not ("Planejamento" or "Alvo") || entidadeId <= 0)
            throw new ArgumentException("Destino de anexo inválido.");
        var extensao = tipoMime switch
        {
            "image/png" => ".png", "image/jpeg" => ".jpg",
            "video/mp4" => ".mp4", "video/webm" => ".webm",
            _ => throw new ArgumentException("Tipo de anexo inválido.")
        };
        // Entropia por upload evita colisões e não expõe o nome original no caminho.
        var hash = Convert.ToHexString(SHA256.HashData(RandomNumberGenerator.GetBytes(32))).ToLowerInvariant();
        var caminho = $"Imagens/{categoria}/{entidadeId}/{hash}{extensao}";
        var absoluto = Resolver(caminho);
        Directory.CreateDirectory(Path.GetDirectoryName(absoluto)!);
        using (var arquivo = new FileStream(absoluto, FileMode.CreateNew, FileAccess.Write, FileShare.None))
        {
            try { arquivo.Write(conteudo); arquivo.Flush(true); }
            catch { arquivo.Dispose(); File.Delete(absoluto); throw; }
        }
        return caminho;
    }

    public Stream? Abrir(string caminho)
    {
        try { return new FileStream(Resolver(caminho), FileMode.Open, FileAccess.Read, FileShare.Read); }
        catch (FileNotFoundException) { return null; }
        catch (DirectoryNotFoundException) { return null; }
    }

    public void Excluir(string caminho) => File.Delete(Resolver(caminho));

    private string Resolver(string caminho)
    {
        if (!Regex.IsMatch(caminho, @"\AImagens/(Planejamento|Alvo)/[1-9][0-9]*/[a-f0-9]{64}\.(png|jpg|mp4|webm)\z"))
            throw new ArgumentException("Caminho de anexo inválido.");
        return Path.Combine(raiz, caminho.Replace('/', Path.DirectorySeparatorChar));
    }
}
