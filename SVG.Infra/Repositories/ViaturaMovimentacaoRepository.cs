using SVG.Domain.Entities;
using SVG.Domain.Interfaces;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using System.Data.Entity;

namespace SVG.Infra.Repositories
{
  public class ViaturaMovimentacaoRepository
    : RepositoryBase<ViaturaMovimentacao>, IViaturaMovimentacaoRepository
  {
    private readonly SQLServerContext _db;

    public ViaturaMovimentacaoRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }

    public IEnumerable<ViaturaMovimentacao> PegarPorViatura(int pViaturaID)
    {
      return _db.ViaturaMovimentacao
               .Include(x => x.Viatura)
               .Include(x => x.Operador)
               .Where(x => x.ViaturaID == pViaturaID)
               .OrderByDescending(x => x.DataHoraRetirada)
               .ToList();
    }

    public ViaturaMovimentacao PegarMovimentacaoAberta(int pViaturaID)
    {
      return _db.ViaturaMovimentacao
               .Include(x => x.Viatura)
               .Include(x => x.Operador)
               .FirstOrDefault(x =>
                 x.ViaturaID == pViaturaID &&
                 x.DataHoraDevolucao == null);
    }

    public ViaturaMovimentacao PegarUltimaMovimentacao(int pViaturaID)
    {
      return _db.ViaturaMovimentacao
               .Where(x => x.ViaturaID == pViaturaID)
               .OrderByDescending(x => x.DataHoraRetirada)
               .ThenByDescending(x => x.ID)
               .FirstOrDefault();
    }

  }
}