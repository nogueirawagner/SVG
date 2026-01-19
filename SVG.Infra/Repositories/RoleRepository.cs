using SVG.Domain.Entities.Identity;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.Auth;
using SVG.Domain.TiposEstruturados.TiposOperacao;
using SVG.Infra.Context.SQLServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Infra.Repositories
{
  public class RoleRepository : RepositoryBase<Role>, IRoleRepository
  {

    private readonly SQLServerContext _db;

    public RoleRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }

    public XRole ObterPorNome(string pNome)
    {
      var sql = @"
          select ID, Nome from Role
          where Nome = @pNome";

      return _db.Database.
         SqlQuery<XRole>(sql,
           new SqlParameter("@pNome", pNome)
         ).FirstOrDefault();
    }
  }
}
