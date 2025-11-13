//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;

//namespace GestaoDDD.Application.ViewModels
//{
//  public class CandidatoViewModel
//  {
//    [Key]
//    public int ID { get; set; }

//    [Required(ErrorMessage = "Preencha seu nome ou de seus colegas")]
//    [DisplayName("Nome:")]
//    public string Nome { get; set; }


//    [Required(ErrorMessage = "Preencha com o seu WhatsApp")]
//    [DataType(DataType.PhoneNumber)]
//    public string Telefone { get; set; }

//    [DisplayName("Descricao:")]
//    [DataType(DataType.MultilineText)]
//    public string Descricao { get; set; }

//    public string TipoVeiculo { get; set; }


//    [Required(ErrorMessage = "Preencha o endereço que ficará hospedado.")]
//    [MaxLength(200, ErrorMessage = "Tamanho máximo de {0} caracteres.")]
//    [MinLength(5, ErrorMessage = "Tamanho minímo de {0} caracteres.")]
//    [DisplayName("Endereço:")]
//    public string Endereco { get; set; }

//    public int QtdVagasCarro { get; set; }

//    public string Turma { get; set; }

//    [Required(ErrorMessage = "Marque seu local no mapa.")]
//    public string Latitude { get; set; }
    
//    public string Longitude { get; set; }

//    [DataType(DataType.Currency)]
//    public double Valor { get; set; }
//    public int QtdVagasDisponivelCasa { get; set; }

//    public string DistanciaColega { get; set; }
//  }
//}