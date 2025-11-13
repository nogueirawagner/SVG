using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.FunctionsDB;
using SVG.Infra.Repositories;

namespace GestaoDDD.Infra.Data.Repositories
{
  public class OperadorRepository : RepositoryBase<Operador>, IOperadorRepository
  {
    private readonly SQLServerContext _db;

    public OperadorRepository(SQLServerContext dbContext)
        : base(dbContext)
    {
      _db = dbContext;
    }

    public void AtualizarNotaCFP(int pOperadorId, double pNota)
    {
      //var Operador = GetById(pOperadorId);
      //Operador.NotaEtapa2 = pNota;
      //Operador.NotaFinalProvisoria = Operador.NotaEtapa1 + pNota;
      //Update(Operador);
      //Task.Run(() => Task.FromResult(AtualizarRankingOperador(Operador.Concorrencia)));
    }

    private Task<int> AtualizarRankingOperador(string pConcorrencia)
    {
      using (var db = new SQLServerContext())
      {
        var sql = string.Format(@"update Operador set Posicao = 0 where Cargo = 'Agente' and Concorrencia = '{0}'", pConcorrencia);
        db.Database.ExecuteSqlCommand(sql);

        var sqlAtualiza = string.Format(@"

            WITH AtualizarRank AS (

            select 
            ID, Nome,
            ROW_NUMBER ( )   
                OVER ( order by NotaFinal desc )  Posicao

            from Operador where Cargo = 'Agente'
            and Concorrencia = '{0}'
            )

            update a set a.Posicao = ar.Posicao from Operador a
            join AtualizarRank ar on ar.ID = a.ID
        ", pConcorrencia);

        return Task.FromResult(db.Database.ExecuteSqlCommand(sqlAtualiza));
      }
    }

    public IEnumerable<Operador> PesquisarOperadorsPorPalavras(string pTermo, string pConcorrencia, string pCargo)
    {
      var pChaves = new List<string>();
      var where = XFullText.MontarCondicao(pTermo, "Nome", out pChaves);

      var sql = @"SELECT * FROM Operador WHERE {0} and Concorrencia = '{1}' and Cargo = '{2}' ORDER BY Posicao";
      //var sql = @"SELECT * FROM Operador WHERE {0} and Concorrencia = '{1}' and Cargo = '{2}' ORDER BY PosicaoProvisoria";

      sql = string.Format(sql, where, pConcorrencia, pCargo);
      return _db.Database.SqlQuery<Operador>(sql);
    }

    public string PegarMediaCalculada()
    {
      var sql = @"select 
	        CAST(AVG(NotaEtapa2) as numeric(18,2)) Media 
        from Operador 
        where Cargo = 'Agente' 
	        and NotaFinal > 0
	        and NotaEtapa2 <> 43.25
	        and NotaEtapa2 > 0
        ";

      var media = _db.Database.SqlQuery<decimal>(sql).FirstOrDefault();
      return string.Format("Média: {0}", media);
    }

    public IEnumerable<Operador> PegarOperadorsPorCargoConcorrencia(string pCargo, string pConcorrencia)
    {
      var sql = @"SELECT * FROM Operador WHERE Concorrencia = '{0}' and Cargo = '{1}' ORDER BY Posicao";
      //var sql = @"SELECT * FROM Operador WHERE Concorrencia = '{0}' and Cargo = '{1}' ORDER BY PosicaoProvisoria";

      sql = string.Format(sql, pConcorrencia, pCargo);

      return _db.Database.SqlQuery<Operador>(sql);
    }
  }
}
