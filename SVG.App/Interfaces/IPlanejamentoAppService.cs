using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.Planejamento;
using SVG.App.ViewModels;
namespace SVG.App.Interfaces;
public interface IPlanejamentoAppService
{
    Planejamento? Obter(int id);
    PlanejamentoViewModel? PrepararEdicao(int id);
    Alvo? ObterAlvo(int id);
    AnexoAlvo? ObterFoto(int id);
    AnexoPlanejamento? ObterAnexo(int id);
    AnexoAlvo? ObterAnexoAlvo(int id);
    IReadOnlyList<XAlvoResumo> BuscarAlvos(string termo);
    IReadOnlyList<XPlanejamentoMapa> ListarMapa();
    IReadOnlyList<XPlanejamentoResumo> Listar(int? secaoId);
    void Excluir(int id, string versao, XAutorPlanejamento autor);
    int Salvar(PlanejamentoViewModel model, XAutorPlanejamento autor, IReadOnlyList<XAnexoAlvoEntrada> fotos, bool finalizar, IReadOnlyList<XArquivoPlanejamentoEntrada>? anexos=null);
}
