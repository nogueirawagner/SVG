using SVG.Domain.Entities.Identity;

namespace SVG.Domain.Configurations.Interface
{
  public interface IPasswordService
  {
    string Hash(Usuario user, string senha);
    bool Verificar(Usuario user, string senha);
  }
}
