namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202602111155 : DbMigration
  {
    public override void Up()
    {
      // Alterações de views anteriores:

      Sql(@"
      CREATE OR ALTER VIEW [dbo].[vw_dm_adesao_svg_diario] AS
      SELECT
          dt.Data AS DataSK,
          CONCAT(dt.Dia, '/', dt.MesNome) AS Label,
          SUM(p.TotalOperadoresSVG) AS Total
      FROM vw_dm_participacao_svg p
      JOIN DimTempo dt
        ON dt.Data = p.DataSK
      GROUP BY
          dt.Data,
          dt.MesNome,
          dt.Dia;
      ");

      Sql(@"
      CREATE OR ALTER VIEW [dbo].[vw_dm_adesao_svg_mensal] AS
       SELECT
          DATEFROMPARTS(dt.Ano, dt.MesNumero, 1) AS DataSK,
          CONCAT(dt.MesNome, '/', dt.Ano) AS Label,
          SUM(p.TotalOperadoresSVG) AS Total
      FROM vw_dm_participacao_svg p
      JOIN DimTempo dt
          ON dt.Data = p.DataSK
      GROUP BY
          dt.Ano,
          dt.MesNumero,
          dt.MesNome;
      ");

      Sql(@"
      CREATE OR ALTER VIEW [dbo].[vw_dm_adesao_svg_trimestral] AS
      SELECT
          dt_tri.Data AS DataSK,
          CONCAT('T', ((dt_m.MesNumero - 1) / 3) + 1, '/', dt_tri.Ano) AS Label,
          SUM(p.TotalOperadoresSVG) AS Total
      FROM vw_dm_participacao_svg p
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
      CREATE OR ALTER VIEW [dbo].[vw_dm_adesao_svg_bimestral] AS
      SELECT
          dt_bi.Data AS DataSK,
          CONCAT('B', dt_bi.Bimestre, '/', dt_bi.Ano) AS Label,
          SUM(p.TotalOperadoresSVG) AS Total
      FROM vw_dm_participacao_svg p
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
      CREATE OR ALTER VIEW [dbo].[vw_dm_adesao_svg_semestral] AS
      SELECT
          dt_sem.Data AS DataSK,
          CONCAT('S', dt_sem.Semestre, '/', dt_sem.Ano) AS Label,
          SUM(p.TotalOperadoresSVG) AS Total
      FROM vw_dm_participacao_svg p
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

      Sql(@"
      CREATE OR ALTER VIEW [dbo].[vw_dm_operacao_mensal] AS
      SELECT
          dt.Data AS DataSK,
          CONCAT(dt.MesNome, '/', dt.Ano) AS Label,
          COUNT(o.OperacaoID) AS Total
      FROM vw_dm_operacao o
      JOIN DimTempo dt
        ON dt.Data = o.DataSK
      GROUP BY
          dt.Data,
          dt.MesNome,
          dt.Ano;
      ");

      Sql(@"
      CREATE OR ALTER VIEW [dbo].[vw_dm_operacao_bimestral] AS
      SELECT
          dt_bi.Data AS DataSK,
          CONCAT('B', dt_bi.Bimestre, '/', dt_bi.Ano) AS Label,
          COUNT(o.OperacaoID) AS Total
      FROM vw_dm_operacao o
      JOIN DimTempo dt_m
        ON dt_m.Data = o.DataSK
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
      CREATE OR ALTER VIEW [dbo].[vw_dm_operacao_trimestral] AS
      SELECT
          dt_tri.Data AS DataSK,
          CONCAT('T', ((dt_m.MesNumero - 1) / 3) + 1, '/', dt_tri.Ano) AS Label,
          COUNT(o.OperacaoID) AS Total
      FROM vw_dm_operacao o
      JOIN DimTempo dt_m
        ON dt_m.Data = o.DataSK
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
      CREATE OR ALTER VIEW [dbo].[vw_dm_operacao_semestral] AS
      SELECT
          dt_sem.Data AS DataSK,
          CONCAT('S', dt_sem.Semestre, '/', dt_sem.Ano) AS Label,
          COUNT(o.OperacaoID) AS Total
      FROM vw_dm_operacao o
      JOIN DimTempo dt_m
        ON dt_m.Data = o.DataSK
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

      // Novas

      Sql(@"

        IF NOT EXISTS (
            SELECT 1
            FROM sys.tables t
            JOIN sys.schemas s ON s.schema_id = t.schema_id
            WHERE t.name = 'DimOperador'
              AND s.name = 'dbo'
        )
        BEGIN
            CREATE TABLE dbo.DimOperador (
                OperadorSK  int IDENTITY(1,1) PRIMARY KEY,
                OperadorID  int           NOT NULL,   -- chave natural
                Matricula   varchar(20)   NOT NULL,
                Nome        varchar(200)  NOT NULL,
                SessaoID    int           NOT NULL,
                SessaoNome  varchar(200)  NOT NULL
            );
        END;
      ");

      Sql(@"
        IF NOT EXISTS (
            SELECT 1
            FROM sys.indexes
            WHERE name = 'UX_DimOperador_OperadorID'
        )
        BEGIN
            CREATE UNIQUE INDEX UX_DimOperador_OperadorID
                ON dbo.DimOperador (OperadorID);
        END;
      ");

      Sql(@"
        INSERT INTO dbo.DimOperador (OperadorID, Matricula, Nome, SessaoID, SessaoNome)
        SELECT
            o.ID        AS OperadorID,
            o.Matricula,
            o.Nome,
            s.ID        AS SessaoID,
            s.Nome      AS SessaoNome
        FROM Operador o
        JOIN Sessao s ON s.ID = o.SessaoID
        WHERE NOT EXISTS (
            SELECT 1
            FROM dbo.DimOperador d
            WHERE d.OperadorID = o.ID
        );
      ");

      Sql(@"
        CREATE OR ALTER VIEW [dbo].[vw_dm_participacao_operador] AS
        SELECT
            o.ID            AS OperacaoID,

            -- 🔑 Chaves substitutas
            dt.Data         AS DataSK,
            dop.OperadorSK,
            dop.OperadorID,
            dop.Matricula,
            dop.Nome        AS OperadorNome,
            dop.SessaoID,
            dop.SessaoNome,

            -- Fato
            oo.SVG
        FROM Operacao o
        JOIN OperadorOperacao oo
            ON oo.OperacaoID = o.ID
        JOIN DimTempo dt
            ON dt.Data = CAST(o.DataHora AS date)
        JOIN DimOperador dop
            ON dop.OperadorID = oo.OperadorID;
      ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_top_operadores AS
        SELECT TOP 10
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome AS Operador,
            p.SessaoID,
            p.SessaoNome   AS Sessao,
            COUNT(*)       AS TotalParticipacoes
        FROM vw_dm_participacao_operador p
        GROUP BY
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome,
            p.SessaoID,
            p.SessaoNome
        ORDER BY
            COUNT(*) DESC;
        ");


      Sql(@"
        CREATE OR ALTER VIEW vw_dm_top_operadores_mensal AS
        SELECT TOP 10
            dt_m.Data        AS DataSK,
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome   AS Operador,
            p.SessaoID,
            p.SessaoNome     AS Sessao,
            COUNT(*)         AS TotalParticipacoes
        FROM vw_dm_participacao_operador p
        JOIN DimTempo dt_m
          ON dt_m.Data = p.DataSK
        GROUP BY
            dt_m.Data,
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome,
            p.SessaoID,
            p.SessaoNome
        ORDER BY
            COUNT(*) DESC;
        ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_top_operadores_bimestral AS
        SELECT TOP 10
            dt_bi.Data        AS DataSK,
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome    AS Operador,
            p.SessaoID,
            p.SessaoNome      AS Sessao,
            COUNT(*)          AS TotalParticipacoes
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
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome,
            p.SessaoID,
            p.SessaoNome
        ORDER BY
            COUNT(*) DESC;
        ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_top_operadores_trimestral AS
        SELECT TOP 10
            dt_tri.Data       AS DataSK,
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome    AS Operador,
            p.SessaoID,
            p.SessaoNome      AS Sessao,
            COUNT(*)          AS TotalParticipacoes
        FROM vw_dm_participacao_operador p
        JOIN DimTempo dt_m
          ON dt_m.Data = p.DataSK
        JOIN DimTempo dt_tri
          ON dt_tri.Ano = dt_m.Ano
         AND dt_tri.MesNumero = ((dt_m.MesNumero - 1) / 3) * 3 + 1
         AND dt_tri.Dia = 1
        GROUP BY
            dt_tri.Data,
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome,
            p.SessaoID,
            p.SessaoNome
        ORDER BY
            COUNT(*) DESC;
        ");

      Sql(@"
        CREATE OR ALTER VIEW vw_dm_top_operadores_semestral AS
        SELECT TOP 10
            dt_sem.Data       AS DataSK,
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome    AS Operador,
            p.SessaoID,
            p.SessaoNome      AS Sessao,
            COUNT(*)          AS TotalParticipacoes
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
            p.OperadorSK,
            p.OperadorID,
            p.Matricula,
            p.OperadorNome,
            p.SessaoID,
            p.SessaoNome
        ORDER BY
            COUNT(*) DESC;
        ");
    }

    public override void Down()
    {
    }
  }
}
