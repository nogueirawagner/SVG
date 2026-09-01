using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.TiposEstruturados.TiposOperacao;
using SVG.Domain.TiposEstruturados.TiposOperador;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SVG.Infra.Repositories
{
  public class OperacaoRepository : RepositoryBase<Operacao>, IOperacaoRepository
  {
    private readonly SQLServerContext _db;

    public OperacaoRepository(SQLServerContext dbContext)
      : base(dbContext)
    {
      _db = dbContext;
    }

    public IEnumerable<XCandidatosOperacaoSVG> PegaCandidatoSVG(int pOperacaoID)
    {
      var sql = @"
            select 
	            c.OperacaoID, 
	            c.OperadorID,
	            o.Nome,
	            o.Matricula
            from CandidatoSVGOperacao c
	            join Operador o on o.ID = c.OperadorID
            where c.OperacaoID = @pOperacaoID";

      return _db.Database.
         SqlQuery<XCandidatosOperacaoSVG>(sql,
           new SqlParameter("@pOperacaoID", pOperacaoID)
         );
    }

    public void InsereCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _db.Database.ExecuteSqlCommand(@"
        IF NOT EXISTS (
            SELECT 1
            FROM CandidatoSVGOperacao
            WHERE OperadorID = @pOperadorID
              AND OperacaoID = @pOperacaoID
        )
        BEGIN
            INSERT INTO CandidatoSVGOperacao (OperadorID, OperacaoID, DataHoraCriacao)
            VALUES (@pOperadorID, @pOperacaoID, GETDATE())
        END",
       new SqlParameter("@pOperacaoID", pOperacaoID),
       new SqlParameter("@pOperadorID", pOperadorID)
      );
    }

    public void RemoveCandidatoSVG(int pOperacaoID, int pOperadorID)
    {
      _db.Database.ExecuteSqlCommand(@"
          DELETE FROM CandidatoSVGOperacao 
          WHERE OperacaoID = @pOperacaoID 
            and OperadorID = @pOperadorID",
        new SqlParameter("@pOperacaoID", pOperacaoID),
        new SqlParameter("@pOperadorID", pOperadorID)
      );
    }

    public IEnumerable<XOperacoesSVGAberto> PegarOperacoesSVGAbertoOperador(int pOperadorID)
    {
      var sql = @"
          select 
            o.ID, 
            o.DataHoraCriacao,
            o.DataHora,
            COALESCE(o.DataHoraInicio, o.DataHora) DataHoraInicio,
            o.DataHoraFim,
            o.Objeto,
            o.OrdemServico OS,
            o.Coordenador,
            t.Nome TipoOperacao,
            o.QtdVagasRestantes,
            CAST(
	            (CASE	
		          WHEN cand.ID is null THEN 0
		          ELSE 1
	            END) 
            as bit) OperadorVoluntario,
            (select COUNT(*) from CandidatoSVGOperacao csvg  where OperacaoID = o.ID) QtdOperadoresVoluntarios
          from Operacao o
            join TipoOperacao t on t.ID = o.TipoOperacaoID
            left join OperadorOperacao oop on oop.OperacaoID = o.ID
	          and oop.OperadorID = @pOperadorID
            left join CandidatoSVGOperacao cand on cand.OperacaoID = o.ID
	          and cand.OperadorID = @pOperadorID
          where SvgAberto = 1
	          and oop.ID is null
          order by DataHoraCriacao desc, DataHoraInicio desc, DataHoraFim desc
        ";
      return _db.Database.
       SqlQuery<XOperacoesSVGAberto>(sql,
        new SqlParameter("@pOperadorID", pOperadorID));
    }

    public IEnumerable<XOperacoesSVGAberto> PegarOperacoesSVGAberto()
    {
      var sql = @"
          select 
	          o.ID, 
            o.DataHoraCriacao,
	          o.DataHora,
	          COALESCE(o.DataHoraInicio, o.DataHora) DataHoraInicio,
	          o.DataHoraFim,
	          t.Nome TipoOperacao,
	          o.QtdVagasRestantes
          from Operacao o
	          join TipoOperacao t on t.ID = o.TipoOperacaoID
          where SvgAberto = 1
          order by DataHoraCriacao desc, DataHoraInicio desc, DataHoraFim desc
        ";
      return _db.Database.
       SqlQuery<XOperacoesSVGAberto>(sql);
    }

    public IEnumerable<XOperacoesRealizadas> PegarOperacoesRealizadas()
    {
      var sql = @"
        select 
          o.ID,
          o.DataHoraCriacao,
          o.DataHora,
          o.Objeto,
          REPLACE(OrdemServico, 'OS ', '') OrdemServico,
          o.Coordenador,
          t.Nome TipoOperacao, 
          o.SvgAberto,
          o.QtdVagasRestantes,
          o.DataHoraFim,
          (select COUNT(*) from CandidatoSVGOperacao csvg  where OperacaoID = o.ID) QtdOperadoresVoluntarios
        from Operacao o
          join TipoOperacao t on t.ID = o.TipoOperacaoID
        order by DataHoraCriacao desc
        ";

      return _db.Database.
         SqlQuery<XOperacoesRealizadas>(sql);
    }

    public IEnumerable<XOperacoesRealizadas> ListarOperacoesPorOrdemServico(string pOrdemServico)
    {
      var sql = @"
        select 
          o.ID,
          o.DataHoraCriacao,
          o.DataHoraInicio,
          o.Objeto,
          REPLACE(OrdemServico, 'OS ', '') OrdemServico,
          (select COUNT(*) from OperadorOperacao where OperacaoID = o.ID) QtdOperadores,
          o.Coordenador,
          t.Nome TipoOperacao, 
          o.SvgAberto,
          o.QtdVagasRestantes,
          o.DataHoraFim
        from Operacao o
          join TipoOperacao t on t.ID = o.TipoOperacaoID
        where contains(OrdemServico, @pOrdemServico)
          and YEAR(DataHora) = YEAR(GETDATE())
        order by DataHoraCriacao desc
        ";

      return _db.Database.
         SqlQuery<XOperacoesRealizadas>(sql,
           new SqlParameter("@pOrdemServico", pOrdemServico)
         );
    }

    public IEnumerable<XDetalhesOperacao> PegarDetalhesOperacao(int pOperacaoID)
    {
      var sql = @"
        select 
	        o.ID,
	        o.DataHoraCriacao,
	        o.DataHora,
	        o.Objeto,
          o.OrdemServico,
	        o.Coordenador,
	        t.Nome TipoOperacao,
	        op.ID OperadorID,
	        op.Nome NomeOperador,
	        op.Matricula,
	        op.Telefone,
	        oo.SVG,
	        s.Nome Sessao
        from Operacao o
	        join TipoOperacao t on t.ID = o.TipoOperacaoID
	        join OperadorOperacao oo on oo.OperacaoID = o.ID
	        join Operador op on op.ID = oo.OperadorID
	        join Sessao s on s.ID = op.SessaoID
        where o.ID = @pOperacaoID
        order by SVG desc, Sessao
        ";

      var raw = _db.Database.
         SqlQuery<XDetalhesOperacao>(sql,
           new SqlParameter("@pOperacaoID", pOperacaoID)
         );

      foreach (var item in raw)
      {
        yield return new XDetalhesOperacao
        {
          ID = item.ID,
          DataHoraCriacao = item.DataHoraCriacao,
          DataHora = item.DataHora,
          Objeto = item.Objeto,
          OrdemServico = item.OrdemServico,
          Coordenador = item.Coordenador,
          TipoOperacao = item.TipoOperacao,
          OperadorID = item.OperadorID,
          NomeOperador = item.NomeOperador,
          Matricula = item.Matricula,
          Telefone = item.Telefone,
          SVG = item.SVG,
          Sessao = item.Sessao
        };
      }
    }

    public IEnumerable<XEscalaPlantao> PegarEscalaPlantao(DateTime pDataReferencia)
    {
      var sql = @"
        WITH CTE_EscalaPlantao AS (

        select * from fn_Escala_Plantao_PorData(getdate()) e
           join Sessao s on s.ID = e.SecaoID
        where s.ID not in (5, 6)
        )

        , CTE_EscalaSobreaviso AS (
        select e.NomeSecao SecaoSobreaviso, e.SecaoID SecaoSobreavisoID from fn_Escala_Sobreaviso_PorData(getdate()) e
           join Sessao s on s.ID = e.SecaoID
        where s.ID in (5, 6)
        )

        select * from CTE_EscalaPlantao, CTE_EscalaSobreaviso        
      ";
      return _db.Database.
         SqlQuery<XEscalaPlantao>(sql,
           new SqlParameter("@pDataReferencia", pDataReferencia)
         );
    }

    public void AlterarSVGOperador(int pOperadorId, bool pSvg)
    {
      var op = _db.OperadorOperacao.FirstOrDefault(x => x.OperadorID == pOperadorId);

      if (op != null)
      {
        op.SVG = pSvg;
        _db.SaveChanges();
      }
    }

    public IEnumerable<XOperadorSelecionado> PegarOperadoresOperacaoResumido(int pOperacaoID)
    {
      var sql = @"
      select 
	      o.Nome, 
	      o.Matricula,
        oo.SVG,
        s.Nome Sessao
      from Operador o
	      join OperadorOperacao oo on oo.OperadorID = o.ID
        join Sessao s on s.ID = o.SessaoID
      where oo.OperacaoID = @pOperacaoID";

      return _db.Database.
         SqlQuery<XOperadorSelecionado>(sql,
           new SqlParameter("@pOperacaoID", pOperacaoID)
         );
    }

    public IEnumerable<XOperadoresSecaoOrdemSVG> PegarOperadoresSecaoOrdemPrioridade (int[] pOperadorIDs, DateTime pDataLimite, DateTime pDataOperacao)
    {
      if (pOperadorIDs == null || pOperadorIDs.Length == 0)
        return Enumerable.Empty<XOperadoresSecaoOrdemSVG>();

      var parametrosOperadores = pOperadorIDs
        .Select((id, index) => new SqlParameter($"@pOperador{index}", id))
        .ToArray();

      var operadoresIn = string.Join(", ",
          parametrosOperadores.Select(p => p.ParameterName));

      /*
       Regras do SVG
      1 Limite de 12h
      2 fantasma
      3 sobreaviso 
      4 plantão - primeira folga
      5 expediente 
      6 plantão que estará entrando
       */

      string sql = $@"

        WITH CTE_Operacao AS (
        select 
	        op.ID,
	        op.TipoOperacaoID
        from Operacao op 
        where op.DataHora >= @pDataLimite
        )

        , CTE_QtdOperacoesOperadores AS (
        select 
	        oo.OperadorID,
			o.SessaoID,
			o.NumericaDOE,
	        COUNT(*) QtdOperacoes,
	        op.TipoOperacaoID,
	        tp.Peso,
	        tp.Nome
        from CTE_Operacao op
	        join OperadorOperacao oo 
		        on oo.OperacaoID = op.ID 
			        and oo.SVG = 1
	        join TipoOperacao tp on tp.ID = op.TipoOperacaoID
          join Operador o on o.ID = oo.OperadorID
	      where oo.OperadorID in ({operadoresIn})
        group by 
	        oo.OperadorID,
			o.NumericaDOE,
	        op.TipoOperacaoID,
	        tp.Peso,
	        tp.Nome,
          o.SessaoID
        )

        , CTE_OperadoresNaoOperou AS (
	        select 
            o.ID as OperadorID,
            o.SessaoID,
			o.NumericaDOE,
	        0 QtdOperacoes, 
	        NULL TipoOperacaoID,
	        10 Peso,
	        '' Nome 
        from Operador o
        left join OperadorOperacao oo 
            on o.ID = oo.OperadorID
            and oo.SVG = 1
        left join Operacao op 
            on op.ID = oo.OperacaoID
            and op.DataHora >= @pDataLimite
        where o.ID in ({operadoresIn})
        group by 
          o.ID,
		  o.NumericaDOE,
          o.SessaoID
        having count(op.ID) = 0
        )

        , CTE_QuantitativoOperacoes AS (
        select *, (QtdOperacoes * 6) QtdHoras from CTE_QtdOperacoesOperadores
        union all
        select *, 0 QtdHoras from CTE_OperadoresNaoOperou
        )

		, CTE_MediaOperadores AS (

			SELECT 
				OperadorID,
				NumericaDOE,
				SUM(QtdOperacoes) QtdOperacoes, 
				SUM(QtdHoras) QtdHoras,
				SessaoID,
				SUM(QtdOperacoes * Peso) AS SomaPonderada,
				SUM(Peso) AS SomaPesos,
				(CEILING(
					(CAST(SUM(QtdOperacoes * Peso) AS FLOAT) / NULLIF(SUM(Peso), 0)) * 100
				) / 100.0) MediaPonderada
		
			FROM CTE_QuantitativoOperacoes c
			GROUP BY 
				OperadorID,
				NumericaDOE,
				SessaoID
		)

        , CTE_SecaoPlantao AS (
	        select 
		        *,
				(CASE
					WHEN Situacao = 0 THEN 'Atual' -- Entrando as 8:00h
					WHEN Situacao = 1 THEN 'Proximo' -- 
					WHEN Situacao = 2 THEN 'Fantasma' -- 
				END) 'SituacaoEquipe',
				(CASE
					WHEN Situacao = 0 THEN 6
					WHEN Situacao = 1 THEN 1
					WHEN Situacao = 2 THEN 5
				END) 'PesoEquipe'

	        from fn_Escala_Plantao_PorData(@pDataOperacao) 
			where SecaoID not in (5, 6)
	        --where Situacao = 1
        )

		, CTE_SituacoesSecoesPlantao AS (
			select 
				s.ID SecaoID, 
				s.Nome,
				COALESCE(sc.SituacaoEquipe, 'PrimeiraFolga') SituacaoEquipe,
				COALESCE(sc.PesoEquipe, 3) PesoEquipe
			from Sessao s 
				left join CTE_SecaoPlantao sc on sc.SecaoID = s.ID
			where s.ID in (1, 2, 3, 4)		
		)

		, CTE_SecaoExpedienteDia AS (
			select *, 2 PesoEquipe from fn_Escala_Sobreaviso_PorData(@pDataOperacao)
		)

		, CTE_SituacaoSecaoExpediente AS (
			select
				s.ID SecaoID, 
				s.Nome,
				(CASE
					WHEN esc.SecaoID is not null THEN 'Sobreaviso'
					WHEN esc.SecaoID is null THEN 'Expediente'
				END) SituacaoEquipe,	
				COALESCE((CASE
					WHEN esc.SecaoID is not null THEN 4
				END), 2) PesoEquipe
			from Sessao s 
				left join fn_Escala_Sobreaviso_PorData(@pDataOperacao) esc on esc.SecaoID = s.ID
			where s.ID in (5, 6, 7)
		),
		
		CTE_SecoesOrdemPrioridade AS (
			select * from CTE_SituacaoSecaoExpediente 
			union all 
			select * from CTE_SituacoesSecoesPlantao
		)
	
		select 
			op.OperadorID,
			op.NumericaDOE,
			op.QtdOperacoes,
			op.QtdHoras,
			op.MediaPonderada EngajamentoOperador,
			sc.Nome Secao,
			sc.SituacaoEquipe,
			COALESCE(PesoEquipe, 0) PesoEquipe,
			CAST(
				ROW_NUMBER() OVER (
				  PARTITION BY SituacaoEquipe
				  ORDER BY QtdHoras ASC, op.MediaPonderada DESC, NumericaDOE 
			  ) AS INT) OrdemNaEquipe
		from CTE_MediaOperadores Op 
			left join CTE_SecoesOrdemPrioridade sc on sc.SecaoID = Op.SessaoID
		order by PesoEquipe desc

      ";

      var parametros = new List<SqlParameter>
      {
        new SqlParameter("@pDataLimite", pDataLimite),
        new SqlParameter("@pDataOperacao", pDataOperacao)
      };
      parametros.AddRange(parametrosOperadores);

      var result = _db.Database.
         SqlQuery<XOperadoresSecaoOrdemSVG>(sql,
           parametros.ToArray()
         ).ToList();

      //// SQL somente para copiar/testar no SSMS
      //var sqlDebug = sql.ToDebugSql(
      //    parametros.ToArray()
      //);


      return result;
    }

    public IEnumerable<int> PegarOperadoresSVG(int[] pOperadorIDs, DateTime pDataLimite, int pQtdVagas)
    {
      if (pOperadorIDs == null || pOperadorIDs.Length == 0)
        return Enumerable.Empty<int>();

      var parametrosOperadores = pOperadorIDs
        .Select((id, index) => new SqlParameter($"@pOperador{index}", id))
        .ToArray();

      var operadoresIn = string.Join(", ",
          parametrosOperadores.Select(p => p.ParameterName));

      string sql = $@"
        WITH CTE_Operacao AS (
        select 
	        op.ID,
	        op.TipoOperacaoID
        from Operacao op 
        where op.DataHora >= @pDataLimite
        )

        , CTE_QtdOperacoesOperadores AS (
        select 
	        oo.OperadorID,
          o.SessaoID,
	        COUNT(*) QtdOperacoes,
	        op.TipoOperacaoID,
	        tp.Peso,
	        tp.Nome
        from CTE_Operacao op
	        join OperadorOperacao oo 
		        on oo.OperacaoID = op.ID 
			        and oo.SVG = 1
	        join TipoOperacao tp on tp.ID = op.TipoOperacaoID
          join Operador o on o.ID = oo.OperadorID
	      where oo.OperadorID in ({operadoresIn})
        group by 
	        oo.OperadorID,
	        op.TipoOperacaoID,
	        tp.Peso,
	        tp.Nome,
          o.SessaoID
        )

        , CTE_OperadoresNaoOperou AS (
	        select 
            o.ID as OperadorID,
            o.SessaoID,
	        0 QtdOperacoes, 
	        NULL TipoOperacaoID,
	        0 Peso,
	        '' Nome 
        from Operador o
        left join OperadorOperacao oo 
            on o.ID = oo.OperadorID
            and oo.SVG = 1
        left join Operacao op 
            on op.ID = oo.OperacaoID
            and op.DataHora >= @pDataLimite
        where o.ID in ({operadoresIn})
        group by 
          o.ID,
          o.SessaoID
        having count(op.ID) = 0
        )

        , CTE_QuantitativoOperacoes AS (
        select * from CTE_QtdOperacoesOperadores
        union all
        select * from CTE_OperadoresNaoOperou
        )

        , SecaoPlantaoProximoDia AS (
	        select 
		        SecaoID 
	        from fn_Escala_Plantao_PorData(@pDataLimite) 
	        where Situacao = 1
        )

        , CTE_MediaOperadores AS (

          SELECT 
              OperadorID,
              SUM(QtdOperacoes * Peso) AS SomaPonderada,
              SUM(Peso) AS SomaPesos,
	          COALESCE(
		          (CASE 
			          WHEN c.SessaoID = s.SecaoID THEN (CEILING(
				          (CAST(SUM(QtdOperacoes * Peso) AS FLOAT) / NULLIF(SUM(Peso), 0)) * 100
			          ) / 100.0) + 10
		          ELSE
			          (CEILING(
				          (CAST(SUM(QtdOperacoes * Peso) AS FLOAT) / NULLIF(SUM(Peso), 0)) * 100
			          ) / 100.0)
		          END)
	          , 0) AS MediaPonderada
          FROM CTE_QuantitativoOperacoes c
	          left join SecaoPlantaoProximoDia s on s.SecaoID = c.SessaoID
          GROUP BY OperadorID, c.SessaoID, s.SecaoID
          )

        , CTE_Resultado AS (
        select OperadorID from CTE_MediaOperadores
        order by MediaPonderada asc
        OFFSET 0 ROWS
        FETCH NEXT @pQtdVagas ROWS ONLY
        )

        select * from CTE_Resultado";

      var parametros = new List<SqlParameter>
      {
        new SqlParameter("@pDataLimite", pDataLimite),
        new SqlParameter("@pQtdVagas", pQtdVagas)
      };
      parametros.AddRange(parametrosOperadores);

      var result = _db.Database.
         SqlQuery<int>(sql,
           parametros.ToArray()
         ).ToList();
      return result;
    }
  }
}
