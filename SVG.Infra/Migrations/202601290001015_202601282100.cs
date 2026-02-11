namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601282100 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        IF NOT EXISTS (
            SELECT 1
            FROM sys.tables t
            JOIN sys.schemas s ON s.schema_id = t.schema_id
            WHERE t.name = 'DimTempo'
              AND s.name = 'dbo'
        )
        BEGIN
            CREATE TABLE dbo.DimTempo (
                Data                date        NOT NULL PRIMARY KEY,

                Ano                 int         NOT NULL,
                MesNumero           tinyint     NOT NULL,
                MesNome             varchar(3)  NOT NULL,

                Bimestre            tinyint     NOT NULL,
                BimestreNome        varchar(2)  NOT NULL,

                Semestre            tinyint     NOT NULL,
                SemestreNome        varchar(2)  NOT NULL,

                Dia                 tinyint     NOT NULL,
                DiaSemanaNumero     tinyint     NOT NULL,
                DiaSemanaNome       varchar(3)  NOT NULL,

                IsFimDeSemana       bit         NOT NULL
            );
        END;
      ");

      Sql(@"
        SET LANGUAGE Portuguese;
        SET DATEFIRST 7;

        DECLARE @DataInicio date = '2025-01-01';
        DECLARE @DataFim    date = '2055-12-31';

        WITH Datas AS (
            SELECT @DataInicio AS Data
            UNION ALL
            SELECT DATEADD(DAY, 1, Data)
            FROM Datas
            WHERE Data < @DataFim
        )
        IF NOT EXISTS (SELECT 1 FROM DimTempo)
        BEGIN
            INSERT INTO DimTempo
            SELECT
                Data,

                YEAR(Data)  AS Ano,
                MONTH(Data) AS MesNumero,
                LOWER(LEFT(DATENAME(MONTH, Data), 3)) AS MesNome,

                ((MONTH(Data) + 1) / 2) AS Bimestre,
                CONCAT('B', ((MONTH(Data) + 1) / 2)) AS BimestreNome,

                CASE 
                    WHEN MONTH(Data) <= 6 THEN 1
                    ELSE 2
                END AS Semestre,
                CONCAT(
                    'S',
                    CASE 
                        WHEN MONTH(Data) <= 6 THEN 1
                        ELSE 2
                    END
                ) AS SemestreNome,

                DAY(Data) AS Dia,
                DATEPART(WEEKDAY, Data) AS DiaSemanaNumero,
                LOWER(LEFT(DATENAME(WEEKDAY, Data), 3)) AS DiaSemanaNome,

                CASE 
                    WHEN DATEPART(WEEKDAY, Data) IN (1,7) THEN 1
                    ELSE 0
                END AS IsFimDeSemana

            FROM Datas
            OPTION (MAXRECURSION 0);
        END
      ");

      Sql(@"
       IF NOT EXISTS (
            SELECT 1
            FROM sys.tables t
            JOIN sys.schemas s ON s.schema_id = t.schema_id
            WHERE t.name = 'DimTipoOperacao'
              AND s.name = 'dbo'
        )
        BEGIN
            CREATE TABLE dbo.DimTipoOperacao (
                TipoOperacaoSK     int IDENTITY(1,1) PRIMARY KEY,
                TipoOperacaoID     int          NOT NULL,  -- chave natural
                Nome               varchar(200) NOT NULL,
                Peso               int          NULL,
                IsAtivo            bit          NOT NULL 
                    CONSTRAINT DF_DimTipoOperacao_IsAtivo DEFAULT 1
            );
        END;
      ");

      Sql(@"
        INSERT INTO DimTipoOperacao (TipoOperacaoID, Nome, Peso)
        SELECT
            t.ID,
            t.Nome,
            t.Peso
        FROM TipoOperacao t
        WHERE NOT EXISTS (
            SELECT 1
            FROM DimTipoOperacao d
            WHERE d.TipoOperacaoID = t.ID
        );
      ");

      
    }

    public override void Down()
    {
    }
  }
}
