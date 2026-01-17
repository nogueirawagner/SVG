using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Domain.Entities.Identity
{
  public class Usuario
  {
    public int Id { get; set; }

    public string Login { get; set; } = null!;
    public string Nome { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public bool Ativo { get; set; }

    // 🔹 FK opcional
    public int? OperadorId { get; set; }
    public Operador? Operador { get; set; }

    public ICollection<UsuarioRole> Roles { get; set; } = new List<UsuarioRole>();
  }
}

