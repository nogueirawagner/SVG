using SVG.Domain.Entities;
namespace SVG.Domain.Interfaces.Services;

public interface IGeradorPlanejamentoPdf
{
    byte[] Gerar(Planejamento planejamento, IReadOnlyDictionary<int, AnexoAlvo> fotos, string urlBase);
}
