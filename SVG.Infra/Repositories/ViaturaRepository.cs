using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.Enums;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;
using System.Data.Entity;

namespace SVG.Infra.Repositories
{
  public class ViaturaRepository : RepositoryBase<Viatura>, IViaturaRepository
  {
    private readonly SQLServerContext _db;

    public ViaturaRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }

    public IEnumerable<Viatura> PegarDisponiveis()
    {
      return _db.Viatura
            .Include(x => x.Sessao)
            .Include(x => x.Operador)
            .Where(x => x.Situacao == XSituacaoViatura.Disponivel)
            .ToList();
    }

    public IEnumerable<Viatura> PegarPorSecao(int pSecaoID)
    {
      return _db.Viatura
               .Include(x => x.Sessao)
               .Include(x => x.Operador)
               .Where(x => x.SessaoID == pSecaoID)
               .ToList();
    }
  }
}
