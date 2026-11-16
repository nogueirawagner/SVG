namespace SVG.Domain.Entities;

public class Planejamento
{
    public string ObterTituloExibicao() => FormatarTitulo(DataPrevista, UnidadeApoio, Secao?.Nome);

    public static string FormatarTitulo(DateTime? data, string? unidadeApoio, string? secao)
    {
        var dataTexto=data?.ToString("dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture) ?? "Data não informada";
        var unidade=string.IsNullOrWhiteSpace(unidadeApoio)?"Unidade não informada":unidadeApoio.Trim();
        var nomeSecao=string.IsNullOrWhiteSpace(secao)?"Seção não informada":secao.Trim();
        return $"Planejamento {dataTexto} {unidade} - {nomeSecao}";
    }

    public int ID { get; set; }
    public int SecaoID { get; set; }
    public int CriadorOperadorID { get; set; }
    public string Titulo { get; set; } = "";
    public string? LocalBriefing { get; set; }
    public TimeSpan? HorarioBriefingDOE { get; set; }
    public TimeSpan? HorarioSaidaDOE { get; set; }
    public TimeSpan? HorarioBriefingDP { get; set; }
    public string? SocorristaAPH1 { get; set; }
    public string? SocorristaAPH2 { get; set; }
    public string? MotoristaVtrAPH { get; set; }
    public string? PrefixoVtrAPH { get; set; }
    public string? ResponsavelRelatorio { get; set; }
    public string? ResponsavelFotoMBA { get; set; }
    public string? CoordenadaZPH { get; set; }
    public string? Link_Rota_DOE_Unidade_Apoio { get; set; }
    public string? Link_Rota_DP_Desemb { get; set; }
    public string? Link_Localizacao_Desemb { get; set; }
    public string? Link_Localizacao_Hospital_1 { get; set; }
    public string? Link_Localizacao_Hospital_2 { get; set; }
    public decimal? DistanciaRotaDOEUnidadeApoioKm { get; set; }
    public int? DuracaoRotaDOEUnidadeApoioMinutos { get; set; }
    public decimal? DistanciaRotaDPDesembKm { get; set; }
    public int? DuracaoRotaDPDesembMinutos { get; set; }
    public bool MBA { get; set; }
    public bool MP { get; set; }
    public string? NumeroMBA { get; set; }
    public DateTime? DataPrevista { get; set; }
    public string Situacao { get; set; } = "Rascunho";
    public string? OrdemServico { get; set; }
    public string? UnidadeApoio { get; set; }
    public string? Objetivo { get; set; }
    public string? Endereco { get; set; }
    public string? Referencia { get; set; }
    public string? Link_Endereco_Alvo { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public string? CanalViaturas { get; set; }
    public string? CanalOperadores { get; set; }
    public string? ApoioMedico { get; set; }
    public string? Particularidades { get; set; }
    public DateTime DataHoraCriacao { get; set; }
    public DateTime DataHoraAtualizacao { get; set; }
    public int AtualizadoPorOperadorID { get; set; }
    public byte[] Versao { get; set; } = Array.Empty<byte>();
    public virtual Sessao Secao { get; set; } = null!;
    public virtual ICollection<PlanejamentoAlvo> Alvos { get; set; } = new List<PlanejamentoAlvo>();
    public virtual ICollection<PlanejamentoItem> Itens { get; set; } = new List<PlanejamentoItem>();
    public virtual ICollection<AnexoPlanejamento> Anexos { get; set; } = new List<AnexoPlanejamento>();
    public virtual ICollection<PlanejamentoIntegrante> Integrantes { get; set; } = new List<PlanejamentoIntegrante>();
}
