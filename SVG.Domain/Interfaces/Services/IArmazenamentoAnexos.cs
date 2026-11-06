namespace SVG.Domain.Interfaces.Services;

// Caminhos relativos são chaves portáveis para disco local ou armazenamento Azure.
public interface IArmazenamentoAnexos
{
    string Gravar(string categoria, int entidadeId, byte[] conteudo, string tipoMime);
    Stream? Abrir(string caminho);
    void Excluir(string caminho);
}
