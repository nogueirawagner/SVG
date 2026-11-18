using SVG.Domain.Entities;
using SVG.Domain.TiposEstruturados.Planejamento;

namespace SVG.Domain.Interfaces.Repositories;

public interface IPlanejamentoRepository
{
    Planejamento? Obter(int id);
    Alvo? ObterAlvo(int id);
    AnexoAlvo? ObterFoto(int alvoId);
    AnexoPlanejamento? ObterAnexo(int id);
    AnexoAlvo? ObterAnexoAlvo(int id);
    IReadOnlyList<XAlvoResumo> BuscarAlvos(string termo);
    IReadOnlyList<XPlanejamentoMapa> ListarMapa();
    IReadOnlyList<XPlanejamentoResumo> Listar(int? secaoId);
    int Salvar(XPlanejamentoEntrada entrada, XAutorPlanejamento autor, IReadOnlyList<XAnexoAlvoEntrada> fotos, bool finalizar, IReadOnlyList<XArquivoPlanejamentoEntrada>? anexos=null);
}
