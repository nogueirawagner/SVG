using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.BI;
using SVG.Infra.Context.SQLServer;

namespace SVG.Infra.Repositories
{
  public class BIRepository : RepositoryBase<Operacao>, IBIRepository
  {
    private readonly SQLServerContext _db;

    public BIRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }

    public async Task<IEnumerable<XAdesaoSvg>> ObterMensalAsync()
    {
      return await _db.Database
          .SqlQuery<XAdesaoSvg>(
              @"SELECT * FROM vw_dm_adesao_svg_mensal"
          )
          .ToListAsync();
    }

    public async Task<IEnumerable<XAdesaoSvg>> ObterBimestralAsync()
    {
      return await _db.Database
          .SqlQuery<XAdesaoSvg>(
              @"SELECT * FROM vw_dm_adesao_svg_bimestral"
          )
          .ToListAsync();
    }

    public async Task<IEnumerable<XAdesaoSvg>> ObterTrimestralAsync()
    {
      return await _db.Database
          .SqlQuery<XAdesaoSvg>(
              @"SELECT * FROM vw_dm_adesao_svg_trimestral"
          )
          .ToListAsync();
    }

    public async Task<IEnumerable<XAdesaoSvg>> ObterSemestralAsync()
    {
      return await _db.Database
          .SqlQuery<XAdesaoSvg>(
              @"SELECT * FROM vw_dm_adesao_svg_semestral"
          )
          .ToListAsync();
    }

    public async Task<IEnumerable<XOperacaoBi>> ObterOperacoesPeriodo(string periodo)
    {
      var view = periodo switch
      {
        "mensal" => "vw_dm_operacao_mensal",
        "bimestral" => "vw_dm_operacao_bimestral",
        "trimestral" => "vw_dm_operacao_trimestral",
        "semestral" => "vw_dm_operacao_semestral",
        _ => throw new ArgumentException("Período inválido")
      };

      return await _db.Database
          .SqlQuery<XOperacaoBi>($"SELECT * FROM {view}")
          .ToListAsync();
    }

    public async Task<IEnumerable<XParticipacaoOperador>> ObterParticipacaoOperadorPeriodo(string periodo)
    {
      var view = periodo switch
      {
        "mensal" => "vw_dm_participacao_operador_mensal",
        "bimestral" => "vw_dm_participacao_operador_bimestral",
        "trimestral" => "vw_dm_participacao_operador_trimestral",
        "semestral" => "vw_dm_participacao_operador_semestral",
        _ => throw new ArgumentException("Período inválido")
      };

      return await _db.Database
          .SqlQuery<XParticipacaoOperador>($"SELECT * FROM {view}")
          .ToListAsync();
    }
  }
}
