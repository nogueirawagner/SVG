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
  }
}
