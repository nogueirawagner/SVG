using SVG.Domain.Entities.Identity;
using SVG.Domain.Interfaces.Services;
using SVG.Infra.Context.SQLServer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Infra.Repositories
{
  public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
  {
    private readonly SQLServerContext _db;

    public UsuarioRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }

    public async Task<Usuario?> ObterPorIdAsync(int id)
    {
      return await _db.Usuario
          .Include("Roles.Role")
          .Include("Operador")
          .FirstOrDefaultAsync(u => u.ID == id);
    }

    public async Task<Usuario?> ObterPorLoginAsync(string login)
    {
      return await _db.Usuario
          .Include("Roles.Role")
          .Include("Operador")
          .FirstOrDefaultAsync(u => u.Login == login);
    }

    public async Task<IEnumerable<Usuario>> ListarAsync()
    {
      return await _db.Usuario
          .Include("Roles.Role")
          .Include("Operador")
          .OrderBy(u => u.Login)
          .ToListAsync();
    }

    public async Task AdicionarAsync(Usuario usuario)
    {
      _db.Usuario.Add(usuario);
      await _db.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Usuario usuario)
    {
      _db.Entry(usuario).State = EntityState.Modified;
      await _db.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
      var usuario = await _db.Usuario.FindAsync(id);
      if (usuario == null)
        return;

      _db.Usuario.Remove(usuario);
      await _db.SaveChangesAsync();
    }

    public async Task CriarUsuarioAsync(Usuario usuario)
    {
      if (usuario == null)
        throw new ArgumentNullException(nameof(usuario));

      _db.Usuario.Add(usuario);
      await _db.SaveChangesAsync();
    }
  }
}
