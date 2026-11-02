using System.ComponentModel.DataAnnotations;

namespace SVG.WebApp.Models
{
  public class ViaturaRegistroViewModel : IValidatableObject
  {
    [Required(ErrorMessage = "Informe a data e hora.")]
    public DateTime? DataHora { get; set; }

    [Required(ErrorMessage = "Informe o nível de combustível.")]
    [Range(0, 100, ErrorMessage = "O nível de combustível deve estar entre 0% e 100%.")]
    public int? NivelCombustivel { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (DataHora.HasValue && (DataHora.Value > DateTime.Now || DataHora.Value < new DateTime(1753, 1, 1)))
        yield return new ValidationResult("Informe uma data e hora válida, que não seja futura.", new[] { nameof(DataHora) });
    }
  }
}
