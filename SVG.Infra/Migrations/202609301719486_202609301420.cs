namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202609301420 : DbMigration
  {
    public override void Up()
    {
      // Janeiro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 01/2026
-- Fonte: JAN 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 80
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Edson Medina de Oliveira | GAB | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            130,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vieira de Sousa | GAB | Recesso Fim de Ano | 01/01/2026 a 01/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 133
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260101'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            133,
            14,
            '20260101',
            '20260101',
            NULL,
            GETDATE()
        );
    END;

    -- Maiquel A. Cavalcante Mendes | SI | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 136
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            136,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Silvestre Milhomem Amaral | SI | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 137
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            137,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            139,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            142,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            143,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            144,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Licença para tratamento de saúde própria | 01/01/2026 a 31/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 8
          AND DataInicio = '20260101'
          AND DataFim = '20260131'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            8,
            '20260101',
            '20260131',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Licença para tratamento de saúde própria | 01/01/2026 a 03/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 8
          AND DataInicio = '20260101'
          AND DataFim = '20260103'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            149,
            8,
            '20260101',
            '20260103',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            155,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Pericles M. de Rezende Junior | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 156
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            156,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            157,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Nunes | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 158
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            158,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Cinthia Versiani Pontes | SOC | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 163
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            163,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            166,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Vinicius Gomes dos Santos Fontes | SOC | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 167
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            167,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Renato Bizinoto Molas | SOE I | Férias | 01/01/2026 a 12/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 170
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            170,
            1,
            '20260101',
            '20260112',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Férias | 01/01/2026 a 08/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260108'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            180,
            1,
            '20260101',
            '20260108',
            NULL,
            GETDATE()
        );
    END;

    -- Thallys Mendes Passos | SOE II | Férias | 01/01/2026 a 05/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 182
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260105'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            182,
            1,
            '20260101',
            '20260105',
            NULL,
            GETDATE()
        );
    END;

    -- Vanderlei Ferreira Dutra | SOE II | Férias | 01/01/2026 a 01/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 184
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260101'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            184,
            1,
            '20260101',
            '20260101',
            NULL,
            GETDATE()
        );
    END;

    -- Alberto Ganzaroli Neto | SOE II | Licença para tratamento de saúde própria | 01/01/2026 a 01/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 8
          AND DataInicio = '20260101'
          AND DataFim = '20260101'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            185,
            8,
            '20260101',
            '20260101',
            NULL,
            GETDATE()
        );
    END;

    -- Sidney da Silva de Oliveira | SOE II | Férias | 01/01/2026 a 29/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 188
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260129'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            188,
            1,
            '20260101',
            '20260129',
            NULL,
            GETDATE()
        );
    END;

    -- Luiz Cesar Mendes de Almeida | SOE III | Férias | 01/01/2026 a 22/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 189
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260122'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            189,
            1,
            '20260101',
            '20260122',
            NULL,
            GETDATE()
        );
    END;

    -- Franthiesco L. Fernandes Nunes | SOE III | Férias | 01/01/2026 a 14/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 194
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260114'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            194,
            1,
            '20260101',
            '20260114',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Licença para tratamento de saúde própria | 01/01/2026 a 08/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 195
          AND TipoAfastamento = 8
          AND DataInicio = '20260101'
          AND DataFim = '20260108'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            195,
            8,
            '20260101',
            '20260108',
            NULL,
            GETDATE()
        );
    END;

    -- Gabriel Arana da Silva | SOE III | Férias | 01/01/2026 a 22/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 196
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260122'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            196,
            1,
            '20260101',
            '20260122',
            NULL,
            GETDATE()
        );
    END;

    -- Wanderson Gomes dos Santos | SOE III | Férias | 01/01/2026 a 22/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 197
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260122'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            197,
            1,
            '20260101',
            '20260122',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Lebrão Arruda | SOE IV | Férias | 01/01/2026 a 11/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 201
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260111'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            201,
            1,
            '20260101',
            '20260111',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Férias | 01/01/2026 a 26/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 1
          AND DataInicio = '20260101'
          AND DataFim = '20260126'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            212,
            1,
            '20260101',
            '20260126',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Licença para tratamento de saúde própria | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 8
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            216,
            8,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Patricia Araujo Ribeiro | SAAEI | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 222
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            222,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Rebeca Severo Limongi | SAAEI | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 223
          AND TipoAfastamento = 14
          AND DataInicio = '20260101'
          AND DataFim = '20260102'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            223,
            14,
            '20260101',
            '20260102',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vieira de Sousa | GAB | Licença para tratamento de saúde própria | 02/01/2026 a 31/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 133
          AND TipoAfastamento = 8
          AND DataInicio = '20260102'
          AND DataFim = '20260131'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            133,
            8,
            '20260102',
            '20260131',
            NULL,
            GETDATE()
        );
    END;

    -- Eduardo Cosme Carvalho da Silva | SOE I | Férias | 03/01/2026 a 12/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 174
          AND TipoAfastamento = 1
          AND DataInicio = '20260103'
          AND DataFim = '20260112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            174,
            1,
            '20260103',
            '20260112',
            NULL,
            GETDATE()
        );
    END;

    -- Edson Medina de Oliveira | GAB | Férias | 05/01/2026 a 11/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 1
          AND DataInicio = '20260105'
          AND DataFim = '20260111'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            130,
            1,
            '20260105',
            '20260111',
            NULL,
            GETDATE()
        );
    END;

    -- Silvestre Milhomem Amaral | SI | Férias | 05/01/2026 a 14/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 137
          AND TipoAfastamento = 1
          AND DataInicio = '20260105'
          AND DataFim = '20260114'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            137,
            1,
            '20260105',
            '20260114',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 05/01/2026 a 05/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 1
          AND DataInicio = '20260105'
          AND DataFim = '20260105'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            1,
            '20260105',
            '20260105',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 05/01/2026 a 14/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20260105'
          AND DataFim = '20260114'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            142,
            1,
            '20260105',
            '20260114',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Abono de ponto anual | 05/01/2026 a 09/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 2
          AND DataInicio = '20260105'
          AND DataFim = '20260109'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            144,
            2,
            '20260105',
            '20260109',
            NULL,
            GETDATE()
        );
    END;

    -- Cinthia Versiani Pontes | SOC | Férias | 05/01/2026 a 14/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 163
          AND TipoAfastamento = 1
          AND DataInicio = '20260105'
          AND DataFim = '20260114'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            163,
            1,
            '20260105',
            '20260114',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 05/01/2026 a 14/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 1
          AND DataInicio = '20260105'
          AND DataFim = '20260114'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            1,
            '20260105',
            '20260114',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Roberto Valente Caetano | SOE IV | Licença para tratamento de saúde própria | 07/01/2026 a 11/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 206
          AND TipoAfastamento = 8
          AND DataInicio = '20260107'
          AND DataFim = '20260111'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            206,
            8,
            '20260107',
            '20260111',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 08/01/2026 a 17/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 1
          AND DataInicio = '20260108'
          AND DataFim = '20260117'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            157,
            1,
            '20260108',
            '20260117',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Nunes | SOT | Férias | 08/01/2026 a 17/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 158
          AND TipoAfastamento = 1
          AND DataInicio = '20260108'
          AND DataFim = '20260117'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            158,
            1,
            '20260108',
            '20260117',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 10/01/2026 a 13/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 198
          AND TipoAfastamento = 1
          AND DataInicio = '20260110'
          AND DataFim = '20260113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            198,
            1,
            '20260110',
            '20260113',
            NULL,
            GETDATE()
        );
    END;

    -- Diego Madureira Rodrigues | SOE I | Férias | 11/01/2026 a 30/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 171
          AND TipoAfastamento = 1
          AND DataInicio = '20260111'
          AND DataFim = '20260130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            171,
            1,
            '20260111',
            '20260130',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 12/01/2026 a 20/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 1
          AND DataInicio = '20260112'
          AND DataFim = '20260120'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            1,
            '20260112',
            '20260120',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Licença para tratamento de saúde própria | 12/01/2026 a 16/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 8
          AND DataInicio = '20260112'
          AND DataFim = '20260116'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            146,
            8,
            '20260112',
            '20260116',
            NULL,
            GETDATE()
        );
    END;

    -- Juliano Dantas Bueno | SOT | Férias | 12/01/2026 a 21/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 154
          AND TipoAfastamento = 1
          AND DataInicio = '20260112'
          AND DataFim = '20260121'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            154,
            1,
            '20260112',
            '20260121',
            NULL,
            GETDATE()
        );
    END;

    -- Aurelio Gleria Cavalcante | SOC | Abono de ponto anual | 13/01/2026 a 13/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 169
          AND TipoAfastamento = 2
          AND DataInicio = '20260113'
          AND DataFim = '20260113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            169,
            2,
            '20260113',
            '20260113',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Roberto Valente Caetano | SOE IV | Férias | 14/01/2026 a 23/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 206
          AND TipoAfastamento = 1
          AND DataInicio = '20260114'
          AND DataFim = '20260123'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            206,
            1,
            '20260114',
            '20260123',
            NULL,
            GETDATE()
        );
    END;

    -- Sanlac Machado da Cunha | SOC | Férias | 15/01/2026 a 24/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 162
          AND TipoAfastamento = 1
          AND DataInicio = '20260115'
          AND DataFim = '20260124'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            162,
            1,
            '20260115',
            '20260124',
            NULL,
            GETDATE()
        );
    END;

    -- Cinthia Versiani Pontes | SOC | Abono de ponto anual | 15/01/2026 a 16/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 163
          AND TipoAfastamento = 2
          AND DataInicio = '20260115'
          AND DataFim = '20260116'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            163,
            2,
            '20260115',
            '20260116',
            NULL,
            GETDATE()
        );
    END;

    -- Aurelio Gleria Cavalcante | SOC | Férias | 15/01/2026 a 29/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 169
          AND TipoAfastamento = 1
          AND DataInicio = '20260115'
          AND DataFim = '20260129'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            169,
            1,
            '20260115',
            '20260129',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Thomas | SOE I | Férias | 15/01/2026 a 24/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 173
          AND TipoAfastamento = 1
          AND DataInicio = '20260115'
          AND DataFim = '20260124'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            173,
            1,
            '20260115',
            '20260124',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Férias | 17/01/2026 a 26/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 1
          AND DataInicio = '20260117'
          AND DataFim = '20260126'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            191,
            1,
            '20260117',
            '20260126',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Férias | 18/01/2026 a 27/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 1
          AND DataInicio = '20260118'
          AND DataFim = '20260127'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            1,
            '20260118',
            '20260127',
            NULL,
            GETDATE()
        );
    END;

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 19/01/2026 a 28/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 131
          AND TipoAfastamento = 1
          AND DataInicio = '20260119'
          AND DataFim = '20260128'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            131,
            1,
            '20260119',
            '20260128',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 19/01/2026 a 28/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 1
          AND DataInicio = '20260119'
          AND DataFim = '20260128'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            139,
            1,
            '20260119',
            '20260128',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 19/01/2026 a 28/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 1
          AND DataInicio = '20260119'
          AND DataFim = '20260128'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            1,
            '20260119',
            '20260128',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Pereira de Jesus | SOE II | Férias | 20/01/2026 a 29/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 186
          AND TipoAfastamento = 1
          AND DataInicio = '20260120'
          AND DataFim = '20260129'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            186,
            1,
            '20260120',
            '20260129',
            NULL,
            GETDATE()
        );
    END;

    -- Frank Rodrigues Ferreira | SOT | Férias | 21/01/2026 a 21/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 160
          AND TipoAfastamento = 1
          AND DataInicio = '20260121'
          AND DataFim = '20260121'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            160,
            1,
            '20260121',
            '20260121',
            NULL,
            GETDATE()
        );
    END;

    -- Leandro de Oliveira Sampaio | GAB | Férias | 22/01/2026 a 31/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 1
          AND DataInicio = '20260122'
          AND DataFim = '20260131'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            132,
            1,
            '20260122',
            '20260131',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Férias | 22/01/2026 a 22/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 1
          AND DataInicio = '20260122'
          AND DataFim = '20260122'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            143,
            1,
            '20260122',
            '20260122',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Licença para tratamento de saúde própria | 22/01/2026 a 26/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 8
          AND DataInicio = '20260122'
          AND DataFim = '20260126'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            199,
            8,
            '20260122',
            '20260126',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Férias | 25/01/2026 a 31/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 1
          AND DataInicio = '20260125'
          AND DataFim = '20260131'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            190,
            1,
            '20260125',
            '20260131',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Férias | 26/01/2026 a 31/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20260126'
          AND DataFim = '20260131'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            1,
            '20260126',
            '20260131',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Roberto Valente Caetano | SOE IV | Abono de ponto anual | 26/01/2026 a 30/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 206
          AND TipoAfastamento = 2
          AND DataInicio = '20260126'
          AND DataFim = '20260130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            206,
            2,
            '20260126',
            '20260130',
            NULL,
            GETDATE()
        );
    END;

    -- Josué Carvalho da Costa | SOE I | Férias | 27/01/2026 a 30/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20260127'
          AND DataFim = '20260130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            177,
            1,
            '20260127',
            '20260130',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Férias | 28/01/2026 a 31/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 1
          AND DataInicio = '20260128'
          AND DataFim = '20260131'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            135,
            1,
            '20260128',
            '20260131',
            NULL,
            GETDATE()
        );
    END;

    -- Honney Cordeiro | SOE II | Férias | 28/01/2026 a 31/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 181
          AND TipoAfastamento = 1
          AND DataInicio = '20260128'
          AND DataFim = '20260131'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            181,
            1,
            '20260128',
            '20260131',
            NULL,
            GETDATE()
        );
    END;

    -- Tilia Rumi Okahara | SAAEI | Abono de ponto anual | 28/01/2026 a 30/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 221
          AND TipoAfastamento = 2
          AND DataInicio = '20260128'
          AND DataFim = '20260130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            221,
            2,
            '20260128',
            '20260130',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 29/01/2026 a 29/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20260129'
          AND DataFim = '20260129'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            1,
            '20260129',
            '20260129',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 31/01/2026 a 31/01/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20260131'
          AND DataFim = '20260131'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            179,
            1,
            '20260131',
            '20260131',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Fevereiro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 02/2026
-- Fonte: FEV 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 30
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Marcelo Vieira de Sousa | GAB | Licença para tratamento de saúde própria | 01/02/2026 a 28/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 133
          AND TipoAfastamento = 8
          AND DataInicio = '20260201'
          AND DataFim = '20260228'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            133,
            8,
            '20260201',
            '20260228',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Férias | 01/02/2026 a 06/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 1
          AND DataInicio = '20260201'
          AND DataFim = '20260206'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            135,
            1,
            '20260201',
            '20260206',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Licença para tratamento de saúde própria | 01/02/2026 a 28/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 8
          AND DataInicio = '20260201'
          AND DataFim = '20260228'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            8,
            '20260201',
            '20260228',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Férias | 01/02/2026 a 04/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20260201'
          AND DataFim = '20260204'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            1,
            '20260201',
            '20260204',
            NULL,
            GETDATE()
        );
    END;

    -- Josué Carvalho da Costa | SOE I | Férias | 01/02/2026 a 05/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20260201'
          AND DataFim = '20260205'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            177,
            1,
            '20260201',
            '20260205',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 01/02/2026 a 03/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20260201'
          AND DataFim = '20260203'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            179,
            1,
            '20260201',
            '20260203',
            NULL,
            GETDATE()
        );
    END;

    -- Honney Cordeiro | SOE II | Férias | 01/02/2026 a 16/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 181
          AND TipoAfastamento = 1
          AND DataInicio = '20260201'
          AND DataFim = '20260216'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            181,
            1,
            '20260201',
            '20260216',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Férias | 01/02/2026 a 03/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 1
          AND DataInicio = '20260201'
          AND DataFim = '20260203'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            190,
            1,
            '20260201',
            '20260203',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 02/02/2026 a 02/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 1
          AND DataInicio = '20260202'
          AND DataFim = '20260202'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            1,
            '20260202',
            '20260202',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Férias | 02/02/2026 a 11/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 1
          AND DataInicio = '20260202'
          AND DataFim = '20260211'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            149,
            1,
            '20260202',
            '20260211',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Licença para tratamento de saúde própria | 02/02/2026 a 28/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 8
          AND DataInicio = '20260202'
          AND DataFim = '20260228'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            8,
            '20260202',
            '20260228',
            NULL,
            GETDATE()
        );
    END;

    -- Tilia Rumi Okahara | SAAEI | Abono de ponto anual | 02/02/2026 a 03/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 221
          AND TipoAfastamento = 2
          AND DataInicio = '20260202'
          AND DataFim = '20260203'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            221,
            2,
            '20260202',
            '20260203',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Lima Aguirra | SOE IV | Férias | 03/02/2026 a 12/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 202
          AND TipoAfastamento = 1
          AND DataInicio = '20260203'
          AND DataFim = '20260212'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            202,
            1,
            '20260203',
            '20260212',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 04/02/2026 a 13/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 1
          AND DataInicio = '20260204'
          AND DataFim = '20260213'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            166,
            1,
            '20260204',
            '20260213',
            NULL,
            GETDATE()
        );
    END;

    -- Tilia Rumi Okahara | SAAEI | Férias | 04/02/2026 a 13/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 221
          AND TipoAfastamento = 1
          AND DataInicio = '20260204'
          AND DataFim = '20260213'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            221,
            1,
            '20260204',
            '20260213',
            NULL,
            GETDATE()
        );
    END;

    -- Francisco Lanna Guillen | SOE II | Férias | 05/02/2026 a 14/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 183
          AND TipoAfastamento = 1
          AND DataInicio = '20260205'
          AND DataFim = '20260214'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            183,
            1,
            '20260205',
            '20260214',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Licença para tratamento de saúde própria | 10/02/2026 a 19/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 8
          AND DataInicio = '20260210'
          AND DataFim = '20260219'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            8,
            '20260210',
            '20260219',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Licença para tratamento de saúde própria | 12/02/2026 a 28/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 8
          AND DataInicio = '20260212'
          AND DataFim = '20260228'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            8,
            '20260212',
            '20260228',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Férias | 12/02/2026 a 21/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 1
          AND DataInicio = '20260212'
          AND DataFim = '20260221'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            178,
            1,
            '20260212',
            '20260221',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 13/02/2026 a 22/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 1
          AND DataInicio = '20260213'
          AND DataFim = '20260222'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            1,
            '20260213',
            '20260222',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 14/02/2026 a 14/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20260214'
          AND DataFim = '20260214'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            144,
            1,
            '20260214',
            '20260214',
            NULL,
            GETDATE()
        );
    END;

    -- Lincon Massahiro Takano | SOE IV | Férias | 15/02/2026 a 18/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 200
          AND TipoAfastamento = 1
          AND DataInicio = '20260215'
          AND DataFim = '20260218'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            200,
            1,
            '20260215',
            '20260218',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Lima Aguirra | SOE IV | Abono de ponto anual | 15/02/2026 a 17/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 202
          AND TipoAfastamento = 2
          AND DataInicio = '20260215'
          AND DataFim = '20260217'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            202,
            2,
            '20260215',
            '20260217',
            NULL,
            GETDATE()
        );
    END;

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 18/02/2026 a 26/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 131
          AND TipoAfastamento = 1
          AND DataInicio = '20260218'
          AND DataFim = '20260226'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            131,
            1,
            '20260218',
            '20260226',
            NULL,
            GETDATE()
        );
    END;

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 18/02/2026 a 27/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 167
          AND TipoAfastamento = 1
          AND DataInicio = '20260218'
          AND DataFim = '20260227'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            167,
            1,
            '20260218',
            '20260227',
            NULL,
            GETDATE()
        );
    END;

    -- Patricia Araujo Ribeiro | SAAEI | Abono de ponto anual | 18/02/2026 a 20/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 222
          AND TipoAfastamento = 2
          AND DataInicio = '20260218'
          AND DataFim = '20260220'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            222,
            2,
            '20260218',
            '20260220',
            NULL,
            GETDATE()
        );
    END;

    -- Gustavo Amaral Yung | GAB | Férias | 19/02/2026 a 28/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 134
          AND TipoAfastamento = 1
          AND DataInicio = '20260219'
          AND DataFim = '20260228'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            134,
            1,
            '20260219',
            '20260228',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Curso | 23/02/2026 a 28/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 12
          AND DataInicio = '20260223'
          AND DataFim = '20260228'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            12,
            '20260223',
            '20260228',
            NULL,
            GETDATE()
        );
    END;

    -- Diego Madureira Rodrigues | SOE I | Licença para tratamento de saúde própria | 27/02/2026 a 28/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 171
          AND TipoAfastamento = 8
          AND DataInicio = '20260227'
          AND DataFim = '20260228'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            171,
            8,
            '20260227',
            '20260228',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 27/02/2026 a 27/02/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 1
          AND DataInicio = '20260227'
          AND DataFim = '20260227'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            216,
            1,
            '20260227',
            '20260227',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Março
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 03/2026
-- Fonte: MAR 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 25
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Marcelo Vieira de Sousa | GAB | Licença para tratamento de saúde própria | 01/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 133
          AND TipoAfastamento = 8
          AND DataInicio = '20260301'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            133,
            8,
            '20260301',
            '20260331',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Licença para tratamento de saúde própria | 01/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 8
          AND DataInicio = '20260301'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            8,
            '20260301',
            '20260331',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Licença para tratamento de saúde própria | 01/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 8
          AND DataInicio = '20260301'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            8,
            '20260301',
            '20260331',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Licença para tratamento de saúde própria | 01/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 8
          AND DataInicio = '20260301'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            8,
            '20260301',
            '20260331',
            NULL,
            GETDATE()
        );
    END;

    -- Diego Madureira Rodrigues | SOE I | Licença para tratamento de saúde própria | 01/03/2026 a 08/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 171
          AND TipoAfastamento = 8
          AND DataInicio = '20260301'
          AND DataFim = '20260308'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            171,
            8,
            '20260301',
            '20260308',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Abono de ponto anual | 04/03/2026 a 06/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 2
          AND DataInicio = '20260304'
          AND DataFim = '20260306'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            2,
            '20260304',
            '20260306',
            NULL,
            GETDATE()
        );
    END;

    -- Adriano Viano Batista | SOC | Abono de ponto anual | 04/03/2026 a 05/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 164
          AND TipoAfastamento = 2
          AND DataInicio = '20260304'
          AND DataFim = '20260305'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            164,
            2,
            '20260304',
            '20260305',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 05/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 8
          AND DataInicio = '20260305'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            8,
            '20260305',
            '20260331',
            NULL,
            GETDATE()
        );
    END;

    -- Rafaela Lopes Andrade | SOC | Abono de ponto anual | 09/03/2026 a 13/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 2
          AND DataInicio = '20260309'
          AND DataFim = '20260313'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            168,
            2,
            '20260309',
            '20260313',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 11/03/2026 a 14/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 1
          AND DataInicio = '20260311'
          AND DataFim = '20260314'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            199,
            1,
            '20260311',
            '20260314',
            NULL,
            GETDATE()
        );
    END;

    -- Tilia Rumi Okahara | SAAEI | Abono de aniversário | 11/03/2026 a 11/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 221
          AND TipoAfastamento = 3
          AND DataInicio = '20260311'
          AND DataFim = '20260311'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            221,
            3,
            '20260311',
            '20260311',
            NULL,
            GETDATE()
        );
    END;

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 16/03/2026 a 30/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 150
          AND TipoAfastamento = 1
          AND DataInicio = '20260316'
          AND DataFim = '20260330'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            150,
            1,
            '20260316',
            '20260330',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Abono de ponto anual | 19/03/2026 a 20/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 2
          AND DataInicio = '20260319'
          AND DataFim = '20260320'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            135,
            2,
            '20260319',
            '20260320',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 19/03/2026 a 27/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 1
          AND DataInicio = '20260319'
          AND DataFim = '20260327'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            1,
            '20260319',
            '20260327',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | GAB | Férias | 21/03/2026 a 30/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20260321'
          AND DataFim = '20260330'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            1,
            '20260321',
            '20260330',
            NULL,
            GETDATE()
        );
    END;

    -- Alberto Ganzaroli Neto | SOE II | Férias | 21/03/2026 a 30/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 1
          AND DataInicio = '20260321'
          AND DataFim = '20260330'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            185,
            1,
            '20260321',
            '20260330',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Férias | 23/03/2026 a 23/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 1
          AND DataInicio = '20260323'
          AND DataFim = '20260323'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            146,
            1,
            '20260323',
            '20260323',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Chiarelli Linhares Titoneli | SOT | Férias | 23/03/2026 a 23/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 161
          AND TipoAfastamento = 1
          AND DataInicio = '20260323'
          AND DataFim = '20260323'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            161,
            1,
            '20260323',
            '20260323',
            NULL,
            GETDATE()
        );
    END;

    -- Anderson Benevides Valença | SOE IV | Abono de ponto anual | 23/03/2026 a 25/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 205
          AND TipoAfastamento = 2
          AND DataInicio = '20260323'
          AND DataFim = '20260325'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            205,
            2,
            '20260323',
            '20260325',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Licença para tratamento de saúde própria | 24/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 8
          AND DataInicio = '20260324'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            216,
            8,
            '20260324',
            '20260331',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Lima Aguirra | SOE IV | Abono de ponto anual | 27/03/2026 a 28/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 202
          AND TipoAfastamento = 2
          AND DataInicio = '20260327'
          AND DataFim = '20260328'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            202,
            2,
            '20260327',
            '20260328',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Licença para tratamento de saúde própria | 27/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 8
          AND DataInicio = '20260327'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            8,
            '20260327',
            '20260331',
            NULL,
            GETDATE()
        );
    END;

    -- Wanderson Gomes dos Santos | SOE III | Licença para tratamento de saúde própria | 29/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 197
          AND TipoAfastamento = 8
          AND DataInicio = '20260329'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            197,
            8,
            '20260329',
            '20260331',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 31/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 1
          AND DataInicio = '20260331'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            199,
            1,
            '20260331',
            '20260331',
            NULL,
            GETDATE()
        );
    END;

    -- Lincon Massahiro Takano | SOE IV | Férias | 31/03/2026 a 31/03/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 200
          AND TipoAfastamento = 1
          AND DataInicio = '20260331'
          AND DataFim = '20260331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            200,
            1,
            '20260331',
            '20260331',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Abril
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 04/2026
-- Fonte: ABRI 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 40
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Marcelo Vieira de Sousa | GAB | Licença para tratamento de saúde própria | 01/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 133
          AND TipoAfastamento = 8
          AND DataInicio = '20260401'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            133,
            8,
            '20260401',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Licença para tratamento de saúde própria | 01/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 8
          AND DataInicio = '20260401'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            8,
            '20260401',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Licença para tratamento de saúde própria | 01/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 8
          AND DataInicio = '20260401'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            8,
            '20260401',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Licença para tratamento de saúde própria | 01/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 8
          AND DataInicio = '20260401'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            8,
            '20260401',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 01/04/2026 a 03/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 8
          AND DataInicio = '20260401'
          AND DataFim = '20260403'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            8,
            '20260401',
            '20260403',
            NULL,
            GETDATE()
        );
    END;

    -- Wanderson Gomes dos Santos | SOE III | Licença para tratamento de saúde própria | 01/04/2026 a 04/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 197
          AND TipoAfastamento = 8
          AND DataInicio = '20260401'
          AND DataFim = '20260404'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            197,
            8,
            '20260401',
            '20260404',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 01/04/2026 a 05/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 1
          AND DataInicio = '20260401'
          AND DataFim = '20260405'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            199,
            1,
            '20260401',
            '20260405',
            NULL,
            GETDATE()
        );
    END;

    -- Lincon Massahiro Takano | SOE IV | Férias | 01/04/2026 a 05/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 200
          AND TipoAfastamento = 1
          AND DataInicio = '20260401'
          AND DataFim = '20260405'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            200,
            1,
            '20260401',
            '20260405',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Licença para tratamento de saúde própria | 01/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 8
          AND DataInicio = '20260401'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            8,
            '20260401',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Licença para tratamento de saúde própria | 01/04/2026 a 07/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 8
          AND DataInicio = '20260401'
          AND DataFim = '20260407'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            216,
            8,
            '20260401',
            '20260407',
            NULL,
            GETDATE()
        );
    END;

    -- Josué Carvalho da Costa | SOE I | Férias | 05/04/2026 a 10/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20260405'
          AND DataFim = '20260410'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            177,
            1,
            '20260405',
            '20260410',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Abono de ponto anual | 06/04/2026 a 10/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 2
          AND DataInicio = '20260406'
          AND DataFim = '20260410'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            140,
            2,
            '20260406',
            '20260410',
            NULL,
            GETDATE()
        );
    END;

    -- Santilhento Marcos da Silva | SOR | Férias | 06/04/2026 a 20/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 147
          AND TipoAfastamento = 1
          AND DataInicio = '20260406'
          AND DataFim = '20260420'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            147,
            1,
            '20260406',
            '20260420',
            NULL,
            GETDATE()
        );
    END;

    -- Frank Rodrigues Ferreira | SOT | Férias | 06/04/2026 a 14/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 160
          AND TipoAfastamento = 1
          AND DataInicio = '20260406'
          AND DataFim = '20260414'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            160,
            1,
            '20260406',
            '20260414',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Férias | 06/04/2026 a 15/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20260406'
          AND DataFim = '20260415'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            1,
            '20260406',
            '20260415',
            NULL,
            GETDATE()
        );
    END;

    -- Gabriel Arana da Silva | SOE III | Férias | 06/04/2026 a 15/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 196
          AND TipoAfastamento = 1
          AND DataInicio = '20260406'
          AND DataFim = '20260415'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            196,
            1,
            '20260406',
            '20260415',
            NULL,
            GETDATE()
        );
    END;

    -- Rebeca Severo Limongi | SAAEI | Férias | 06/04/2026 a 20/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 223
          AND TipoAfastamento = 1
          AND DataInicio = '20260406'
          AND DataFim = '20260420'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            223,
            1,
            '20260406',
            '20260420',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 09/04/2026 a 17/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 1
          AND DataInicio = '20260409'
          AND DataFim = '20260417'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            216,
            1,
            '20260409',
            '20260417',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 15/04/2026 a 24/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20260415'
          AND DataFim = '20260424'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            142,
            1,
            '20260415',
            '20260424',
            NULL,
            GETDATE()
        );
    END;

    -- Sanlac Machado da Cunha | SOC | Férias | 15/04/2026 a 24/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 162
          AND TipoAfastamento = 1
          AND DataInicio = '20260415'
          AND DataFim = '20260424'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            162,
            1,
            '20260415',
            '20260424',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 15/04/2026 a 29/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 1
          AND DataInicio = '20260415'
          AND DataFim = '20260429'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            193,
            1,
            '20260415',
            '20260429',
            NULL,
            GETDATE()
        );
    END;

    -- Anderson Benevides Valença | SOE IV | Abono de ponto anual | 16/04/2026 a 17/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 205
          AND TipoAfastamento = 2
          AND DataInicio = '20260416'
          AND DataFim = '20260417'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            205,
            2,
            '20260416',
            '20260417',
            NULL,
            GETDATE()
        );
    END;

    -- Edson Medina de Oliveira | GAB | Licença para tratamento de saúde própria | 17/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 8
          AND DataInicio = '20260417'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            130,
            8,
            '20260417',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Eduardo Cosme Carvalho da Silva | SOE I | Abono de ponto anual | 17/04/2026 a 21/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 174
          AND TipoAfastamento = 2
          AND DataInicio = '20260417'
          AND DataFim = '20260421'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            174,
            2,
            '20260417',
            '20260421',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Curso | 19/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 12
          AND DataInicio = '20260419'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            12,
            '20260419',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Curso | 19/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 12
          AND DataInicio = '20260419'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            12,
            '20260419',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Beltrame Faria | SOT | Férias | 20/04/2026 a 29/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 152
          AND TipoAfastamento = 1
          AND DataInicio = '20260420'
          AND DataFim = '20260429'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            152,
            1,
            '20260420',
            '20260429',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Curso | 21/04/2026 a 25/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 12
          AND DataInicio = '20260421'
          AND DataFim = '20260425'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            12,
            '20260421',
            '20260425',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Férias | 21/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 1
          AND DataInicio = '20260421'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            180,
            1,
            '20260421',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Gustavo Amaral Yung | GAB | Abono de ponto anual | 22/04/2026 a 24/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 134
          AND TipoAfastamento = 2
          AND DataInicio = '20260422'
          AND DataFim = '20260424'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            134,
            2,
            '20260422',
            '20260424',
            NULL,
            GETDATE()
        );
    END;

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 22/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 136
          AND TipoAfastamento = 1
          AND DataInicio = '20260422'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            136,
            1,
            '20260422',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Férias | 22/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 1
          AND DataInicio = '20260422'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            143,
            1,
            '20260422',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Férias | 22/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 1
          AND DataInicio = '20260422'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            146,
            1,
            '20260422',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Abono de ponto anual | 22/04/2026 a 24/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 2
          AND DataInicio = '20260422'
          AND DataFim = '20260424'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            2,
            '20260422',
            '20260424',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Abono de ponto anual | 23/04/2026 a 25/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 2
          AND DataInicio = '20260423'
          AND DataFim = '20260425'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            190,
            2,
            '20260423',
            '20260425',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Férias | 27/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 1
          AND DataInicio = '20260427'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            135,
            1,
            '20260427',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Sanlac Machado da Cunha | SOC | Abono de ponto anual | 27/04/2026 a 28/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 162
          AND TipoAfastamento = 2
          AND DataInicio = '20260427'
          AND DataFim = '20260428'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            162,
            2,
            '20260427',
            '20260428',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Abono de ponto anual | 27/04/2026 a 27/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 2
          AND DataInicio = '20260427'
          AND DataFim = '20260427'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            2,
            '20260427',
            '20260427',
            NULL,
            GETDATE()
        );
    END;

    -- Franthiesco L. Fernandes Nunes | SOE III | Abono de ponto anual | 27/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 194
          AND TipoAfastamento = 2
          AND DataInicio = '20260427'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            194,
            2,
            '20260427',
            '20260430',
            NULL,
            GETDATE()
        );
    END;

    -- Gustavo Amaral Yung | GAB | Abono de ponto anual | 29/04/2026 a 30/04/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 134
          AND TipoAfastamento = 2
          AND DataInicio = '20260429'
          AND DataFim = '20260430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            134,
            2,
            '20260429',
            '20260430',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Maio
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 05/2026
-- Fonte: MAI 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 33
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Marcelo Vieira de Sousa | GAB | Licença para tratamento de saúde própria | 01/05/2026 a 11/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 133
          AND TipoAfastamento = 8
          AND DataInicio = '20260501'
          AND DataFim = '20260511'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            133,
            8,
            '20260501',
            '20260511',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Férias | 01/05/2026 a 06/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 1
          AND DataInicio = '20260501'
          AND DataFim = '20260506'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            135,
            1,
            '20260501',
            '20260506',
            NULL,
            GETDATE()
        );
    END;

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 01/05/2026 a 01/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 136
          AND TipoAfastamento = 1
          AND DataInicio = '20260501'
          AND DataFim = '20260501'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            136,
            1,
            '20260501',
            '20260501',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Férias | 01/05/2026 a 01/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 1
          AND DataInicio = '20260501'
          AND DataFim = '20260501'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            143,
            1,
            '20260501',
            '20260501',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Licença-prêmio por assiduidade | 01/05/2026 a 09/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 5
          AND DataInicio = '20260501'
          AND DataFim = '20260509'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            5,
            '20260501',
            '20260509',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Licença para tratamento de saúde própria | 01/05/2026 a 05/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 8
          AND DataInicio = '20260501'
          AND DataFim = '20260505'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            8,
            '20260501',
            '20260505',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Licença-prêmio por assiduidade | 01/05/2026 a 09/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 5
          AND DataInicio = '20260501'
          AND DataFim = '20260509'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            5,
            '20260501',
            '20260509',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Licença para tratamento de saúde própria | 01/05/2026 a 06/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 8
          AND DataInicio = '20260501'
          AND DataFim = '20260506'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            8,
            '20260501',
            '20260506',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Licença para tratamento de saúde própria | 01/05/2026 a 31/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 8
          AND DataInicio = '20260501'
          AND DataFim = '20260531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            8,
            '20260501',
            '20260531',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Abono de ponto anual | 01/05/2026 a 03/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 2
          AND DataInicio = '20260501'
          AND DataFim = '20260503'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            193,
            2,
            '20260501',
            '20260503',
            NULL,
            GETDATE()
        );
    END;

    -- Franthiesco L. Fernandes Nunes | SOE III | Abono de ponto anual | 01/05/2026 a 01/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 194
          AND TipoAfastamento = 2
          AND DataInicio = '20260501'
          AND DataFim = '20260501'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            194,
            2,
            '20260501',
            '20260501',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Licença para tratamento de saúde própria | 01/05/2026 a 31/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 8
          AND DataInicio = '20260501'
          AND DataFim = '20260531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            8,
            '20260501',
            '20260531',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Lima Aguirra | SOE IV | Férias | 02/05/2026 a 11/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 202
          AND TipoAfastamento = 1
          AND DataInicio = '20260502'
          AND DataFim = '20260511'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            202,
            1,
            '20260502',
            '20260511',
            NULL,
            GETDATE()
        );
    END;

    -- Renato Bizinoto Molas | SOE I | Abono de ponto anual | 03/05/2026 a 07/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 170
          AND TipoAfastamento = 2
          AND DataInicio = '20260503'
          AND DataFim = '20260507'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            170,
            2,
            '20260503',
            '20260507',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 03/05/2026 a 31/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 8
          AND DataInicio = '20260503'
          AND DataFim = '20260531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            8,
            '20260503',
            '20260531',
            NULL,
            GETDATE()
        );
    END;

    -- Edson Medina de Oliveira | GAB | Férias | 04/05/2026 a 06/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 1
          AND DataInicio = '20260504'
          AND DataFim = '20260506'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            130,
            1,
            '20260504',
            '20260506',
            NULL,
            GETDATE()
        );
    END;

    -- Pericles M. de Rezende Junior | SOT | Férias | 04/05/2026 a 31/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 156
          AND TipoAfastamento = 1
          AND DataInicio = '20260504'
          AND DataFim = '20260531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            156,
            1,
            '20260504',
            '20260531',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 04/05/2026 a 13/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 1
          AND DataInicio = '20260504'
          AND DataFim = '20260513'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            166,
            1,
            '20260504',
            '20260513',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Férias | 05/05/2026 a 14/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 1
          AND DataInicio = '20260505'
          AND DataFim = '20260514'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            191,
            1,
            '20260505',
            '20260514',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Férias | 11/05/2026 a 16/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 1
          AND DataInicio = '20260511'
          AND DataFim = '20260516'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            140,
            1,
            '20260511',
            '20260516',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Abono de ponto anual | 11/05/2026 a 12/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 2
          AND DataInicio = '20260511'
          AND DataFim = '20260512'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            2,
            '20260511',
            '20260512',
            NULL,
            GETDATE()
        );
    END;

    -- Diego Madureira Rodrigues | SOE I | Licença para tratamento de saúde própria | 11/05/2026 a 24/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 171
          AND TipoAfastamento = 8
          AND DataInicio = '20260511'
          AND DataFim = '20260524'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            171,
            8,
            '20260511',
            '20260524',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Abono de ponto anual | 14/05/2026 a 15/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 2
          AND DataInicio = '20260514'
          AND DataFim = '20260515'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            2,
            '20260514',
            '20260515',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Licença para tratar de interesse particular | 14/05/2026 a 14/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 6
          AND DataInicio = '20260514'
          AND DataFim = '20260514'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            199,
            6,
            '20260514',
            '20260514',
            NULL,
            GETDATE()
        );
    END;

    -- Leandro de Oliveira Sampaio | GAB | Licença para tratamento de saúde própria | 16/05/2026 a 31/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 8
          AND DataInicio = '20260516'
          AND DataFim = '20260531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            132,
            8,
            '20260516',
            '20260531',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Licença para tratamento de saúde própria | 17/05/2026 a 31/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 8
          AND DataInicio = '20260517'
          AND DataFim = '20260531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            178,
            8,
            '20260517',
            '20260531',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Abono de ponto anual | 18/05/2026 a 19/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 2
          AND DataInicio = '20260518'
          AND DataFim = '20260519'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            149,
            2,
            '20260518',
            '20260519',
            NULL,
            GETDATE()
        );
    END;

    -- Rafaela Lopes Andrade | SOC | Férias | 18/05/2026 a 27/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 1
          AND DataInicio = '20260518'
          AND DataFim = '20260527'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            168,
            1,
            '20260518',
            '20260527',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 22/05/2026 a 27/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 198
          AND TipoAfastamento = 1
          AND DataInicio = '20260522'
          AND DataFim = '20260527'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            198,
            1,
            '20260522',
            '20260527',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Lebrão Arruda | SOE IV | Abono de ponto anual | 22/05/2026 a 24/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 201
          AND TipoAfastamento = 2
          AND DataInicio = '20260522'
          AND DataFim = '20260524'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            201,
            2,
            '20260522',
            '20260524',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Pereira de Jesus | SOE II | Férias | 24/05/2026 a 31/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 186
          AND TipoAfastamento = 1
          AND DataInicio = '20260524'
          AND DataFim = '20260531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            186,
            1,
            '20260524',
            '20260531',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 26/05/2026 a 31/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20260526'
          AND DataFim = '20260531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            144,
            1,
            '20260526',
            '20260531',
            NULL,
            GETDATE()
        );
    END;

    -- Anderson Benevides Valença | SOE IV | Férias | 29/05/2026 a 31/05/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 205
          AND TipoAfastamento = 1
          AND DataInicio = '20260529'
          AND DataFim = '20260531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            205,
            1,
            '20260529',
            '20260531',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Junho
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 06/2026
-- Fonte: JUN 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 29
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Leandro de Oliveira Sampaio | GAB | Licença para tratamento de saúde própria | 01/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 8
          AND DataInicio = '20260601'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            132,
            8,
            '20260601',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 01/06/2026 a 03/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20260601'
          AND DataFim = '20260603'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            144,
            1,
            '20260601',
            '20260603',
            NULL,
            GETDATE()
        );
    END;

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 01/06/2026 a 05/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 150
          AND TipoAfastamento = 1
          AND DataInicio = '20260601'
          AND DataFim = '20260605'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            150,
            1,
            '20260601',
            '20260605',
            NULL,
            GETDATE()
        );
    END;

    -- Pericles M. de Rezende Junior | SOT | Férias | 01/06/2026 a 02/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 156
          AND TipoAfastamento = 1
          AND DataInicio = '20260601'
          AND DataFim = '20260602'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            156,
            1,
            '20260601',
            '20260602',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Licença para tratamento de saúde própria | 01/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 8
          AND DataInicio = '20260601'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            8,
            '20260601',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Licença para tratamento de saúde própria | 01/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 8
          AND DataInicio = '20260601'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            178,
            8,
            '20260601',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Pereira de Jesus | SOE II | Férias | 01/06/2026 a 02/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 186
          AND TipoAfastamento = 1
          AND DataInicio = '20260601'
          AND DataFim = '20260602'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            186,
            1,
            '20260601',
            '20260602',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 01/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 8
          AND DataInicio = '20260601'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            8,
            '20260601',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Licença para tratamento de saúde própria | 01/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 8
          AND DataInicio = '20260601'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            8,
            '20260601',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Anderson Benevides Valença | SOE IV | Férias | 01/06/2026 a 12/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 205
          AND TipoAfastamento = 1
          AND DataInicio = '20260601'
          AND DataFim = '20260612'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            205,
            1,
            '20260601',
            '20260612',
            NULL,
            GETDATE()
        );
    END;

    -- Ananias Batista Gomes Junior | GAB | Abono de aniversário | 01/06/2026 a 01/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 215
          AND TipoAfastamento = 3
          AND DataInicio = '20260601'
          AND DataFim = '20260601'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            215,
            3,
            '20260601',
            '20260601',
            NULL,
            GETDATE()
        );
    END;

    -- Rubens Torres Deolindo | SOE III | Férias | 02/06/2026 a 11/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 192
          AND TipoAfastamento = 1
          AND DataInicio = '20260602'
          AND DataFim = '20260611'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            192,
            1,
            '20260602',
            '20260611',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Abono de ponto anual | 03/06/2026 a 07/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 2
          AND DataInicio = '20260603'
          AND DataFim = '20260607'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            199,
            2,
            '20260603',
            '20260607',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Férias | 08/06/2026 a 08/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 1
          AND DataInicio = '20260608'
          AND DataFim = '20260608'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            149,
            1,
            '20260608',
            '20260608',
            NULL,
            GETDATE()
        );
    END;

    -- Frank Rodrigues Ferreira | SOT | Abono de ponto anual | 08/06/2026 a 09/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 160
          AND TipoAfastamento = 2
          AND DataInicio = '20260608'
          AND DataFim = '20260609'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            160,
            2,
            '20260608',
            '20260609',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Pereira de Jesus | SOE II | Abono de ponto anual | 09/06/2026 a 13/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 186
          AND TipoAfastamento = 2
          AND DataInicio = '20260609'
          AND DataFim = '20260613'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            186,
            2,
            '20260609',
            '20260613',
            NULL,
            GETDATE()
        );
    END;

    -- Patricia Araujo Ribeiro | SAAEI | Abono de aniversário | 12/06/2026 a 12/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 222
          AND TipoAfastamento = 3
          AND DataInicio = '20260612'
          AND DataFim = '20260612'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            222,
            3,
            '20260612',
            '20260612',
            NULL,
            GETDATE()
        );
    END;

    -- Edson Medina de Oliveira | GAB | Férias | 15/06/2026 a 15/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 1
          AND DataInicio = '20260615'
          AND DataFim = '20260615'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            130,
            1,
            '20260615',
            '20260615',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 18/06/2026 a 18/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 1
          AND DataInicio = '20260618'
          AND DataFim = '20260618'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            1,
            '20260618',
            '20260618',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 20/06/2026 a 29/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 1
          AND DataInicio = '20260620'
          AND DataFim = '20260629'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            1,
            '20260620',
            '20260629',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Abono de ponto anual | 22/06/2026 a 22/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 2
          AND DataInicio = '20260622'
          AND DataFim = '20260622'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            142,
            2,
            '20260622',
            '20260622',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Thomas | GAB | Licença para tratamento de saúde própria | 23/06/2026 a 23/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 173
          AND TipoAfastamento = 8
          AND DataInicio = '20260623'
          AND DataFim = '20260623'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            173,
            8,
            '20260623',
            '20260623',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 23/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 198
          AND TipoAfastamento = 1
          AND DataInicio = '20260623'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            198,
            1,
            '20260623',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 24/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20260624'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            175,
            1,
            '20260624',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Francisco Lanna Guillen | SOE II | Férias | 25/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 183
          AND TipoAfastamento = 1
          AND DataInicio = '20260625'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            183,
            1,
            '20260625',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Abono de ponto anual | 26/06/2026 a 26/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 2
          AND DataInicio = '20260626'
          AND DataFim = '20260626'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            146,
            2,
            '20260626',
            '20260626',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 29/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 1
          AND DataInicio = '20260629'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            139,
            1,
            '20260629',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 29/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20260629'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            1,
            '20260629',
            '20260630',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Abono de ponto anual | 30/06/2026 a 30/06/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 2
          AND DataInicio = '20260630'
          AND DataFim = '20260630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            155,
            2,
            '20260630',
            '20260630',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Julho
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 07/2026
-- Fonte: JUL 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 49
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Leandro de Oliveira Sampaio | GAB | Licença para tratamento de saúde própria | 01/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 8
          AND DataInicio = '20260701'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            132,
            8,
            '20260701',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 01/07/2026 a 08/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 1
          AND DataInicio = '20260701'
          AND DataFim = '20260708'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            139,
            1,
            '20260701',
            '20260708',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 01/07/2026 a 01/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 1
          AND DataInicio = '20260701'
          AND DataFim = '20260701'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            1,
            '20260701',
            '20260701',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 01/07/2026 a 07/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20260701'
          AND DataFim = '20260707'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            1,
            '20260701',
            '20260707',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Licença para tratamento de saúde própria | 01/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 8
          AND DataInicio = '20260701'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            8,
            '20260701',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Chiarelli Linhares Titoneli | SOT | Férias | 01/07/2026 a 09/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 161
          AND TipoAfastamento = 1
          AND DataInicio = '20260701'
          AND DataFim = '20260709'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            161,
            1,
            '20260701',
            '20260709',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 01/07/2026 a 03/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20260701'
          AND DataFim = '20260703'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            175,
            1,
            '20260701',
            '20260703',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Férias | 01/07/2026 a 10/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 1
          AND DataInicio = '20260701'
          AND DataFim = '20260710'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            178,
            1,
            '20260701',
            '20260710',
            NULL,
            GETDATE()
        );
    END;

    -- Francisco Lanna Guillen | SOE II | Férias | 01/07/2026 a 04/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 183
          AND TipoAfastamento = 1
          AND DataInicio = '20260701'
          AND DataFim = '20260704'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            183,
            1,
            '20260701',
            '20260704',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 01/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 8
          AND DataInicio = '20260701'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            8,
            '20260701',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 01/07/2026 a 02/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 198
          AND TipoAfastamento = 1
          AND DataInicio = '20260701'
          AND DataFim = '20260702'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            198,
            1,
            '20260701',
            '20260702',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Licença para tratamento de saúde própria | 01/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 8
          AND DataInicio = '20260701'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            8,
            '20260701',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 03/07/2026 a 12/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 131
          AND TipoAfastamento = 1
          AND DataInicio = '20260703'
          AND DataFim = '20260712'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            131,
            1,
            '20260703',
            '20260712',
            NULL,
            GETDATE()
        );
    END;

    -- Franthiesco L. Fernandes Nunes | SOE III | Férias | 03/07/2026 a 17/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 194
          AND TipoAfastamento = 1
          AND DataInicio = '20260703'
          AND DataFim = '20260717'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            194,
            1,
            '20260703',
            '20260717',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | GAB | Férias | 04/07/2026 a 13/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20260704'
          AND DataFim = '20260713'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            1,
            '20260704',
            '20260713',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 05/07/2026 a 14/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 1
          AND DataInicio = '20260705'
          AND DataFim = '20260714'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            1,
            '20260705',
            '20260714',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Licença para tratamento de saúde própria | 06/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 8
          AND DataInicio = '20260706'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            8,
            '20260706',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Juliano Dantas Bueno | SOT | Férias | 06/07/2026 a 15/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 154
          AND TipoAfastamento = 1
          AND DataInicio = '20260706'
          AND DataFim = '20260715'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            154,
            1,
            '20260706',
            '20260715',
            NULL,
            GETDATE()
        );
    END;

    -- Eduardo Cosme Carvalho da Silva | SOE I | Férias | 06/07/2026 a 15/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 174
          AND TipoAfastamento = 1
          AND DataInicio = '20260706'
          AND DataFim = '20260715'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            174,
            1,
            '20260706',
            '20260715',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Licença para tratamento de saúde própria | 06/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 8
          AND DataInicio = '20260706'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            180,
            8,
            '20260706',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Sidney da Silva de Oliveira | SOE II | Férias | 06/07/2026 a 09/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 188
          AND TipoAfastamento = 1
          AND DataInicio = '20260706'
          AND DataFim = '20260709'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            188,
            1,
            '20260706',
            '20260709',
            NULL,
            GETDATE()
        );
    END;

    -- Adenauer Dantas Justo | SI | Férias | 07/07/2026 a 26/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 138
          AND TipoAfastamento = 1
          AND DataInicio = '20260707'
          AND DataFim = '20260726'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            138,
            1,
            '20260707',
            '20260726',
            NULL,
            GETDATE()
        );
    END;

    -- Aurelio Gleria Cavalcante | SOC | Abono de ponto anual | 07/07/2026 a 10/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 169
          AND TipoAfastamento = 2
          AND DataInicio = '20260707'
          AND DataFim = '20260710'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            169,
            2,
            '20260707',
            '20260710',
            NULL,
            GETDATE()
        );
    END;

    -- Honney Cordeiro | SOE II | Férias | 07/07/2026 a 16/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 181
          AND TipoAfastamento = 1
          AND DataInicio = '20260707'
          AND DataFim = '20260716'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            181,
            1,
            '20260707',
            '20260716',
            NULL,
            GETDATE()
        );
    END;

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 08/07/2026 a 17/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 167
          AND TipoAfastamento = 1
          AND DataInicio = '20260708'
          AND DataFim = '20260717'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            167,
            1,
            '20260708',
            '20260717',
            NULL,
            GETDATE()
        );
    END;

    -- Luiz Cesar Mendes de Almeida | SOE III | Abono de ponto anual | 08/07/2026 a 12/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 189
          AND TipoAfastamento = 2
          AND DataInicio = '20260708'
          AND DataFim = '20260712'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            189,
            2,
            '20260708',
            '20260712',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 09/07/2026 a 17/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 1
          AND DataInicio = '20260709'
          AND DataFim = '20260717'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            1,
            '20260709',
            '20260717',
            NULL,
            GETDATE()
        );
    END;

    -- Diego Madureira Rodrigues | SOE I | Férias | 10/07/2026 a 19/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 171
          AND TipoAfastamento = 1
          AND DataInicio = '20260710'
          AND DataFim = '20260719'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            171,
            1,
            '20260710',
            '20260719',
            NULL,
            GETDATE()
        );
    END;

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 13/07/2026 a 22/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 136
          AND TipoAfastamento = 1
          AND DataInicio = '20260713'
          AND DataFim = '20260722'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            136,
            1,
            '20260713',
            '20260722',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Férias | 13/07/2026 a 17/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 1
          AND DataInicio = '20260713'
          AND DataFim = '20260717'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            140,
            1,
            '20260713',
            '20260717',
            NULL,
            GETDATE()
        );
    END;

    -- Cinthia Versiani Pontes | SOC | Férias | 13/07/2026 a 22/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 163
          AND TipoAfastamento = 1
          AND DataInicio = '20260713'
          AND DataFim = '20260722'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            163,
            1,
            '20260713',
            '20260722',
            NULL,
            GETDATE()
        );
    END;

    -- Sidney da Silva de Oliveira | SOE II | Licença para tratamento de saúde própria | 17/07/2026 a 19/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 188
          AND TipoAfastamento = 8
          AND DataInicio = '20260717'
          AND DataFim = '20260719'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            188,
            8,
            '20260717',
            '20260719',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Thomas | GAB | Férias | 18/07/2026 a 27/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 173
          AND TipoAfastamento = 1
          AND DataInicio = '20260718'
          AND DataFim = '20260727'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            173,
            1,
            '20260718',
            '20260727',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Abono de ponto anual | 18/07/2026 a 20/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 2
          AND DataInicio = '20260718'
          AND DataFim = '20260720'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            178,
            2,
            '20260718',
            '20260720',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 18/07/2026 a 23/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20260718'
          AND DataFim = '20260723'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            179,
            1,
            '20260718',
            '20260723',
            NULL,
            GETDATE()
        );
    END;

    -- Max Macedo Cavalcante | SOE II | Férias | 19/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 220
          AND TipoAfastamento = 1
          AND DataInicio = '20260719'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            220,
            1,
            '20260719',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Férias | 20/07/2026 a 29/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 1
          AND DataInicio = '20260720'
          AND DataFim = '20260729'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            146,
            1,
            '20260720',
            '20260729',
            NULL,
            GETDATE()
        );
    END;

    -- Frank Rodrigues Ferreira | SOT | Férias | 20/07/2026 a 29/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 160
          AND TipoAfastamento = 1
          AND DataInicio = '20260720'
          AND DataFim = '20260729'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            160,
            1,
            '20260720',
            '20260729',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Férias | 20/07/2026 a 29/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 1
          AND DataInicio = '20260720'
          AND DataFim = '20260729'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            190,
            1,
            '20260720',
            '20260729',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 20/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 1
          AND DataInicio = '20260720'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            193,
            1,
            '20260720',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Patricia Araujo Ribeiro | SAAEI | Abono de ponto anual | 20/07/2026 a 24/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 222
          AND TipoAfastamento = 2
          AND DataInicio = '20260720'
          AND DataFim = '20260724'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            222,
            2,
            '20260720',
            '20260724',
            NULL,
            GETDATE()
        );
    END;

    -- Alberto Ganzaroli Neto | SOE II | Licença para tratamento de saúde própria | 22/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 8
          AND DataInicio = '20260722'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            185,
            8,
            '20260722',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Licença para tratar de interesse particular | 23/07/2026 a 23/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 6
          AND DataInicio = '20260723'
          AND DataFim = '20260723'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            144,
            6,
            '20260723',
            '20260723',
            NULL,
            GETDATE()
        );
    END;

    -- Lincon Massahiro Takano | SOE IV | Férias | 25/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 200
          AND TipoAfastamento = 1
          AND DataInicio = '20260725'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            200,
            1,
            '20260725',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Licença para tratamento de saúde própria | 26/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 8
          AND DataInicio = '20260726'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            212,
            8,
            '20260726',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Férias | 27/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 1
          AND DataInicio = '20260727'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            149,
            1,
            '20260727',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Rubens Torres Deolindo | SOE III | Abono de ponto anual | 28/07/2026 a 29/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 192
          AND TipoAfastamento = 2
          AND DataInicio = '20260728'
          AND DataFim = '20260729'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            192,
            2,
            '20260728',
            '20260729',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Licença para tratamento de saúde própria | 28/07/2026 a 31/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 8
          AND DataInicio = '20260728'
          AND DataFim = '20260731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            8,
            '20260728',
            '20260731',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Licença para tratar de interesse particular | 30/07/2026 a 30/07/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 6
          AND DataInicio = '20260730'
          AND DataFim = '20260730'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            146,
            6,
            '20260730',
            '20260730',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Agosto
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 08/2026
-- Fonte: AGO 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 51
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Leandro de Oliveira Sampaio | GAB | Licença para tratamento de saúde própria | 01/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 8
          AND DataInicio = '20260801'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            132,
            8,
            '20260801',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Férias | 01/08/2026 a 04/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 1
          AND DataInicio = '20260801'
          AND DataFim = '20260804'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            149,
            1,
            '20260801',
            '20260804',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Licença para tratamento de saúde própria | 01/08/2026 a 04/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 8
          AND DataInicio = '20260801'
          AND DataFim = '20260804'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            8,
            '20260801',
            '20260804',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Licença para tratamento de saúde própria | 01/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 8
          AND DataInicio = '20260801'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            8,
            '20260801',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Licença para tratamento de saúde própria | 01/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 8
          AND DataInicio = '20260801'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            180,
            8,
            '20260801',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 01/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 8
          AND DataInicio = '20260801'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            8,
            '20260801',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Licença para tratamento de saúde própria | 01/08/2026 a 01/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 8
          AND DataInicio = '20260801'
          AND DataFim = '20260801'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            190,
            8,
            '20260801',
            '20260801',
            NULL,
            GETDATE()
        );
    END;

    -- Rubens Torres Deolindo | SOE III | Férias | 01/08/2026 a 10/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 192
          AND TipoAfastamento = 1
          AND DataInicio = '20260801'
          AND DataFim = '20260810'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            192,
            1,
            '20260801',
            '20260810',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 01/08/2026 a 03/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 1
          AND DataInicio = '20260801'
          AND DataFim = '20260803'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            193,
            1,
            '20260801',
            '20260803',
            NULL,
            GETDATE()
        );
    END;

    -- Wanderson Gomes dos Santos | SOE III | Abono de ponto anual | 01/08/2026 a 03/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 197
          AND TipoAfastamento = 2
          AND DataInicio = '20260801'
          AND DataFim = '20260803'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            197,
            2,
            '20260801',
            '20260803',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Licença para tratamento de saúde própria | 01/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 8
          AND DataInicio = '20260801'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            8,
            '20260801',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Licença para tratamento de saúde própria | 01/08/2026 a 26/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 8
          AND DataInicio = '20260801'
          AND DataFim = '20260826'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            8,
            '20260801',
            '20260826',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Licença para tratamento de saúde própria | 01/08/2026 a 02/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 8
          AND DataInicio = '20260801'
          AND DataFim = '20260802'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            212,
            8,
            '20260801',
            '20260802',
            NULL,
            GETDATE()
        );
    END;

    -- Max Macedo Cavalcante | SOE II | Férias | 01/08/2026 a 02/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 220
          AND TipoAfastamento = 1
          AND DataInicio = '20260801'
          AND DataFim = '20260802'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            220,
            1,
            '20260801',
            '20260802',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 03/08/2026 a 12/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20260803'
          AND DataFim = '20260812'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            144,
            1,
            '20260803',
            '20260812',
            NULL,
            GETDATE()
        );
    END;

    -- Josué Carvalho da Costa | SOE I | Férias | 03/08/2026 a 12/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20260803'
          AND DataFim = '20260812'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            177,
            1,
            '20260803',
            '20260812',
            NULL,
            GETDATE()
        );
    END;

    -- Alberto Ganzaroli Neto | SOE II | Férias | 04/08/2026 a 13/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 1
          AND DataInicio = '20260804'
          AND DataFim = '20260813'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            185,
            1,
            '20260804',
            '20260813',
            NULL,
            GETDATE()
        );
    END;

    -- Silvestre Milhomem Amaral | SI | Férias | 05/08/2026 a 14/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 137
          AND TipoAfastamento = 1
          AND DataInicio = '20260805'
          AND DataFim = '20260814'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            137,
            1,
            '20260805',
            '20260814',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 05/08/2026 a 14/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 1
          AND DataInicio = '20260805'
          AND DataFim = '20260814'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            1,
            '20260805',
            '20260814',
            NULL,
            GETDATE()
        );
    END;

    -- Gabriel Arana da Silva | SOE III | Férias | 05/08/2026 a 14/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 196
          AND TipoAfastamento = 1
          AND DataInicio = '20260805'
          AND DataFim = '20260814'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            196,
            1,
            '20260805',
            '20260814',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 06/08/2026 a 15/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 1
          AND DataInicio = '20260806'
          AND DataFim = '20260815'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            199,
            1,
            '20260806',
            '20260815',
            NULL,
            GETDATE()
        );
    END;

    -- Thallys Mendes Passos | SOE II | Abono de ponto anual | 08/08/2026 a 09/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 182
          AND TipoAfastamento = 2
          AND DataInicio = '20260808'
          AND DataFim = '20260809'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            182,
            2,
            '20260808',
            '20260809',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 09/08/2026 a 18/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 195
          AND TipoAfastamento = 1
          AND DataInicio = '20260809'
          AND DataFim = '20260818'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            195,
            1,
            '20260809',
            '20260818',
            NULL,
            GETDATE()
        );
    END;

    -- Edson Medina de Oliveira | GAB | Jogos Policiais | 11/08/2026 a 13/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 13
          AND DataInicio = '20260811'
          AND DataFim = '20260813'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            130,
            13,
            '20260811',
            '20260813',
            NULL,
            GETDATE()
        );
    END;

    -- Adenauer Dantas Justo | SI | Jogos Policiais | 11/08/2026 a 14/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 138
          AND TipoAfastamento = 13
          AND DataInicio = '20260811'
          AND DataFim = '20260814'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            138,
            13,
            '20260811',
            '20260814',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Beltrame Faria | SOT | Férias | 11/08/2026 a 20/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 152
          AND TipoAfastamento = 1
          AND DataInicio = '20260811'
          AND DataFim = '20260820'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            152,
            1,
            '20260811',
            '20260820',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Férias | 12/08/2026 a 21/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 1
          AND DataInicio = '20260812'
          AND DataFim = '20260821'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            143,
            1,
            '20260812',
            '20260821',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Licença Paternidade | 12/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 15
          AND DataInicio = '20260812'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            157,
            15,
            '20260812',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Abono de ponto anual | 14/08/2026 a 14/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 2
          AND DataInicio = '20260814'
          AND DataFim = '20260814'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            149,
            2,
            '20260814',
            '20260814',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Lima Aguirra | SOE IV | Férias | 14/08/2026 a 23/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 202
          AND TipoAfastamento = 1
          AND DataInicio = '20260814'
          AND DataFim = '20260823'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            202,
            1,
            '20260814',
            '20260823',
            NULL,
            GETDATE()
        );
    END;

    -- Alberto Ganzaroli Neto | SOE II | Abono de ponto anual | 16/08/2026 a 20/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 2
          AND DataInicio = '20260816'
          AND DataFim = '20260820'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            185,
            2,
            '20260816',
            '20260820',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Férias | 17/08/2026 a 26/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 1
          AND DataInicio = '20260817'
          AND DataFim = '20260826'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            140,
            1,
            '20260817',
            '20260826',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 17/08/2026 a 26/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 1
          AND DataInicio = '20260817'
          AND DataFim = '20260826'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            1,
            '20260817',
            '20260826',
            NULL,
            GETDATE()
        );
    END;

    -- Rafaela Lopes Andrade | SOC | Férias | 17/08/2026 a 26/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 1
          AND DataInicio = '20260817'
          AND DataFim = '20260826'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            168,
            1,
            '20260817',
            '20260826',
            NULL,
            GETDATE()
        );
    END;

    -- Gabriel Arana da Silva | SOE III | Abono de ponto anual | 17/08/2026 a 19/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 196
          AND TipoAfastamento = 2
          AND DataInicio = '20260817'
          AND DataFim = '20260819'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            196,
            2,
            '20260817',
            '20260819',
            NULL,
            GETDATE()
        );
    END;

    -- Edson Medina de Oliveira | GAB | Férias | 20/08/2026 a 28/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 1
          AND DataInicio = '20260820'
          AND DataFim = '20260828'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            130,
            1,
            '20260820',
            '20260828',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Abono de ponto anual | 21/08/2026 a 21/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 2
          AND DataInicio = '20260821'
          AND DataFim = '20260821'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            212,
            2,
            '20260821',
            '20260821',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 21/08/2026 a 30/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 1
          AND DataInicio = '20260821'
          AND DataFim = '20260830'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            216,
            1,
            '20260821',
            '20260830',
            NULL,
            GETDATE()
        );
    END;

    -- Alberto Ganzaroli Neto | SOE II | Férias | 24/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 1
          AND DataInicio = '20260824'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            185,
            1,
            '20260824',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Frank Rodrigues Ferreira | SOT | Férias | 26/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 160
          AND TipoAfastamento = 1
          AND DataInicio = '20260826'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            160,
            1,
            '20260826',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Abono de ponto anual | 26/08/2026 a 28/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 2
          AND DataInicio = '20260826'
          AND DataFim = '20260828'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            166,
            2,
            '20260826',
            '20260828',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 27/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20260827'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            175,
            1,
            '20260827',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Francisco Lanna Guillen | SOE II | Férias | 28/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 183
          AND TipoAfastamento = 1
          AND DataInicio = '20260828'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            183,
            1,
            '20260828',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Licença para tratamento de saúde própria | 28/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 8
          AND DataInicio = '20260828'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            8,
            '20260828',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Abono de ponto anual | 29/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 2
          AND DataInicio = '20260829'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            191,
            2,
            '20260829',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Roberto Valente Caetano | GAB | Abono de aniversário | 29/08/2026 a 29/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 206
          AND TipoAfastamento = 3
          AND DataInicio = '20260829'
          AND DataFim = '20260829'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            206,
            3,
            '20260829',
            '20260829',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 31/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20260831'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            142,
            1,
            '20260831',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Abono de ponto anual | 31/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 2
          AND DataInicio = '20260831'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            2,
            '20260831',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Abono de ponto anual | 31/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 2
          AND DataInicio = '20260831'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            149,
            2,
            '20260831',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Nunes | SOT | Férias | 31/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 158
          AND TipoAfastamento = 1
          AND DataInicio = '20260831'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            158,
            1,
            '20260831',
            '20260831',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Abono de ponto anual | 31/08/2026 a 31/08/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 2
          AND DataInicio = '20260831'
          AND DataFim = '20260831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            166,
            2,
            '20260831',
            '20260831',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Setembro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 09/2026
-- Fonte: SET 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 41
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Leandro de Oliveira Sampaio | GAB | Licença para tratamento de saúde própria | 01/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 8
          AND DataInicio = '20260901'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            132,
            8,
            '20260901',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 01/09/2026 a 07/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20260901'
          AND DataFim = '20260907'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            142,
            1,
            '20260901',
            '20260907',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Abono de ponto anual | 01/09/2026 a 01/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 2
          AND DataInicio = '20260901'
          AND DataFim = '20260901'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            2,
            '20260901',
            '20260901',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Nunes | SOT | Férias | 01/09/2026 a 09/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 158
          AND TipoAfastamento = 1
          AND DataInicio = '20260901'
          AND DataFim = '20260909'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            158,
            1,
            '20260901',
            '20260909',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Licença para tratamento de saúde própria | 01/09/2026 a 07/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 8
          AND DataInicio = '20260901'
          AND DataFim = '20260907'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            8,
            '20260901',
            '20260907',
            NULL,
            GETDATE()
        );
    END;

    -- Frank Rodrigues Ferreira | SOT | Férias | 01/09/2026 a 04/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 160
          AND TipoAfastamento = 1
          AND DataInicio = '20260901'
          AND DataFim = '20260904'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            160,
            1,
            '20260901',
            '20260904',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Abono de ponto anual | 01/09/2026 a 01/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 2
          AND DataInicio = '20260901'
          AND DataFim = '20260901'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            166,
            2,
            '20260901',
            '20260901',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 01/09/2026 a 03/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20260901'
          AND DataFim = '20260903'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            175,
            1,
            '20260901',
            '20260903',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Licença para tratamento de saúde própria | 01/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 8
          AND DataInicio = '20260901'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            180,
            8,
            '20260901',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Francisco Lanna Guillen | SOE II | Férias | 01/09/2026 a 06/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 183
          AND TipoAfastamento = 1
          AND DataInicio = '20260901'
          AND DataFim = '20260906'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            183,
            1,
            '20260901',
            '20260906',
            NULL,
            GETDATE()
        );
    END;

    -- Alberto Ganzaroli Neto | SOE II | Férias | 01/09/2026 a 02/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 1
          AND DataInicio = '20260901'
          AND DataFim = '20260902'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            185,
            1,
            '20260901',
            '20260902',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 01/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 8
          AND DataInicio = '20260901'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            8,
            '20260901',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Licença para tratamento de saúde própria | 01/09/2026 a 22/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 8
          AND DataInicio = '20260901'
          AND DataFim = '20260922'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            8,
            '20260901',
            '20260922',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Licença para tratamento de saúde própria | 01/09/2026 a 11/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 8
          AND DataInicio = '20260901'
          AND DataFim = '20260911'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            8,
            '20260901',
            '20260911',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 03/09/2026 a 12/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 198
          AND TipoAfastamento = 1
          AND DataInicio = '20260903'
          AND DataFim = '20260912'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            198,
            1,
            '20260903',
            '20260912',
            NULL,
            GETDATE()
        );
    END;

    -- Anderson Benevides Valença | SOE IV | Férias | 03/09/2026 a 17/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 205
          AND TipoAfastamento = 1
          AND DataInicio = '20260903'
          AND DataFim = '20260917'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            205,
            1,
            '20260903',
            '20260917',
            NULL,
            GETDATE()
        );
    END;

    -- Sidney da Silva de Oliveira | SOE II | Férias | 05/09/2026 a 15/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 188
          AND TipoAfastamento = 1
          AND DataInicio = '20260905'
          AND DataFim = '20260915'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            188,
            1,
            '20260905',
            '20260915',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Abono de ponto anual | 06/09/2026 a 07/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 2
          AND DataInicio = '20260906'
          AND DataFim = '20260907'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            190,
            2,
            '20260906',
            '20260907',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 08/09/2026 a 13/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20260908'
          AND DataFim = '20260913'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            1,
            '20260908',
            '20260913',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 08/09/2026 a 10/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20260908'
          AND DataFim = '20260910'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            155,
            1,
            '20260908',
            '20260910',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 08/09/2026 a 09/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20260908'
          AND DataFim = '20260909'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            175,
            1,
            '20260908',
            '20260909',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Abono de ponto anual | 10/09/2026 a 11/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 2
          AND DataInicio = '20260910'
          AND DataFim = '20260911'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            193,
            2,
            '20260910',
            '20260911',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 10/09/2026 a 19/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 195
          AND TipoAfastamento = 1
          AND DataInicio = '20260910'
          AND DataFim = '20260919'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            195,
            1,
            '20260910',
            '20260919',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Beltrame Faria | SOT | Abono de ponto anual | 11/09/2026 a 11/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 152
          AND TipoAfastamento = 2
          AND DataInicio = '20260911'
          AND DataFim = '20260911'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            152,
            2,
            '20260911',
            '20260911',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Licença para tratamento de saúde própria | 11/09/2026 a 25/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 8
          AND DataInicio = '20260911'
          AND DataFim = '20260925'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            175,
            8,
            '20260911',
            '20260925',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Roberto Valente Caetano | GAB | Férias | 11/09/2026 a 20/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 206
          AND TipoAfastamento = 1
          AND DataInicio = '20260911'
          AND DataFim = '20260920'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            206,
            1,
            '20260911',
            '20260920',
            NULL,
            GETDATE()
        );
    END;

    -- Wagner Alves Gonçalves Nogueira | SOR | Licença para tratamento de saúde própria | 14/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 150
          AND TipoAfastamento = 8
          AND DataInicio = '20260914'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            150,
            8,
            '20260914',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Licença para tratamento de saúde própria | 14/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 8
          AND DataInicio = '20260914'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            8,
            '20260914',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Abono de ponto anual | 17/09/2026 a 18/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 2
          AND DataInicio = '20260917'
          AND DataFim = '20260918'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            216,
            2,
            '20260917',
            '20260918',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Abono de ponto anual | 18/09/2026 a 19/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 2
          AND DataInicio = '20260918'
          AND DataFim = '20260919'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            191,
            2,
            '20260918',
            '20260919',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 20/09/2026 a 29/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20260920'
          AND DataFim = '20260929'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            179,
            1,
            '20260920',
            '20260929',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 21/09/2026 a 22/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 1
          AND DataInicio = '20260921'
          AND DataFim = '20260922'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            157,
            1,
            '20260921',
            '20260922',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Férias | 22/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 1
          AND DataInicio = '20260922'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            191,
            1,
            '20260922',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Férias | 23/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 1
          AND DataInicio = '20260923'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            1,
            '20260923',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Max Macedo Cavalcante | SOE II | Abono de ponto anual | 24/09/2026 a 26/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 220
          AND TipoAfastamento = 2
          AND DataInicio = '20260924'
          AND DataFim = '20260926'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            220,
            2,
            '20260924',
            '20260926',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Jogos Policiais | 28/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 13
          AND DataInicio = '20260928'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            13,
            '20260928',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Santilhento Marcos da Silva | SOR | Férias | 28/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 147
          AND TipoAfastamento = 1
          AND DataInicio = '20260928'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            147,
            1,
            '20260928',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Abono de ponto anual | 28/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 2
          AND DataInicio = '20260928'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            175,
            2,
            '20260928',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Honney Cordeiro | SOE II | Jogos Policiais | 28/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 181
          AND TipoAfastamento = 13
          AND DataInicio = '20260928'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            181,
            13,
            '20260928',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Max Macedo Cavalcante | SOE II | Abono de ponto anual | 29/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 220
          AND TipoAfastamento = 2
          AND DataInicio = '20260929'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            220,
            2,
            '20260929',
            '20260930',
            NULL,
            GETDATE()
        );
    END;

    -- Rafaela Lopes Andrade | SOC | Férias | 30/09/2026 a 30/09/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 1
          AND DataInicio = '20260930'
          AND DataFim = '20260930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            168,
            1,
            '20260930',
            '20260930',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Outubro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 10/2026
-- Fonte: OUT 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 48
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Leandro de Oliveira Sampaio | GAB | Licença para tratamento de saúde própria | 01/10/2026 a 01/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 8
          AND DataInicio = '20261001'
          AND DataFim = '20261001'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            132,
            8,
            '20261001',
            '20261001',
            NULL,
            GETDATE()
        );
    END;

    -- Santilhento Marcos da Silva | SOR | Férias | 01/10/2026 a 12/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 147
          AND TipoAfastamento = 1
          AND DataInicio = '20261001'
          AND DataFim = '20261012'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            147,
            1,
            '20261001',
            '20261012',
            NULL,
            GETDATE()
        );
    END;

    -- Wagner Alves Gonçalves Nogueira | SOR | Licença para tratamento de saúde própria | 01/10/2026 a 01/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 150
          AND TipoAfastamento = 8
          AND DataInicio = '20261001'
          AND DataFim = '20261001'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            150,
            8,
            '20261001',
            '20261001',
            NULL,
            GETDATE()
        );
    END;

    -- Rafaela Lopes Andrade | SOC | Férias | 01/10/2026 a 09/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 1
          AND DataInicio = '20261001'
          AND DataFim = '20261009'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            168,
            1,
            '20261001',
            '20261009',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Licença para tratamento de saúde própria | 01/10/2026 a 03/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 8
          AND DataInicio = '20261001'
          AND DataFim = '20261003'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            180,
            8,
            '20261001',
            '20261003',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 01/10/2026 a 31/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 8
          AND DataInicio = '20261001'
          AND DataFim = '20261031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            8,
            '20261001',
            '20261031',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Férias | 01/10/2026 a 01/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 1
          AND DataInicio = '20261001'
          AND DataFim = '20261001'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            191,
            1,
            '20261001',
            '20261001',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Férias | 01/10/2026 a 12/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 1
          AND DataInicio = '20261001'
          AND DataFim = '20261012'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            203,
            1,
            '20261001',
            '20261012',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Licença para tratamento de saúde própria | 01/10/2026 a 13/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 8
          AND DataInicio = '20261001'
          AND DataFim = '20261013'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            8,
            '20261001',
            '20261013',
            NULL,
            GETDATE()
        );
    END;

    -- Leandro de Oliveira Sampaio | GAB | Férias | 02/10/2026 a 11/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 1
          AND DataInicio = '20261002'
          AND DataFim = '20261011'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            132,
            1,
            '20261002',
            '20261011',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Abono de ponto anual | 02/10/2026 a 04/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 2
          AND DataInicio = '20261002'
          AND DataFim = '20261004'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            179,
            2,
            '20261002',
            '20261004',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Férias | 04/10/2026 a 23/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 1
          AND DataInicio = '20261004'
          AND DataFim = '20261023'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            180,
            1,
            '20261004',
            '20261023',
            NULL,
            GETDATE()
        );
    END;

    -- Paulo Roberto Tavares Brandão | GAB | Abono de ponto anual | 05/10/2026 a 09/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 131
          AND TipoAfastamento = 2
          AND DataInicio = '20261005'
          AND DataFim = '20261009'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            131,
            2,
            '20261005',
            '20261009',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Férias | 05/10/2026 a 14/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 1
          AND DataInicio = '20261005'
          AND DataFim = '20261014'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            135,
            1,
            '20261005',
            '20261014',
            NULL,
            GETDATE()
        );
    END;

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 05/10/2026 a 14/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 136
          AND TipoAfastamento = 1
          AND DataInicio = '20261005'
          AND DataFim = '20261014'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            136,
            1,
            '20261005',
            '20261014',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Abono de ponto anual | 05/10/2026 a 09/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 2
          AND DataInicio = '20261005'
          AND DataFim = '20261009'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            139,
            2,
            '20261005',
            '20261009',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Abono de ponto anual | 05/10/2026 a 08/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 2
          AND DataInicio = '20261005'
          AND DataFim = '20261008'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            146,
            2,
            '20261005',
            '20261008',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Férias | 05/10/2026 a 14/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 1
          AND DataInicio = '20261005'
          AND DataFim = '20261014'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            1,
            '20261005',
            '20261014',
            NULL,
            GETDATE()
        );
    END;

    -- Sanlac Machado da Cunha | SOC | Férias | 06/10/2026 a 15/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 162
          AND TipoAfastamento = 1
          AND DataInicio = '20261006'
          AND DataFim = '20261015'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            162,
            1,
            '20261006',
            '20261015',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Abono de ponto anual | 06/10/2026 a 07/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 2
          AND DataInicio = '20261006'
          AND DataFim = '20261007'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            175,
            2,
            '20261006',
            '20261007',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Abono de ponto anual | 08/10/2026 a 09/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 2
          AND DataInicio = '20261008'
          AND DataFim = '20261009'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            2,
            '20261008',
            '20261009',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Abono de ponto anual | 10/10/2026 a 13/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 2
          AND DataInicio = '20261010'
          AND DataFim = '20261013'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            212,
            2,
            '20261010',
            '20261013',
            NULL,
            GETDATE()
        );
    END;

    -- Franthiesco L. Fernandes Nunes | SOE III | Férias | 12/10/2026 a 26/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 194
          AND TipoAfastamento = 1
          AND DataInicio = '20261012'
          AND DataFim = '20261026'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            194,
            1,
            '20261012',
            '20261026',
            NULL,
            GETDATE()
        );
    END;

    -- Leandro de Oliveira Sampaio | GAB | Férias | 13/10/2026 a 22/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 1
          AND DataInicio = '20261013'
          AND DataFim = '20261022'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            132,
            1,
            '20261013',
            '20261022',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Abono de ponto anual | 13/10/2026 a 13/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 2
          AND DataInicio = '20261013'
          AND DataFim = '20261013'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            2,
            '20261013',
            '20261013',
            NULL,
            GETDATE()
        );
    END;

    -- Wagner Alves Gonçalves Nogueira | SOR | Abono de aniversário | 13/10/2026 a 13/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 150
          AND TipoAfastamento = 3
          AND DataInicio = '20261013'
          AND DataFim = '20261013'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            150,
            3,
            '20261013',
            '20261013',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 13/10/2026 a 16/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20261013'
          AND DataFim = '20261016'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            1,
            '20261013',
            '20261016',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 13/10/2026 a 30/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 1
          AND DataInicio = '20261013'
          AND DataFim = '20261030'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            157,
            1,
            '20261013',
            '20261030',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 13/10/2026 a 22/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 1
          AND DataInicio = '20261013'
          AND DataFim = '20261022'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            166,
            1,
            '20261013',
            '20261022',
            NULL,
            GETDATE()
        );
    END;

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 14/10/2026 a 28/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 150
          AND TipoAfastamento = 1
          AND DataInicio = '20261014'
          AND DataFim = '20261028'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            150,
            1,
            '20261014',
            '20261028',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Thomas | GAB | Férias | 14/10/2026 a 23/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 173
          AND TipoAfastamento = 1
          AND DataInicio = '20261014'
          AND DataFim = '20261023'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            173,
            1,
            '20261014',
            '20261023',
            NULL,
            GETDATE()
        );
    END;

    -- Ananias Batista Gomes Junior | GAB | Férias | 14/10/2026 a 23/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 215
          AND TipoAfastamento = 1
          AND DataInicio = '20261014'
          AND DataFim = '20261023'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            215,
            1,
            '20261014',
            '20261023',
            NULL,
            GETDATE()
        );
    END;

    -- Tilia Rumi Okahara | SAAEI | Férias | 14/10/2026 a 23/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 221
          AND TipoAfastamento = 1
          AND DataInicio = '20261014'
          AND DataFim = '20261023'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            221,
            1,
            '20261014',
            '20261023',
            NULL,
            GETDATE()
        );
    END;

    -- Edson Medina de Oliveira | GAB | Férias | 19/10/2026 a 28/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 1
          AND DataInicio = '20261019'
          AND DataFim = '20261028'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            130,
            1,
            '20261019',
            '20261028',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 19/10/2026 a 28/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 1
          AND DataInicio = '20261019'
          AND DataFim = '20261028'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            153,
            1,
            '20261019',
            '20261028',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Férias | 19/10/2026 a 28/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 1
          AND DataInicio = '20261019'
          AND DataFim = '20261028'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            159,
            1,
            '20261019',
            '20261028',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Jogos Policiais | 20/10/2026 a 22/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 13
          AND DataInicio = '20261020'
          AND DataFim = '20261022'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            13,
            '20261020',
            '20261022',
            NULL,
            GETDATE()
        );
    END;

    -- Gabriel Arana da Silva | SOE III | Férias | 20/10/2026 a 29/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 196
          AND TipoAfastamento = 1
          AND DataInicio = '20261020'
          AND DataFim = '20261029'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            196,
            1,
            '20261020',
            '20261029',
            NULL,
            GETDATE()
        );
    END;

    -- Honney Cordeiro | SOE II | Abono de ponto anual | 23/10/2026 a 24/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 181
          AND TipoAfastamento = 2
          AND DataInicio = '20261023'
          AND DataFim = '20261024'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            181,
            2,
            '20261023',
            '20261024',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Jardim de Gusmão | SOE IV | Abono de ponto anual | 25/10/2026 a 27/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 198
          AND TipoAfastamento = 2
          AND DataInicio = '20261025'
          AND DataFim = '20261027'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            198,
            2,
            '20261025',
            '20261027',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 26/10/2026 a 31/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20261026'
          AND DataFim = '20261031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            155,
            1,
            '20261026',
            '20261031',
            NULL,
            GETDATE()
        );
    END;

    -- Pericles M. de Rezende Junior | SOT | Abono de ponto anual | 26/10/2026 a 27/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 156
          AND TipoAfastamento = 2
          AND DataInicio = '20261026'
          AND DataFim = '20261027'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            156,
            2,
            '20261026',
            '20261027',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 26/10/2026 a 31/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20261026'
          AND DataFim = '20261031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            179,
            1,
            '20261026',
            '20261031',
            NULL,
            GETDATE()
        );
    END;

    -- Max Macedo Cavalcante | SOE II | Férias | 27/10/2026 a 31/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 220
          AND TipoAfastamento = 1
          AND DataInicio = '20261027'
          AND DataFim = '20261031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            220,
            1,
            '20261027',
            '20261031',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 28/10/2026 a 29/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20261028'
          AND DataFim = '20261029'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            142,
            1,
            '20261028',
            '20261029',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 28/10/2026 a 31/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 195
          AND TipoAfastamento = 1
          AND DataInicio = '20261028'
          AND DataFim = '20261031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            195,
            1,
            '20261028',
            '20261031',
            NULL,
            GETDATE()
        );
    END;

    -- Pericles M. de Rezende Junior | SOT | Abono de ponto anual | 29/10/2026 a 30/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 156
          AND TipoAfastamento = 2
          AND DataInicio = '20261029'
          AND DataFim = '20261030'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            156,
            2,
            '20261029',
            '20261030',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 29/10/2026 a 31/10/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 1
          AND DataInicio = '20261029'
          AND DataFim = '20261031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            1,
            '20261029',
            '20261031',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Novembro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 11/2026
-- Fonte: NOV 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 47
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 01/11/2026 a 01/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20261101'
          AND DataFim = '20261101'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            155,
            1,
            '20261101',
            '20261101',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | GAB | Férias | 01/11/2026 a 10/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20261101'
          AND DataFim = '20261110'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            1,
            '20261101',
            '20261110',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 01/11/2026 a 04/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20261101'
          AND DataFim = '20261104'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            179,
            1,
            '20261101',
            '20261104',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 01/11/2026 a 25/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 8
          AND DataInicio = '20261101'
          AND DataFim = '20261125'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            8,
            '20261101',
            '20261125',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Férias | 01/11/2026 a 10/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 1
          AND DataInicio = '20261101'
          AND DataFim = '20261110'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            190,
            1,
            '20261101',
            '20261110',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 01/11/2026 a 06/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 195
          AND TipoAfastamento = 1
          AND DataInicio = '20261101'
          AND DataFim = '20261106'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            195,
            1,
            '20261101',
            '20261106',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 01/11/2026 a 07/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 1
          AND DataInicio = '20261101'
          AND DataFim = '20261107'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            204,
            1,
            '20261101',
            '20261107',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Férias | 01/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 1
          AND DataInicio = '20261101'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            212,
            1,
            '20261101',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Max Macedo Cavalcante | SOE II | Férias | 01/11/2026 a 10/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 220
          AND TipoAfastamento = 1
          AND DataInicio = '20261101'
          AND DataFim = '20261110'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            220,
            1,
            '20261101',
            '20261110',
            NULL,
            GETDATE()
        );
    END;

    -- Vanderlei Ferreira Dutra | SOE IV | Abono de ponto anual | 02/11/2026 a 06/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 184
          AND TipoAfastamento = 2
          AND DataInicio = '20261102'
          AND DataFim = '20261106'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            184,
            2,
            '20261102',
            '20261106',
            NULL,
            GETDATE()
        );
    END;

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 03/11/2026 a 12/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 131
          AND TipoAfastamento = 1
          AND DataInicio = '20261103'
          AND DataFim = '20261112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            131,
            1,
            '20261103',
            '20261112',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Abono de ponto anual | 03/11/2026 a 06/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 2
          AND DataInicio = '20261103'
          AND DataFim = '20261106'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            142,
            2,
            '20261103',
            '20261106',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Férias | 03/11/2026 a 12/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 1
          AND DataInicio = '20261103'
          AND DataFim = '20261112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            143,
            1,
            '20261103',
            '20261112',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 03/11/2026 a 12/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 1
          AND DataInicio = '20261103'
          AND DataFim = '20261112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            145,
            1,
            '20261103',
            '20261112',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Beltrame Faria | SOT | Férias | 03/11/2026 a 12/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 152
          AND TipoAfastamento = 1
          AND DataInicio = '20261103'
          AND DataFim = '20261112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            152,
            1,
            '20261103',
            '20261112',
            NULL,
            GETDATE()
        );
    END;

    -- Aurelio Gleria Cavalcante | SOC | Férias | 03/11/2026 a 17/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 169
          AND TipoAfastamento = 1
          AND DataInicio = '20261103'
          AND DataFim = '20261117'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            169,
            1,
            '20261103',
            '20261117',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Férias | 03/11/2026 a 12/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 1
          AND DataInicio = '20261103'
          AND DataFim = '20261112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            178,
            1,
            '20261103',
            '20261112',
            NULL,
            GETDATE()
        );
    END;

    -- Rebeca Severo Limongi | SAAEI | Férias | 03/11/2026 a 17/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 223
          AND TipoAfastamento = 1
          AND DataInicio = '20261103'
          AND DataFim = '20261117'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            223,
            1,
            '20261103',
            '20261117',
            NULL,
            GETDATE()
        );
    END;

    -- Ruy Lins Wanderley Neto | SOT | Férias | 03/11/2026 a 12/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 224
          AND TipoAfastamento = 1
          AND DataInicio = '20261103'
          AND DataFim = '20261112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            224,
            1,
            '20261103',
            '20261112',
            NULL,
            GETDATE()
        );
    END;

    -- Adenauer Dantas Justo | SI | Férias | 04/11/2026 a 13/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 138
          AND TipoAfastamento = 1
          AND DataInicio = '20261104'
          AND DataFim = '20261113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            138,
            1,
            '20261104',
            '20261113',
            NULL,
            GETDATE()
        );
    END;

    -- Sidney da Silva de Oliveira | SOE II | Férias | 04/11/2026 a 18/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 188
          AND TipoAfastamento = 1
          AND DataInicio = '20261104'
          AND DataFim = '20261118'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            188,
            1,
            '20261104',
            '20261118',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Chiarelli Linhares Titoneli | SOT | Férias | 09/11/2026 a 28/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 161
          AND TipoAfastamento = 1
          AND DataInicio = '20261109'
          AND DataFim = '20261128'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            161,
            1,
            '20261109',
            '20261128',
            NULL,
            GETDATE()
        );
    END;

    -- Rubens Torres Deolindo | SOE III | Férias | 09/11/2026 a 18/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 192
          AND TipoAfastamento = 1
          AND DataInicio = '20261109'
          AND DataFim = '20261118'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            192,
            1,
            '20261109',
            '20261118',
            NULL,
            GETDATE()
        );
    END;

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 10/11/2026 a 19/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 167
          AND TipoAfastamento = 1
          AND DataInicio = '20261110'
          AND DataFim = '20261119'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            167,
            1,
            '20261110',
            '20261119',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 12/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 1
          AND DataInicio = '20261112'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            1,
            '20261112',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Wanderson Gomes dos Santos | SOE III | Férias | 13/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 197
          AND TipoAfastamento = 1
          AND DataInicio = '20261113'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            197,
            1,
            '20261113',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Lincon Massahiro Takano | SOE IV | Férias | 14/11/2026 a 23/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 200
          AND TipoAfastamento = 1
          AND DataInicio = '20261114'
          AND DataFim = '20261123'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            200,
            1,
            '20261114',
            '20261123',
            NULL,
            GETDATE()
        );
    END;

    -- Silvestre Milhomem Amaral | SI | Férias | 16/11/2026 a 25/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 137
          AND TipoAfastamento = 1
          AND DataInicio = '20261116'
          AND DataFim = '20261125'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            137,
            1,
            '20261116',
            '20261125',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Férias | 16/11/2026 a 25/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 1
          AND DataInicio = '20261116'
          AND DataFim = '20261125'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            146,
            1,
            '20261116',
            '20261125',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 16/11/2026 a 25/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20261116'
          AND DataFim = '20261125'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            155,
            1,
            '20261116',
            '20261125',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Nunes | SOT | Férias | 16/11/2026 a 25/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 158
          AND TipoAfastamento = 1
          AND DataInicio = '20261116'
          AND DataFim = '20261125'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            158,
            1,
            '20261116',
            '20261125',
            NULL,
            GETDATE()
        );
    END;

    -- Honney Cordeiro | SOE II | Abono de ponto anual | 16/11/2026 a 18/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 181
          AND TipoAfastamento = 2
          AND DataInicio = '20261116'
          AND DataFim = '20261118'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            181,
            2,
            '20261116',
            '20261118',
            NULL,
            GETDATE()
        );
    END;

    -- Rebeca Severo Limongi | SAAEI | Abono de ponto anual | 18/11/2026 a 19/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 223
          AND TipoAfastamento = 2
          AND DataInicio = '20261118'
          AND DataFim = '20261119'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            223,
            2,
            '20261118',
            '20261119',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 19/11/2026 a 28/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20261119'
          AND DataFim = '20261128'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            175,
            1,
            '20261119',
            '20261128',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 21/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20261121'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            144,
            1,
            '20261121',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Licença para tratar de interesse particular | 23/11/2026 a 23/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 6
          AND DataInicio = '20261123'
          AND DataFim = '20261123'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            140,
            6,
            '20261123',
            '20261123',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Férias | 23/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20261123'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            1,
            '20261123',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Rebeca Severo Limongi | SAAEI | Abono de ponto anual | 23/11/2026 a 25/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 223
          AND TipoAfastamento = 2
          AND DataInicio = '20261123'
          AND DataFim = '20261125'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            223,
            2,
            '20261123',
            '20261125',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Férias | 24/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 1
          AND DataInicio = '20261124'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            140,
            1,
            '20261124',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 25/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 1
          AND DataInicio = '20261125'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            1,
            '20261125',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 26/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 1
          AND DataInicio = '20261126'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            187,
            1,
            '20261126',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Pereira de Jesus | SOE II | Férias | 28/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 186
          AND TipoAfastamento = 1
          AND DataInicio = '20261128'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            186,
            1,
            '20261128',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 29/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 1
          AND DataInicio = '20261129'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            216,
            1,
            '20261129',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 30/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 1
          AND DataInicio = '20261130'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            139,
            1,
            '20261130',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 30/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20261130'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            1,
            '20261130',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Juliano Dantas Bueno | SOT | Férias | 30/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 154
          AND TipoAfastamento = 1
          AND DataInicio = '20261130'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            154,
            1,
            '20261130',
            '20261130',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 30/11/2026 a 30/11/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 1
          AND DataInicio = '20261130'
          AND DataFim = '20261130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            199,
            1,
            '20261130',
            '20261130',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Dezembro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 12/2026
-- Fonte: DEZ 26 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 25
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 01/12/2026 a 09/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261209'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            139,
            1,
            '20261201',
            '20261209',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Férias | 01/12/2026 a 03/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261203'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            140,
            1,
            '20261201',
            '20261203',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 01/12/2026 a 04/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261204'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            141,
            1,
            '20261201',
            '20261204',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 01/12/2026 a 10/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261210'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            1,
            '20261201',
            '20261210',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Férias | 01/12/2026 a 10/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261210'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            149,
            1,
            '20261201',
            '20261210',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 01/12/2026 a 09/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261209'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            151,
            1,
            '20261201',
            '20261209',
            NULL,
            GETDATE()
        );
    END;

    -- Juliano Dantas Bueno | SOT | Férias | 01/12/2026 a 09/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 154
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261209'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            154,
            1,
            '20261201',
            '20261209',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 01/12/2026 a 10/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261210'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            155,
            1,
            '20261201',
            '20261210',
            NULL,
            GETDATE()
        );
    END;

    -- Cinthia Versiani Pontes | SOC | Férias | 01/12/2026 a 10/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 163
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261210'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            163,
            1,
            '20261201',
            '20261210',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Férias | 01/12/2026 a 02/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261202'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            165,
            1,
            '20261201',
            '20261202',
            NULL,
            GETDATE()
        );
    END;

    -- Eduardo Cosme Carvalho da Silva | SOE I | Férias | 01/12/2026 a 10/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 174
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261210'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            174,
            1,
            '20261201',
            '20261210',
            NULL,
            GETDATE()
        );
    END;

    -- Josué Carvalho da Costa | SOE I | Férias | 01/12/2026 a 10/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261210'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            177,
            1,
            '20261201',
            '20261210',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Pereira de Jesus | SOE II | Férias | 01/12/2026 a 07/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 186
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261207'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            186,
            1,
            '20261201',
            '20261207',
            NULL,
            GETDATE()
        );
    END;

    -- Wanderson Gomes dos Santos | SOE III | Férias | 01/12/2026 a 12/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 197
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261212'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            197,
            1,
            '20261201',
            '20261212',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 01/12/2026 a 09/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261209'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            199,
            1,
            '20261201',
            '20261209',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Roberto Valente Caetano | GAB | Férias | 01/12/2026 a 09/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 206
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261209'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            206,
            1,
            '20261201',
            '20261209',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 01/12/2026 a 08/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261208'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            216,
            1,
            '20261201',
            '20261208',
            NULL,
            GETDATE()
        );
    END;

    -- Tilia Rumi Okahara | SAAEI | Férias | 01/12/2026 a 10/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 221
          AND TipoAfastamento = 1
          AND DataInicio = '20261201'
          AND DataFim = '20261210'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            221,
            1,
            '20261201',
            '20261210',
            NULL,
            GETDATE()
        );
    END;

    -- Thallys Mendes Passos | SOE II | Férias | 06/12/2026 a 31/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 182
          AND TipoAfastamento = 1
          AND DataInicio = '20261206'
          AND DataFim = '20261231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            182,
            1,
            '20261206',
            '20261231',
            NULL,
            GETDATE()
        );
    END;

    -- Francisco Lanna Guillen | SOE II | Abono de ponto anual | 10/12/2026 a 14/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 183
          AND TipoAfastamento = 2
          AND DataInicio = '20261210'
          AND DataFim = '20261214'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            183,
            2,
            '20261210',
            '20261214',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Abono de ponto anual | 11/12/2026 a 11/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 2
          AND DataInicio = '20261211'
          AND DataFim = '20261211'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            2,
            '20261211',
            '20261211',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Lebrão Arruda | SOE IV | Férias | 12/12/2026 a 31/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 201
          AND TipoAfastamento = 1
          AND DataInicio = '20261212'
          AND DataFim = '20261231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            201,
            1,
            '20261212',
            '20261231',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Abono de ponto anual | 14/12/2026 a 15/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 2
          AND DataInicio = '20261214'
          AND DataFim = '20261215'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            2,
            '20261214',
            '20261215',
            NULL,
            GETDATE()
        );
    END;

    -- Renato Bizinoto Molas | SOE I | Férias | 14/12/2026 a 31/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 170
          AND TipoAfastamento = 1
          AND DataInicio = '20261214'
          AND DataFim = '20261231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            170,
            1,
            '20261214',
            '20261231',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Férias | 31/12/2026 a 31/12/2026
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 1
          AND DataInicio = '20261231'
          AND DataFim = '20261231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            212,
            1,
            '20261231',
            '20261231',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Janeiro 2027
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 01/2027
-- Fonte: JAN 27 - PLANILHA AFASTAMENTOS 2026
-- Registros consolidados no mês: 6
-- Script idempotente: não insere combinação já existente.
-- Tipos não mapeados e marcadores VAI ALTERAR não são importados.
-- FELIPE (GAB) foi ignorado conforme orientação.
-- ============================================================

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 01/01/2027 a 10/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 1
          AND DataInicio = '20270101'
          AND DataFim = '20270110'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            148,
            1,
            '20270101',
            '20270110',
            NULL,
            GETDATE()
        );
    END;

    -- Renato Bizinoto Molas | SOE I | Férias | 01/01/2027 a 12/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 170
          AND TipoAfastamento = 1
          AND DataInicio = '20270101'
          AND DataFim = '20270112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            170,
            1,
            '20270101',
            '20270112',
            NULL,
            GETDATE()
        );
    END;

    -- Thallys Mendes Passos | SOE II | Férias | 01/01/2027 a 04/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 182
          AND TipoAfastamento = 1
          AND DataInicio = '20270101'
          AND DataFim = '20270104'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            182,
            1,
            '20270101',
            '20270104',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Lebrão Arruda | SOE IV | Férias | 01/01/2027 a 10/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 201
          AND TipoAfastamento = 1
          AND DataInicio = '20270101'
          AND DataFim = '20270110'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            201,
            1,
            '20270101',
            '20270110',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Férias | 01/01/2027 a 29/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 1
          AND DataInicio = '20270101'
          AND DataFim = '20270129'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            212,
            1,
            '20270101',
            '20270129',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Thomas | GAB | Férias | 04/01/2027 a 31/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 173
          AND TipoAfastamento = 1
          AND DataInicio = '20270104'
          AND DataFim = '20270131'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
            OperadorID,
            TipoAfastamento,
            DataInicio,
            DataFim,
            Observacao,
            DataHoraCriacao
        )
        VALUES
        (
            173,
            1,
            '20270104',
            '20270131',
            NULL,
            GETDATE()
        );
    END;
      ");

    }

    public override void Down()
    {
    }
  }
}
