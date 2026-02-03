namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601282240 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
      CREATE OR ALTER VIEW [dbo].[vw_dm_operacao] AS
      SELECT
          o.ID       AS OperacaoID,
          dt.Data    AS DataSK,
          o.DataHora,
          -- Dimensão Tempo (desnormalizada, se quiser manter)
          dt.Ano,
          dt.MesNumero,
          dt.MesNome,
          dt.Bimestre,
          dt.BimestreNome,
          dt.Semestre,
          dt.SemestreNome,
          dt.DiaSemanaNome,
          dt.IsFimDeSemana,

          -- Dimensão Operação
          t.Nome AS TipoOperacao

      FROM Operacao o
      JOIN DimTempo dt
        ON dt.Data = CAST(o.DataHora AS date)
      JOIN TipoOperacao t
        ON t.ID = o.TipoOperacaoID;

      ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_participacao_svg AS
          SELECT
              o.ID AS OperacaoID,

              -- SKs
              dt.Data            AS DataSK,
              dto.TipoOperacaoSK,

              -- Métricas
              COUNT(oo.OperadorID) AS TotalOperadores,
              SUM(CASE WHEN oo.SVG = 1 THEN 1 ELSE 0 END) AS TotalOperadoresSVG

          FROM Operacao o
          JOIN OperadorOperacao oo
            ON oo.OperacaoID = o.ID
          JOIN DimTempo dt
            ON dt.Data = CAST(o.DataHora AS date)
          JOIN DimTipoOperacao dto
            ON dto.TipoOperacaoID = o.TipoOperacaoID

          GROUP BY
              o.ID,
              dt.Data,
              dto.TipoOperacaoSK;

      ");

      Sql(@"
        CREATE OR ALTER VIEW [dbo].[vw_dm_adesao_svg_mensal] AS
        SELECT
            dt.Data AS DataSK,

            dt.Ano,
            dt.MesNumero,
            dt.MesNome,

            dt.Bimestre,
            dt.BimestreNome,
            dt.Semestre,
            dt.SemestreNome,

            COUNT(DISTINCT p.OperacaoID) AS TotalOperacoes,

            SUM(p.TotalOperadores)    AS TotalOperadoresMes,
            SUM(p.TotalOperadoresSVG) AS TotalOperadoresSVGMes,

            CAST(AVG(CAST(p.TotalOperadores AS float)) AS decimal(10,2))
                AS MediaOperadoresPorOperacao,

            CAST(AVG(CAST(p.TotalOperadoresSVG AS float)) AS decimal(10,2))
                AS MediaSVGPorOperacao

        FROM vw_dm_participacao_svg p
        JOIN DimTempo dt
          ON dt.Data = p.DataSK   

        GROUP BY
            dt.Data,
            dt.Ano,
            dt.MesNumero,
            dt.MesNome,
            dt.Bimestre,
            dt.BimestreNome,
            dt.Semestre,
            dt.SemestreNome;
      ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_adesao_svg_bimestral AS
        SELECT
            dt_bi.Data AS DataSK,

            dt_bi.Ano,
            dt_bi.Bimestre,
            dt_bi.BimestreNome,

            SUM(m.TotalOperacoes)        AS TotalOperacoes,
            SUM(m.TotalOperadoresMes)    AS TotalOperadores,
            SUM(m.TotalOperadoresSVGMes) AS TotalOperadoresSVG,

            CAST(AVG(m.MediaOperadoresPorOperacao) AS decimal(10,2))
                AS MediaOperadoresPorOperacao,

            CAST(AVG(m.MediaSVGPorOperacao) AS decimal(10,2))
                AS MediaSVGPorOperacao

        FROM vw_dm_adesao_svg_mensal m
        JOIN DimTempo dt_m
          ON dt_m.Data = m.DataSK
        JOIN DimTempo dt_bi
          ON dt_bi.Ano = dt_m.Ano
         AND dt_bi.Bimestre = dt_m.Bimestre
         AND dt_bi.Dia = 1
         AND dt_bi.MesNumero IN (1,3,5,7,9,11)

        GROUP BY
            dt_bi.Data,
            dt_bi.Ano,
            dt_bi.Bimestre,
            dt_bi.BimestreNome;

        ");

      Sql(@"
       CREATE OR ALTER VIEW vw_dm_adesao_svg_trimestral AS
      SELECT
          dt_tri.Data AS DataSK,

          dt_tri.Ano,
          ((dt_m.MesNumero - 1) / 3) + 1 AS Trimestre,
          CONCAT('T', ((dt_m.MesNumero - 1) / 3) + 1) AS TrimestreNome,

          SUM(m.TotalOperacoes)        AS TotalOperacoes,
          SUM(m.TotalOperadoresMes)    AS TotalOperadores,
          SUM(m.TotalOperadoresSVGMes) AS TotalOperadoresSVG,

          CAST(AVG(m.MediaOperadoresPorOperacao) AS decimal(10,2))
              AS MediaOperadoresPorOperacao,

          CAST(AVG(m.MediaSVGPorOperacao) AS decimal(10,2))
              AS MediaSVGPorOperacao

      FROM vw_dm_adesao_svg_mensal m
      JOIN DimTempo dt_m
        ON dt_m.Data = m.DataSK
      JOIN DimTempo dt_tri
        ON dt_tri.Ano = dt_m.Ano
        AND dt_tri.MesNumero = ((dt_m.MesNumero - 1) / 3) * 3 + 1
        AND dt_tri.Dia = 1

      GROUP BY
          dt_tri.Data,
          dt_tri.Ano,
          ((dt_m.MesNumero - 1) / 3) + 1;

      ");

      Sql(@"
      CREATE OR ALTER VIEW vw_dm_adesao_svg_semestral AS
      SELECT
          dt_sem.Data AS DataSK,

          dt_sem.Ano,
          dt_sem.Semestre,
          dt_sem.SemestreNome,

          SUM(m.TotalOperacoes)        AS TotalOperacoes,
          SUM(m.TotalOperadoresMes)    AS TotalOperadores,
          SUM(m.TotalOperadoresSVGMes) AS TotalOperadoresSVG,

          CAST(AVG(m.MediaOperadoresPorOperacao) AS decimal(10,2))
              AS MediaOperadoresPorOperacao,

          CAST(AVG(m.MediaSVGPorOperacao) AS decimal(10,2))
              AS MediaSVGPorOperacao

      FROM vw_dm_adesao_svg_mensal m
      JOIN DimTempo dt_m
        ON dt_m.Data = m.DataSK
      JOIN DimTempo dt_sem
        ON dt_sem.Ano = dt_m.Ano
        AND dt_sem.Semestre = dt_m.Semestre
        AND dt_sem.Dia = 1
        AND dt_sem.MesNumero IN (1,7)

      GROUP BY
          dt_sem.Data,
          dt_sem.Ano,
          dt_sem.Semestre,
          dt_sem.SemestreNome;

      ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_operacao_mensal AS
        SELECT
            dt.Data AS DataSK,
            COUNT(o.OperacaoID) AS TotalOperacoes
        FROM vw_dm_operacao o
        JOIN DimTempo dt
          ON dt.Data = o.DataSK
        GROUP BY
            dt.Data;
      ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_operacao_bimestral AS
          SELECT
              dt_bi.Data AS DataSK,
              COUNT(o.OperacaoID) AS TotalOperacoes
          FROM vw_dm_operacao o
          JOIN DimTempo dt_m
            ON dt_m.Data = o.DataSK
          JOIN DimTempo dt_bi
            ON dt_bi.Ano = dt_m.Ano
           AND dt_bi.Bimestre = dt_m.Bimestre
           AND dt_bi.Dia = 1
           AND dt_bi.MesNumero IN (1,3,5,7,9,11)
          GROUP BY
              dt_bi.Data;

      ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_operacao_trimestral AS
        SELECT
            dt_tri.Data AS DataSK,
            COUNT(o.OperacaoID) AS TotalOperacoes
        FROM vw_dm_operacao o
        JOIN DimTempo dt_m
          ON dt_m.Data = o.DataSK
        JOIN DimTempo dt_tri
          ON dt_tri.Ano = dt_m.Ano
         AND dt_tri.MesNumero = ((dt_m.MesNumero - 1) / 3) * 3 + 1
         AND dt_tri.Dia = 1
        GROUP BY
            dt_tri.Data;
      ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_operacao_semestral AS
        SELECT
            dt_sem.Data AS DataSK,
            COUNT(o.OperacaoID) AS TotalOperacoes
        FROM vw_dm_operacao o
        JOIN DimTempo dt_m
          ON dt_m.Data = o.DataSK
        JOIN DimTempo dt_sem
          ON dt_sem.Ano = dt_m.Ano
         AND dt_sem.Semestre = dt_m.Semestre
         AND dt_sem.Dia = 1
         AND dt_sem.MesNumero IN (1,7)
        GROUP BY
            dt_sem.Data;
      ");


      Sql(@"
       CREATE OR ALTER VIEW [dbo].[vw_dm_participacao_operador_mensal] AS
        SELECT
            dt.Data AS DataSK,
            CONCAT(dt.MesNome, '/', dt.Ano) AS Label,
            COUNT(*) AS Total
        FROM vw_dm_participacao_operador p
        JOIN DimTempo dt
          ON dt.Data = p.DataSK
        GROUP BY
            dt.Data,
            dt.MesNome,
            dt.Ano;

      ");

      Sql(@"
       CREATE OR ALTER VIEW [dbo].[vw_dm_participacao_operador_bimestral] AS
        SELECT
            dt_bi.Data AS DataSK,
            CONCAT('B', dt_bi.Bimestre, '/', dt_bi.Ano) AS Label,
            COUNT(*) AS Total
        FROM vw_dm_participacao_operador p
        JOIN DimTempo dt_m
          ON dt_m.Data = p.DataSK
        JOIN DimTempo dt_bi
          ON dt_bi.Ano = dt_m.Ano
         AND dt_bi.Bimestre = dt_m.Bimestre
         AND dt_bi.Dia = 1
         AND dt_bi.MesNumero IN (1,3,5,7,9,11)
        GROUP BY
            dt_bi.Data,
            dt_bi.Bimestre,
            dt_bi.Ano;

      ");

      Sql(@"
      CREATE OR ALTER VIEW [dbo].[vw_dm_participacao_operador_trimestral] AS
        SELECT
            dt_tri.Data AS DataSK,
            CONCAT('T', ((dt_m.MesNumero - 1) / 3) + 1, '/', dt_tri.Ano) AS Label,
            COUNT(*) AS Total
        FROM vw_dm_participacao_operador p
        JOIN DimTempo dt_m
          ON dt_m.Data = p.DataSK
        JOIN DimTempo dt_tri
          ON dt_tri.Ano = dt_m.Ano
         AND dt_tri.MesNumero = ((dt_m.MesNumero - 1) / 3) * 3 + 1
         AND dt_tri.Dia = 1
        GROUP BY
            dt_tri.Data,
            dt_tri.Ano,
            dt_m.MesNumero;


      ");

      Sql(@"
      CREATE OR ALTER VIEW [dbo].[vw_dm_participacao_operador_semestral] AS
      SELECT
          dt_sem.Data AS DataSK,
          CONCAT('S', dt_sem.Semestre, '/', dt_sem.Ano) AS Label,
          COUNT(*) AS Total
      FROM vw_dm_participacao_operador p
      JOIN DimTempo dt_m
        ON dt_m.Data = p.DataSK
      JOIN DimTempo dt_sem
        ON dt_sem.Ano = dt_m.Ano
       AND dt_sem.Semestre = dt_m.Semestre
       AND dt_sem.Dia = 1
       AND dt_sem.MesNumero IN (1,7)
      GROUP BY
          dt_sem.Data,
          dt_sem.Semestre,
          dt_sem.Ano;

      ");
    }

    public override void Down()
    {
    }
  }
}
