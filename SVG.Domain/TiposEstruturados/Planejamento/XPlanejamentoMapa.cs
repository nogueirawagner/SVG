namespace SVG.Domain.TiposEstruturados.Planejamento;

public record XPlanejamentoMapa(int ID, string Titulo, int? Ano, int? Mes, int SecaoID,
    string Secao, string? Endereco, decimal Latitude, decimal Longitude);
