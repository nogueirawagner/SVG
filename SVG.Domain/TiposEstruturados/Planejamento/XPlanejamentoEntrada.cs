using System.ComponentModel.DataAnnotations;

namespace SVG.Domain.TiposEstruturados.Planejamento;

// Contrato de entrada: não expõe seção, autor, situação ou navegações persistidas.
public class XPlanejamentoEntrada
{
    public int ID { get; set; }
    public string? Versao { get; set; }
    [StringLength(200)] public string? Titulo { get; set; }
    [StringLength(300)] public string? LocalBriefing { get; set; }
    public TimeSpan? HorarioBriefingDOE { get; set; }
    public TimeSpan? HorarioSaidaDOE { get; set; }
    public TimeSpan? HorarioBriefingDP { get; set; }
    [StringLength(200)] public string? SocorristaAPH1 { get; set; }
    [StringLength(200)] public string? SocorristaAPH2 { get; set; }
    [StringLength(200)] public string? MotoristaVtrAPH { get; set; }
    [StringLength(100)] public string? PrefixoVtrAPH { get; set; }
    [StringLength(200)] public string? ResponsavelRelatorio { get; set; }
    [StringLength(200)] public string? ResponsavelFotoMBA { get; set; }
    [StringLength(200)] public string? CoordenadaZPH { get; set; }
    [StringLength(2048)] public string? Link_Rota_DOE_Unidade_Apoio { get; set; }
    [StringLength(2048)] public string? Link_Rota_DP_Desemb { get; set; }
    [StringLength(2048)] public string? Link_Localizacao_Desemb { get; set; }
    [StringLength(2048)] public string? Link_Localizacao_Hospital_1 { get; set; }
    [StringLength(2048)] public string? Link_Localizacao_Hospital_2 { get; set; }
    [Range(0,100000)] public decimal? DistanciaRotaDOEUnidadeApoioKm { get; set; }
    [Range(0,100000)] public int? DuracaoRotaDOEUnidadeApoioMinutos { get; set; }
    [Range(0,100000)] public decimal? DistanciaRotaDPDesembKm { get; set; }
    [Range(0,100000)] public int? DuracaoRotaDPDesembMinutos { get; set; }
    public bool MBA { get; set; }
    public bool MP { get; set; }
    [StringLength(100)] public string? NumeroMBA { get; set; }
    public DateTime? DataPrevista { get; set; }
    [StringLength(100)] public string? OrdemServico { get; set; }
    [StringLength(200)] public string? UnidadeApoio { get; set; }
    [StringLength(8000)] public string? Objetivo { get; set; }
    [StringLength(1000)] public string? Endereco { get; set; }
    [StringLength(1000)] public string? Referencia { get; set; }
    [StringLength(2048)] public string? Link_Endereco_Alvo { get; set; }
    [Range(-90,90)] public decimal? Latitude { get; set; }
    [Range(-180,180)] public decimal? Longitude { get; set; }
    [StringLength(200)] public string? CanalViaturas { get; set; }
    [StringLength(200)] public string? CanalOperadores { get; set; }
    [StringLength(8000)] public string? ApoioMedico { get; set; }
    [StringLength(8000)] public string? Particularidades { get; set; }
    public List<XAlvoEntrada> Alvos { get; set; } = new();
    public List<XItemEntrada> Itens { get; set; } = new();
    public List<XIntegranteEntrada> Integrantes { get; set; } = new();
}

public class XAlvoEntrada
{
    public int? AlvoID { get; set; }
    [StringLength(30)] public string? Codigo { get; set; }
    [StringLength(200)] public string? Nome { get; set; }
    [StringLength(200)] public string? Alcunha { get; set; }
    [StringLength(14)] public string? CPF { get; set; }
    [StringLength(100)] public string? RG { get; set; }
    public DateTime? DataNascimento { get; set; }
    [StringLength(200)] public string? NomeMae { get; set; }
    [StringLength(200)] public string? NomePai { get; set; }
    [StringLength(8000)] public string? Observacoes { get; set; }
    [StringLength(8000)] public string? Informacoes { get; set; }
    [StringLength(500)] public string? Fonte { get; set; }
}

public class XItemEntrada
{
    [Required] public string Tipo { get; set; } = "Horario";
    [Required, StringLength(1000)] public string Descricao { get; set; } = "";
    public DateTime? DataHora { get; set; }
    [StringLength(200)] public string? Responsavel { get; set; }
    [StringLength(2000)] public string? Url { get; set; }
    [Range(0,100000)] public decimal? DistanciaKm { get; set; }
    [Range(0,100000)] public int? DuracaoMinutos { get; set; }
}

public class XIntegranteEntrada
{
    [Range(1,int.MaxValue)] public int OperadorID { get; set; }
    public int? ViaturaID { get; set; }
    [StringLength(100)] public string? Entrada { get; set; }
    [Required, StringLength(300)] public string Funcao { get; set; } = "";
}

public record XAnexoAlvoEntrada(int IndiceAlvo, string NomeArquivo, byte[] Conteudo, bool FotoPrincipal = false);
public record XArquivoPlanejamentoEntrada(string NomeArquivo, byte[] Conteudo);
public record XAutorPlanejamento(int OperadorID, bool Administrador);
public record XAlvoResumo(int ID, string Nome, string? Alcunha, string? CPF, int QuantidadePlanejamentos);
public record XPlanejamentoResumo(int ID, string Titulo, DateTime? DataPrevista, string Situacao,
    string Secao, string? Endereco, int QuantidadeAlvos);
