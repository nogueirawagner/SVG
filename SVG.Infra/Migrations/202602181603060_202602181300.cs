namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202602181300 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
       CREATE OR ALTER VIEW [dbo].[vw_dm_operacao_diario] AS
          SELECT
              dt.Data AS DataSK,
              CONCAT(dt.Dia, '/', dt.MesNome) AS Label,
              COUNT(o.OperacaoID) AS Total
          FROM vw_dm_operacao o
          JOIN DimTempo dt
            ON dt.Data = o.DataSK
          GROUP BY
              dt.Data,
              dt.MesNome,
              dt.Dia;
        ");

      Sql(@"
      CREATE OR ALTER VIEW [dbo].[vw_dm_operacao_mensal] AS
        SELECT
            DATEFROMPARTS(dt.Ano, dt.MesNumero, 1) AS DataSK,
            CONCAT(dt.MesNome, '/', dt.Ano) AS Label,
            COUNT(o.OperacaoID) AS Total
        FROM vw_dm_operacao o
        JOIN DimTempo dt
          ON dt.Data = o.DataSK
        GROUP BY
	        dt.Ano,
	        dt.MesNumero,
	        dt.MesNome;
      ");

      Sql(@"
      CREATE OR ALTER  VIEW [dbo].[vw_dm_participacao_operador_mensal] AS
      SELECT
          DATEFROMPARTS(dt.Ano, dt.MesNumero, 1) AS DataSK,
          CONCAT(dt.MesNome, '/', dt.Ano) AS Label,
          COUNT(*) AS Total
      FROM vw_dm_participacao_operador p
      JOIN DimTempo dt
          ON dt.Data = p.DataSK
      GROUP BY
          dt.MesNumero,
          dt.MesNome,
          dt.Ano;
      ");

      Sql(@"
       CREATE OR ALTER VIEW [dbo].[vw_dm_participacao_operador_diario] AS
          SELECT
              dt.Data AS DataSK,
              CONCAT(dt.Dia, '/', dt.MesNome) AS Label,
              COUNT(*) AS Total
          FROM vw_dm_participacao_operador p
          JOIN DimTempo dt
            ON dt.Data = p.DataSK
          GROUP BY
              dt.Data,
              dt.MesNome,
              dt.Dia;      

      ");
    }

    public override void Down()
    {
    }
  }
}
