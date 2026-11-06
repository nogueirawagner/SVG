using SVG.Domain.TiposEstruturados.Planejamento;

namespace SVG.Domain.Interfaces.Services;

public interface IGoogleMapsService
{
    Task<XCoordenadasMaps> ResolverAsync(string link, CancellationToken cancellationToken = default);
}
