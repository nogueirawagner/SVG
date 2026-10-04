namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202609011900 : DbMigration
  {
    public override void Up()
    {
      // Janeiro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 01/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 37
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Ananias Batista Gomes Junior | GAB | Férias | 01/01/2027 a 06/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 215
          AND TipoAfastamento = 1
          AND DataInicio = '20270101'
          AND DataFim = '20270106'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270101',
            '20270106',
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

    -- Luiz Cesar Mendes de Almeida | SOE III | Férias | 01/01/2027 a 29/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 189
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
            189,
            1,
            '20270101',
            '20270129',
            NULL,
            GETDATE()
        );
    END;

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

    -- Vanderlei Ferreira Dutra | SOE IV | Férias | 01/01/2027 a 04/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 184
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
            184,
            1,
            '20270101',
            '20270104',
            NULL,
            GETDATE()
        );
    END;

    -- Aurelio Gleria Cavalcante | SOC | Férias | 04/01/2027 a 18/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 169
          AND TipoAfastamento = 1
          AND DataInicio = '20270104'
          AND DataFim = '20270118'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270104',
            '20270118',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 04/01/2027 a 13/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20270104'
          AND DataFim = '20270113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270104',
            '20270113',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Férias | 04/01/2027 a 13/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 1
          AND DataInicio = '20270104'
          AND DataFim = '20270113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270104',
            '20270113',
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

    -- Patricia Araujo Ribeiro | SAAEI | Abono de ponto anual | 04/01/2027 a 04/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 222
          AND TipoAfastamento = 2
          AND DataInicio = '20270104'
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
            222,
            2,
            '20270104',
            '20270104',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 04/01/2027 a 13/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 1
          AND DataInicio = '20270104'
          AND DataFim = '20270113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270104',
            '20270113',
            NULL,
            GETDATE()
        );
    END;

    -- Ruy Lins Wanderley Neto | SOT | Férias | 04/01/2027 a 13/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 224
          AND TipoAfastamento = 1
          AND DataInicio = '20270104'
          AND DataFim = '20270113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270104',
            '20270113',
            NULL,
            GETDATE()
        );
    END;

    -- Silvestre Milhomem Amaral | SI | Férias | 04/01/2027 a 13/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 137
          AND TipoAfastamento = 1
          AND DataInicio = '20270104'
          AND DataFim = '20270113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270104',
            '20270113',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 04/01/2027 a 13/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 1
          AND DataInicio = '20270104'
          AND DataFim = '20270113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270104',
            '20270113',
            NULL,
            GETDATE()
        );
    END;

    -- Diego Madureira Rodrigues | SOE I | Férias | 06/01/2027 a 25/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 171
          AND TipoAfastamento = 1
          AND DataInicio = '20270106'
          AND DataFim = '20270125'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270106',
            '20270125',
            NULL,
            GETDATE()
        );
    END;

    -- Frank Rodrigues Ferreira | SOT | Férias | 11/01/2027 a 20/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 160
          AND TipoAfastamento = 1
          AND DataInicio = '20270111'
          AND DataFim = '20270120'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270111',
            '20270120',
            NULL,
            GETDATE()
        );
    END;

    -- Leandro de Oliveira Sampaio | GAB | Férias | 11/01/2027 a 20/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 1
          AND DataInicio = '20270111'
          AND DataFim = '20270120'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270111',
            '20270120',
            NULL,
            GETDATE()
        );
    END;

    -- Max Macedo Cavalcante | SOE II | Férias | 11/01/2027 a 20/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 220
          AND TipoAfastamento = 1
          AND DataInicio = '20270111'
          AND DataFim = '20270120'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270111',
            '20270120',
            NULL,
            GETDATE()
        );
    END;

    -- Sidney da Silva de Oliveira | SOE II | Férias | 11/01/2027 a 20/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 188
          AND TipoAfastamento = 1
          AND DataInicio = '20270111'
          AND DataFim = '20270120'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270111',
            '20270120',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Lima Aguirra | SOE IV | Férias | 13/01/2027 a 27/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 202
          AND TipoAfastamento = 1
          AND DataInicio = '20270113'
          AND DataFim = '20270127'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270113',
            '20270127',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Férias | 13/01/2027 a 22/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 1
          AND DataInicio = '20270113'
          AND DataFim = '20270122'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270113',
            '20270122',
            NULL,
            GETDATE()
        );
    END;

    -- Josué Carvalho da Costa | SOE I | Férias | 14/01/2027 a 23/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20270114'
          AND DataFim = '20270123'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270114',
            '20270123',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 18/01/2027 a 27/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 1
          AND DataInicio = '20270118'
          AND DataFim = '20270127'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270118',
            '20270127',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Férias | 18/01/2027 a 27/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 1
          AND DataInicio = '20270118'
          AND DataFim = '20270127'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270118',
            '20270127',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Férias | 18/01/2027 a 27/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20270118'
          AND DataFim = '20270127'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270118',
            '20270127',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Férias | 20/01/2027 a 29/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 1
          AND DataInicio = '20270120'
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
            191,
            1,
            '20270120',
            '20270129',
            NULL,
            GETDATE()
        );
    END;

    -- Juliano Dantas Bueno | SOT | Férias | 20/01/2027 a 29/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 154
          AND TipoAfastamento = 1
          AND DataInicio = '20270120'
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
            154,
            1,
            '20270120',
            '20270129',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 25/01/2027 a 31/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 1
          AND DataInicio = '20270125'
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
            204,
            1,
            '20270125',
            '20270131',
            NULL,
            GETDATE()
        );
    END;

    -- Sanlac Machado da Cunha | SOC | Férias | 25/01/2027 a 31/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 162
          AND TipoAfastamento = 1
          AND DataInicio = '20270125'
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
            162,
            1,
            '20270125',
            '20270131',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 26/01/2027 a 31/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20270126'
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
            179,
            1,
            '20270126',
            '20270131',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 27/01/2027 a 31/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20270127'
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
            144,
            1,
            '20270127',
            '20270131',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Férias | 27/01/2027 a 31/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 1
          AND DataInicio = '20270127'
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
            135,
            1,
            '20270127',
            '20270131',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 28/01/2027 a 31/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 1
          AND DataInicio = '20270128'
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
            193,
            1,
            '20270128',
            '20270131',
            NULL,
            GETDATE()
        );
    END;

    -- Anderson Benevides Valença | SOE IV | Férias | 29/01/2027 a 31/01/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 205
          AND TipoAfastamento = 1
          AND DataInicio = '20270129'
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
            205,
            1,
            '20270129',
            '20270131',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Fevereiro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 02/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 16
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Anderson Benevides Valença | SOE IV | Férias | 01/02/2027 a 12/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 205
          AND TipoAfastamento = 1
          AND DataInicio = '20270201'
          AND DataFim = '20270212'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270201',
            '20270212',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 01/02/2027 a 05/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20270201'
          AND DataFim = '20270205'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270201',
            '20270205',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 01/02/2027 a 06/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 1
          AND DataInicio = '20270201'
          AND DataFim = '20270206'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270201',
            '20270206',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Férias | 01/02/2027 a 05/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 1
          AND DataInicio = '20270201'
          AND DataFim = '20270205'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270201',
            '20270205',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 01/02/2027 a 03/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 1
          AND DataInicio = '20270201'
          AND DataFim = '20270203'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270201',
            '20270203',
            NULL,
            GETDATE()
        );
    END;

    -- Sanlac Machado da Cunha | SOC | Férias | 01/02/2027 a 03/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 162
          AND TipoAfastamento = 1
          AND DataInicio = '20270201'
          AND DataFim = '20270203'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270201',
            '20270203',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 01/02/2027 a 04/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20270201'
          AND DataFim = '20270204'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270201',
            '20270204',
            NULL,
            GETDATE()
        );
    END;

    -- Alberto Ganzaroli Neto | SOE II | Férias | 04/02/2027 a 13/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 1
          AND DataInicio = '20270204'
          AND DataFim = '20270213'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270204',
            '20270213',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 04/02/2027 a 13/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 1
          AND DataInicio = '20270204'
          AND DataFim = '20270213'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270204',
            '20270213',
            NULL,
            GETDATE()
        );
    END;

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 08/02/2027 a 17/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 131
          AND TipoAfastamento = 1
          AND DataInicio = '20270208'
          AND DataFim = '20270217'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270208',
            '20270217',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 10/02/2027 a 19/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 1
          AND DataInicio = '20270210'
          AND DataFim = '20270219'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270210',
            '20270219',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 10/02/2027 a 19/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 1
          AND DataInicio = '20270210'
          AND DataFim = '20270219'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270210',
            '20270219',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Nunes | SOT | Férias | 11/02/2027 a 20/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 158
          AND TipoAfastamento = 1
          AND DataInicio = '20270211'
          AND DataFim = '20270220'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270211',
            '20270220',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Férias | 11/02/2027 a 20/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 1
          AND DataInicio = '20270211'
          AND DataFim = '20270220'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270211',
            '20270220',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 15/02/2027 a 24/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 1
          AND DataInicio = '20270215'
          AND DataFim = '20270224'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270215',
            '20270224',
            NULL,
            GETDATE()
        );
    END;

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 15/02/2027 a 24/02/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 136
          AND TipoAfastamento = 1
          AND DataInicio = '20270215'
          AND DataFim = '20270224'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270215',
            '20270224',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Março
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 03/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 9
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Rafaela Lopes Andrade | SOC | Férias | 01/03/2027 a 10/03/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 1
          AND DataInicio = '20270301'
          AND DataFim = '20270310'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270301',
            '20270310',
            NULL,
            GETDATE()
        );
    END;

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 01/03/2027 a 10/03/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 150
          AND TipoAfastamento = 1
          AND DataInicio = '20270301'
          AND DataFim = '20270310'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270301',
            '20270310',
            NULL,
            GETDATE()
        );
    END;

    -- Wanderson Gomes dos Santos | SOE III | Férias | 05/03/2027 a 14/03/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 197
          AND TipoAfastamento = 1
          AND DataInicio = '20270305'
          AND DataFim = '20270314'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270305',
            '20270314',
            NULL,
            GETDATE()
        );
    END;

    -- Rubens Torres Deolindo | SOE III | Férias | 13/03/2027 a 22/03/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 192
          AND TipoAfastamento = 1
          AND DataInicio = '20270313'
          AND DataFim = '20270322'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270313',
            '20270322',
            NULL,
            GETDATE()
        );
    END;

    -- Patricia Araujo Ribeiro | SAAEI | Férias | 15/03/2027 a 24/03/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 222
          AND TipoAfastamento = 1
          AND DataInicio = '20270315'
          AND DataFim = '20270324'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            1,
            '20270315',
            '20270324',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Férias | 15/03/2027 a 24/03/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20270315'
          AND DataFim = '20270324'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270315',
            '20270324',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 16/03/2027 a 25/03/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 1
          AND DataInicio = '20270316'
          AND DataFim = '20270325'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270316',
            '20270325',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | GAB | Férias | 21/03/2027 a 30/03/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20270321'
          AND DataFim = '20270330'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270321',
            '20270330',
            NULL,
            GETDATE()
        );
    END;

    -- Pericles M. de Rezende Junior | SOT | Férias | 31/03/2027 a 31/03/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 156
          AND TipoAfastamento = 1
          AND DataInicio = '20270331'
          AND DataFim = '20270331'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270331',
            '20270331',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Abril
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 04/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 10
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Pericles M. de Rezende Junior | SOT | Férias | 01/04/2027 a 09/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 156
          AND TipoAfastamento = 1
          AND DataInicio = '20270401'
          AND DataFim = '20270409'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270401',
            '20270409',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Beltrame Faria | SOT | Férias | 05/04/2027 a 14/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 152
          AND TipoAfastamento = 1
          AND DataInicio = '20270405'
          AND DataFim = '20270414'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270405',
            '20270414',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 06/04/2027 a 15/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 195
          AND TipoAfastamento = 1
          AND DataInicio = '20270406'
          AND DataFim = '20270415'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270406',
            '20270415',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Férias | 12/04/2027 a 21/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 1
          AND DataInicio = '20270412'
          AND DataFim = '20270421'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270412',
            '20270421',
            NULL,
            GETDATE()
        );
    END;

    -- Ruy Lins Wanderley Neto | SOT | Férias | 14/04/2027 a 23/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 224
          AND TipoAfastamento = 1
          AND DataInicio = '20270414'
          AND DataFim = '20270423'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270414',
            '20270423',
            NULL,
            GETDATE()
        );
    END;

    -- Gabriel Arana da Silva | SOE III | Férias | 18/04/2027 a 27/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 196
          AND TipoAfastamento = 1
          AND DataInicio = '20270418'
          AND DataFim = '20270427'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270418',
            '20270427',
            NULL,
            GETDATE()
        );
    END;

    -- Cinthia Versiani Pontes | SOC | Férias | 19/04/2027 a 30/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 163
          AND TipoAfastamento = 1
          AND DataInicio = '20270419'
          AND DataFim = '20270430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270419',
            '20270430',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Férias | 24/04/2027 a 30/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 1
          AND DataInicio = '20270424'
          AND DataFim = '20270430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270424',
            '20270430',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 26/04/2027 a 30/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20270426'
          AND DataFim = '20270430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270426',
            '20270430',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Férias | 26/04/2027 a 30/04/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 1
          AND DataInicio = '20270426'
          AND DataFim = '20270430'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270426',
            '20270430',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Maio
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 05/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 14
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Cinthia Versiani Pontes | SOC | Férias | 01/05/2027 a 08/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 163
          AND TipoAfastamento = 1
          AND DataInicio = '20270501'
          AND DataFim = '20270508'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270501',
            '20270508',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 01/05/2027 a 05/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20270501'
          AND DataFim = '20270505'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270501',
            '20270505',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Férias | 01/05/2027 a 03/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 1
          AND DataInicio = '20270501'
          AND DataFim = '20270503'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270501',
            '20270503',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Férias | 01/05/2027 a 05/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 1
          AND DataInicio = '20270501'
          AND DataFim = '20270505'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270501',
            '20270505',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 10/05/2027 a 19/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 1
          AND DataInicio = '20270510'
          AND DataFim = '20270519'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270510',
            '20270519',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Férias | 10/05/2027 a 19/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 1
          AND DataInicio = '20270510'
          AND DataFim = '20270519'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270510',
            '20270519',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Férias | 10/05/2027 a 19/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 1
          AND DataInicio = '20270510'
          AND DataFim = '20270519'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270510',
            '20270519',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 17/05/2027 a 26/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 1
          AND DataInicio = '20270517'
          AND DataFim = '20270526'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270517',
            '20270526',
            NULL,
            GETDATE()
        );
    END;

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 17/05/2027 a 26/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 167
          AND TipoAfastamento = 1
          AND DataInicio = '20270517'
          AND DataFim = '20270526'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270517',
            '20270526',
            NULL,
            GETDATE()
        );
    END;

    -- Juliano Dantas Bueno | SOT | Férias | 19/05/2027 a 28/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 154
          AND TipoAfastamento = 1
          AND DataInicio = '20270519'
          AND DataFim = '20270528'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270519',
            '20270528',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Férias | 26/05/2027 a 31/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 1
          AND DataInicio = '20270526'
          AND DataFim = '20270531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270526',
            '20270531',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 31/05/2027 a 31/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20270531'
          AND DataFim = '20270531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270531',
            '20270531',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 31/05/2027 a 31/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 1
          AND DataInicio = '20270531'
          AND DataFim = '20270531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270531',
            '20270531',
            NULL,
            GETDATE()
        );
    END;

    -- Santilhento Marcos da Silva | SOR | Férias | 31/05/2027 a 31/05/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 147
          AND TipoAfastamento = 1
          AND DataInicio = '20270531'
          AND DataFim = '20270531'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270531',
            '20270531',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Junho
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 06/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 9
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 01/06/2027 a 09/06/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20270601'
          AND DataFim = '20270609'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270601',
            '20270609',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Férias | 01/06/2027 a 04/06/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 1
          AND DataInicio = '20270601'
          AND DataFim = '20270604'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270601',
            '20270604',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 01/06/2027 a 09/06/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 1
          AND DataInicio = '20270601'
          AND DataFim = '20270609'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270601',
            '20270609',
            NULL,
            GETDATE()
        );
    END;

    -- Rubens Torres Deolindo | SOE III | Férias | 01/06/2027 a 10/06/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 192
          AND TipoAfastamento = 1
          AND DataInicio = '20270601'
          AND DataFim = '20270610'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270601',
            '20270610',
            NULL,
            GETDATE()
        );
    END;

    -- Santilhento Marcos da Silva | SOR | Férias | 01/06/2027 a 14/06/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 147
          AND TipoAfastamento = 1
          AND DataInicio = '20270601'
          AND DataFim = '20270614'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270601',
            '20270614',
            NULL,
            GETDATE()
        );
    END;

    -- Wanderson Gomes dos Santos | SOE III | Férias | 09/06/2027 a 18/06/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 197
          AND TipoAfastamento = 1
          AND DataInicio = '20270609'
          AND DataFim = '20270618'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270609',
            '20270618',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 23/06/2027 a 30/06/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20270623'
          AND DataFim = '20270630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270623',
            '20270630',
            NULL,
            GETDATE()
        );
    END;

    -- Sidney da Silva de Oliveira | SOE II | Férias | 28/06/2027 a 30/06/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 188
          AND TipoAfastamento = 1
          AND DataInicio = '20270628'
          AND DataFim = '20270630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270628',
            '20270630',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 30/06/2027 a 30/06/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20270630'
          AND DataFim = '20270630'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270630',
            '20270630',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Julho
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 07/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 29
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Antonio Jose Lima | GAB | Férias | 01/07/2027 a 30/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 1
          AND DataInicio = '20270701'
          AND DataFim = '20270730'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270701',
            '20270730',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 01/07/2027 a 09/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20270701'
          AND DataFim = '20270709'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270701',
            '20270709',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 01/07/2027 a 02/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20270701'
          AND DataFim = '20270702'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270701',
            '20270702',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 01/07/2027 a 10/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20270701'
          AND DataFim = '20270710'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270701',
            '20270710',
            NULL,
            GETDATE()
        );
    END;

    -- Sidney da Silva de Oliveira | SOE II | Férias | 01/07/2027 a 07/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 188
          AND TipoAfastamento = 1
          AND DataInicio = '20270701'
          AND DataFim = '20270707'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270701',
            '20270707',
            NULL,
            GETDATE()
        );
    END;

    -- Adenauer Dantas Justo da SI | SI | Férias | 05/07/2027 a 19/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 138
          AND TipoAfastamento = 1
          AND DataInicio = '20270705'
          AND DataFim = '20270719'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270705',
            '20270719',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 05/07/2027 a 14/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 1
          AND DataInicio = '20270705'
          AND DataFim = '20270714'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270705',
            '20270714',
            NULL,
            GETDATE()
        );
    END;

    -- Max Macedo Cavalcante | SOE II | Férias | 06/07/2027 a 15/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 220
          AND TipoAfastamento = 1
          AND DataInicio = '20270706'
          AND DataFim = '20270715'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270706',
            '20270715',
            NULL,
            GETDATE()
        );
    END;

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 07/07/2027 a 16/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 167
          AND TipoAfastamento = 1
          AND DataInicio = '20270707'
          AND DataFim = '20270716'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270707',
            '20270716',
            NULL,
            GETDATE()
        );
    END;

    -- Frank Rodrigues Ferreira | SOT | Férias | 12/07/2027 a 21/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 160
          AND TipoAfastamento = 1
          AND DataInicio = '20270712'
          AND DataFim = '20270721'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270712',
            '20270721',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 12/07/2027 a 21/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20270712'
          AND DataFim = '20270721'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270712',
            '20270721',
            NULL,
            GETDATE()
        );
    END;

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 12/07/2027 a 21/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 136
          AND TipoAfastamento = 1
          AND DataInicio = '20270712'
          AND DataFim = '20270721'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270712',
            '20270721',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Férias | 12/07/2027 a 21/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 1
          AND DataInicio = '20270712'
          AND DataFim = '20270721'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270712',
            '20270721',
            NULL,
            GETDATE()
        );
    END;

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 12/07/2027 a 21/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 131
          AND TipoAfastamento = 1
          AND DataInicio = '20270712'
          AND DataFim = '20270721'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270712',
            '20270721',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Férias | 12/07/2027 a 21/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 1
          AND DataInicio = '20270712'
          AND DataFim = '20270721'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270712',
            '20270721',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 12/07/2027 a 21/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 1
          AND DataInicio = '20270712'
          AND DataFim = '20270721'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270712',
            '20270721',
            NULL,
            GETDATE()
        );
    END;

    -- Diego Madureira Rodrigues | SOE I | Férias | 13/07/2027 a 22/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 171
          AND TipoAfastamento = 1
          AND DataInicio = '20270713'
          AND DataFim = '20270722'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270713',
            '20270722',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | GAB | Férias | 14/07/2027 a 23/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20270714'
          AND DataFim = '20270723'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270714',
            '20270723',
            NULL,
            GETDATE()
        );
    END;

    -- Leandro de Oliveira Sampaio | GAB | Férias | 15/07/2027 a 24/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 1
          AND DataInicio = '20270715'
          AND DataFim = '20270724'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270715',
            '20270724',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 19/07/2027 a 28/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 1
          AND DataInicio = '20270719'
          AND DataFim = '20270728'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270719',
            '20270728',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Férias | 19/07/2027 a 28/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 1
          AND DataInicio = '20270719'
          AND DataFim = '20270728'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270719',
            '20270728',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Férias | 19/07/2027 a 28/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 1
          AND DataInicio = '20270719'
          AND DataFim = '20270728'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270719',
            '20270728',
            NULL,
            GETDATE()
        );
    END;

    -- Pericles M. de Rezende Junior | SOT | Férias | 19/07/2027 a 28/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 156
          AND TipoAfastamento = 1
          AND DataInicio = '20270719'
          AND DataFim = '20270728'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270719',
            '20270728',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 20/07/2027 a 29/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 1
          AND DataInicio = '20270720'
          AND DataFim = '20270729'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270720',
            '20270729',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Férias | 20/07/2027 a 29/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 1
          AND DataInicio = '20270720'
          AND DataFim = '20270729'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270720',
            '20270729',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Férias | 20/07/2027 a 29/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 1
          AND DataInicio = '20270720'
          AND DataFim = '20270729'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270720',
            '20270729',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 23/07/2027 a 31/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 1
          AND DataInicio = '20270723'
          AND DataFim = '20270731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270723',
            '20270731',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 26/07/2027 a 31/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20270726'
          AND DataFim = '20270731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270726',
            '20270731',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 30/07/2027 a 31/07/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 1
          AND DataInicio = '20270730'
          AND DataFim = '20270731'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270730',
            '20270731',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Agosto
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 08/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 15
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Anderson Benevides Valença | SOE IV | Férias | 01/08/2027 a 15/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 205
          AND TipoAfastamento = 1
          AND DataInicio = '20270801'
          AND DataFim = '20270815'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270801',
            '20270815',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 01/08/2027 a 01/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 1
          AND DataInicio = '20270801'
          AND DataFim = '20270801'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270801',
            '20270801',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 01/08/2027 a 04/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20270801'
          AND DataFim = '20270804'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270801',
            '20270804',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 01/08/2027 a 08/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 1
          AND DataInicio = '20270801'
          AND DataFim = '20270808'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270801',
            '20270808',
            NULL,
            GETDATE()
        );
    END;

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 03/08/2027 a 12/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 150
          AND TipoAfastamento = 1
          AND DataInicio = '20270803'
          AND DataFim = '20270812'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270803',
            '20270812',
            NULL,
            GETDATE()
        );
    END;

    -- Gabriel Arana da Silva | SOE III | Férias | 04/08/2027 a 13/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 196
          AND TipoAfastamento = 1
          AND DataInicio = '20270804'
          AND DataFim = '20270813'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270804',
            '20270813',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 05/08/2027 a 14/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 1
          AND DataInicio = '20270805'
          AND DataFim = '20270814'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270805',
            '20270814',
            NULL,
            GETDATE()
        );
    END;

    -- Sidartha Souza de Quevedo | SOE I | Férias | 06/08/2027 a 15/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 179
          AND TipoAfastamento = 1
          AND DataInicio = '20270806'
          AND DataFim = '20270815'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270806',
            '20270815',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Beltrame Faria | SOT | Férias | 09/08/2027 a 18/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 152
          AND TipoAfastamento = 1
          AND DataInicio = '20270809'
          AND DataFim = '20270818'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270809',
            '20270818',
            NULL,
            GETDATE()
        );
    END;

    -- Silvestre Milhomem Amaral | SI | Férias | 09/08/2027 a 18/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 137
          AND TipoAfastamento = 1
          AND DataInicio = '20270809'
          AND DataFim = '20270818'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270809',
            '20270818',
            NULL,
            GETDATE()
        );
    END;

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 16/08/2027 a 25/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 145
          AND TipoAfastamento = 1
          AND DataInicio = '20270816'
          AND DataFim = '20270825'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270816',
            '20270825',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Férias | 16/08/2027 a 25/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 1
          AND DataInicio = '20270816'
          AND DataFim = '20270825'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270816',
            '20270825',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 22/08/2027 a 31/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20270822'
          AND DataFim = '20270831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270822',
            '20270831',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 23/08/2027 a 31/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20270823'
          AND DataFim = '20270831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270823',
            '20270831',
            NULL,
            GETDATE()
        );
    END;

    -- Rafaela Lopes Andrade | SOC | Férias | 23/08/2027 a 31/08/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 1
          AND DataInicio = '20270823'
          AND DataFim = '20270831'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270823',
            '20270831',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Setembro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 09/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 14
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Alberto Ganzaroli Neto | SOE II | Férias | 01/09/2027 a 10/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 1
          AND DataInicio = '20270901'
          AND DataFim = '20270910'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270901',
            '20270910',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 01/09/2027 a 01/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20270901'
          AND DataFim = '20270901'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270901',
            '20270901',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Férias | 01/09/2027 a 10/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 1
          AND DataInicio = '20270901'
          AND DataFim = '20270910'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270901',
            '20270910',
            NULL,
            GETDATE()
        );
    END;

    -- Honney Cordeiro | SOE II | Férias | 01/09/2027 a 30/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 181
          AND TipoAfastamento = 1
          AND DataInicio = '20270901'
          AND DataFim = '20270930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270901',
            '20270930',
            NULL,
            GETDATE()
        );
    END;

    -- Rafaela Lopes Andrade | SOC | Férias | 01/09/2027 a 01/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 1
          AND DataInicio = '20270901'
          AND DataFim = '20270901'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270901',
            '20270901',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Férias | 03/09/2027 a 12/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 1
          AND DataInicio = '20270903'
          AND DataFim = '20270912'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270903',
            '20270912',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 08/09/2027 a 17/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 1
          AND DataInicio = '20270908'
          AND DataFim = '20270917'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270908',
            '20270917',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Férias | 11/09/2027 a 17/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 1
          AND DataInicio = '20270911'
          AND DataFim = '20270917'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270911',
            '20270917',
            NULL,
            GETDATE()
        );
    END;

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 13/09/2027 a 22/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 193
          AND TipoAfastamento = 1
          AND DataInicio = '20270913'
          AND DataFim = '20270922'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270913',
            '20270922',
            NULL,
            GETDATE()
        );
    END;

    -- Sanlac Machado da Cunha | SOC | Férias | 13/09/2027 a 22/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 162
          AND TipoAfastamento = 1
          AND DataInicio = '20270913'
          AND DataFim = '20270922'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270913',
            '20270922',
            NULL,
            GETDATE()
        );
    END;

    -- Rebeca Severo Limongi | SAAEI | Férias | 14/09/2027 a 23/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 223
          AND TipoAfastamento = 1
          AND DataInicio = '20270914'
          AND DataFim = '20270923'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270914',
            '20270923',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 25/09/2027 a 30/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 195
          AND TipoAfastamento = 1
          AND DataInicio = '20270925'
          AND DataFim = '20270930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270925',
            '20270930',
            NULL,
            GETDATE()
        );
    END;

    -- Josué Carvalho da Costa | SOE I | Férias | 27/09/2027 a 30/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20270927'
          AND DataFim = '20270930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270927',
            '20270930',
            NULL,
            GETDATE()
        );
    END;

    -- Rafaela Lopes Andrade | SOC | Férias | 29/09/2027 a 30/09/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 1
          AND DataInicio = '20270929'
          AND DataFim = '20270930'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20270929',
            '20270930',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Outubro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 10/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 26
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Josué Carvalho da Costa | SOE I | Férias | 01/10/2027 a 06/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20271001'
          AND DataFim = '20271006'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271001',
            '20271006',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 01/10/2027 a 04/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 195
          AND TipoAfastamento = 1
          AND DataInicio = '20271001'
          AND DataFim = '20271004'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271001',
            '20271004',
            NULL,
            GETDATE()
        );
    END;

    -- Rafaela Lopes Andrade | SOC | Férias | 01/10/2027 a 08/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 168
          AND TipoAfastamento = 1
          AND DataInicio = '20271001'
          AND DataFim = '20271008'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271001',
            '20271008',
            NULL,
            GETDATE()
        );
    END;

    -- Santilhento Marcos da Silva | SOR | Férias | 04/10/2027 a 18/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 147
          AND TipoAfastamento = 1
          AND DataInicio = '20271004'
          AND DataFim = '20271018'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271004',
            '20271018',
            NULL,
            GETDATE()
        );
    END;

    -- Tiago Resende Brant | SOT | Férias | 04/10/2027 a 13/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 159
          AND TipoAfastamento = 1
          AND DataInicio = '20271004'
          AND DataFim = '20271013'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271004',
            '20271013',
            NULL,
            GETDATE()
        );
    END;

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 05/10/2027 a 14/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 141
          AND TipoAfastamento = 1
          AND DataInicio = '20271005'
          AND DataFim = '20271014'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271005',
            '20271014',
            NULL,
            GETDATE()
        );
    END;

    -- Luis Ricardo Brasilino | SOE I | Férias | 09/10/2027 a 18/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 178
          AND TipoAfastamento = 1
          AND DataInicio = '20271009'
          AND DataFim = '20271018'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271009',
            '20271018',
            NULL,
            GETDATE()
        );
    END;

    -- Sidney da Silva de Oliveira | SOE II | Férias | 10/10/2027 a 19/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 188
          AND TipoAfastamento = 1
          AND DataInicio = '20271010'
          AND DataFim = '20271019'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271010',
            '20271019',
            NULL,
            GETDATE()
        );
    END;

    -- Klebson Alves Fonseca | SOE III | Férias | 11/10/2027 a 20/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 190
          AND TipoAfastamento = 1
          AND DataInicio = '20271011'
          AND DataFim = '20271020'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271011',
            '20271020',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | GAB | Férias | 12/10/2027 a 21/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20271012'
          AND DataFim = '20271021'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271012',
            '20271021',
            NULL,
            GETDATE()
        );
    END;

    -- Frank Rodrigues Ferreira | SOT | Férias | 13/10/2027 a 22/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 160
          AND TipoAfastamento = 1
          AND DataInicio = '20271013'
          AND DataFim = '20271022'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271013',
            '20271022',
            NULL,
            GETDATE()
        );
    END;

    -- Leandro de Oliveira Sampaio | GAB | Férias | 13/10/2027 a 22/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 132
          AND TipoAfastamento = 1
          AND DataInicio = '20271013'
          AND DataFim = '20271022'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271013',
            '20271022',
            NULL,
            GETDATE()
        );
    END;

    -- Ricardo Santos Textor | SOC | Férias | 13/10/2027 a 22/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 165
          AND TipoAfastamento = 1
          AND DataInicio = '20271013'
          AND DataFim = '20271022'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271013',
            '20271022',
            NULL,
            GETDATE()
        );
    END;

    -- Wanderson Gomes dos Santos | SOE III | Férias | 15/10/2027 a 24/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 197
          AND TipoAfastamento = 1
          AND DataInicio = '20271015'
          AND DataFim = '20271024'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271015',
            '20271024',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 18/10/2027 a 27/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 153
          AND TipoAfastamento = 1
          AND DataInicio = '20271018'
          AND DataFim = '20271027'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271018',
            '20271027',
            NULL,
            GETDATE()
        );
    END;

    -- Juliano Dantas Bueno | SOT | Férias | 18/10/2027 a 27/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 154
          AND TipoAfastamento = 1
          AND DataInicio = '20271018'
          AND DataFim = '20271027'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271018',
            '20271027',
            NULL,
            GETDATE()
        );
    END;

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 19/10/2027 a 28/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 150
          AND TipoAfastamento = 1
          AND DataInicio = '20271019'
          AND DataFim = '20271028'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271019',
            '20271028',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 20/10/2027 a 29/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 204
          AND TipoAfastamento = 1
          AND DataInicio = '20271020'
          AND DataFim = '20271029'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271020',
            '20271029',
            NULL,
            GETDATE()
        );
    END;

    -- Marcos Davila Teixeira | SOE IV | Férias | 20/10/2027 a 29/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 203
          AND TipoAfastamento = 1
          AND DataInicio = '20271020'
          AND DataFim = '20271029'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271020',
            '20271029',
            NULL,
            GETDATE()
        );
    END;

    -- Pericles M. de Rezende Junior | SOT | Férias | 20/10/2027 a 29/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 156
          AND TipoAfastamento = 1
          AND DataInicio = '20271020'
          AND DataFim = '20271029'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271020',
            '20271029',
            NULL,
            GETDATE()
        );
    END;

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 21/10/2027 a 30/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 166
          AND TipoAfastamento = 1
          AND DataInicio = '20271021'
          AND DataFim = '20271030'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271021',
            '20271030',
            NULL,
            GETDATE()
        );
    END;

    -- Rubens Torres Deolindo | SOE III | Férias | 23/10/2027 a 31/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 192
          AND TipoAfastamento = 1
          AND DataInicio = '20271023'
          AND DataFim = '20271031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271023',
            '20271031',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Lima Aguirra | SOE IV | Férias | 24/10/2027 a 31/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 202
          AND TipoAfastamento = 1
          AND DataInicio = '20271024'
          AND DataFim = '20271031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271024',
            '20271031',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 25/10/2027 a 31/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20271025'
          AND DataFim = '20271031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271025',
            '20271031',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Férias | 25/10/2027 a 31/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 1
          AND DataInicio = '20271025'
          AND DataFim = '20271031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271025',
            '20271031',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 30/10/2027 a 31/10/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 1
          AND DataInicio = '20271030'
          AND DataFim = '20271031'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271030',
            '20271031',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Novembro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 11/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 40
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Adriano Viano Batista | SOC | Férias | 01/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 164
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            1,
            '20271101',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Ananias Batista Gomes Junior | GAB | Férias | 01/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 215
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271101',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Lima Aguirra | SOE IV | Férias | 01/11/2027 a 07/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 202
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271107'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271101',
            '20271107',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Sousa Farias | SOR | Férias | 01/11/2027 a 03/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 142
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271103'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271101',
            '20271103',
            NULL,
            GETDATE()
        );
    END;

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 01/11/2027 a 08/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 187
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271108'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271101',
            '20271108',
            NULL,
            GETDATE()
        );
    END;

    -- Luiz Cesar Mendes de Almeida | SOE III | Férias | 01/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 189
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271101',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Patricia Araujo Ribeiro | SAAEI | Férias | 01/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 222
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            1,
            '20271101',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Rayssa Polianna Silva | SOR | Férias | 01/11/2027 a 03/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 149
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271103'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271101',
            '20271103',
            NULL,
            GETDATE()
        );
    END;

    -- Rubens Torres Deolindo | SOE III | Férias | 01/11/2027 a 01/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 192
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271101'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271101',
            '20271101',
            NULL,
            GETDATE()
        );
    END;

    -- Tilia Rumi Okahara | SAAEI | Férias | 01/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 221
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271101',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Vanderlei Ferreira Dutra | SOE IV | Férias | 01/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 184
          AND TipoAfastamento = 1
          AND DataInicio = '20271101'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271101',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Bruno Alves Bezerra Silva | SOR | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 144
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 155
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Igor Thiago Maux Lopes | SI | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 135
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 151
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Mauricio Victor Cassis | SOR | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 146
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 131
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Rebeca Severo Limongi | SAAEI | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 223
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Ruy Lins Wanderley Neto | SOT | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 224
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Silvestre Milhomem Amaral | SI | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 137
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 03/11/2027 a 12/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 167
          AND TipoAfastamento = 1
          AND DataInicio = '20271103'
          AND DataFim = '20271112'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271103',
            '20271112',
            NULL,
            GETDATE()
        );
    END;

    -- Edson Medina de Oliveira | GAB | Férias | 05/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 1
          AND DataInicio = '20271105'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271105',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 08/11/2027 a 17/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 195
          AND TipoAfastamento = 1
          AND DataInicio = '20271108'
          AND DataFim = '20271117'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271108',
            '20271117',
            NULL,
            GETDATE()
        );
    END;

    -- Alberto Ganzaroli Neto | SOE II | Férias | 14/11/2027 a 23/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 185
          AND TipoAfastamento = 1
          AND DataInicio = '20271114'
          AND DataFim = '20271123'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271114',
            '20271123',
            NULL,
            GETDATE()
        );
    END;

    -- Higor Barbosa de Souza | SOE I | Férias | 14/11/2027 a 23/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 180
          AND TipoAfastamento = 1
          AND DataInicio = '20271114'
          AND DataFim = '20271123'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271114',
            '20271123',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Beltrame Faria | SOT | Férias | 15/11/2027 a 24/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 152
          AND TipoAfastamento = 1
          AND DataInicio = '20271115'
          AND DataFim = '20271124'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271115',
            '20271124',
            NULL,
            GETDATE()
        );
    END;

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 15/11/2027 a 24/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 136
          AND TipoAfastamento = 1
          AND DataInicio = '20271115'
          AND DataFim = '20271124'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271115',
            '20271124',
            NULL,
            GETDATE()
        );
    END;

    -- Adenauer Dantas Justo da SI | SI | Férias | 16/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 138
          AND TipoAfastamento = 1
          AND DataInicio = '20271116'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271116',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Aurelio Gleria Cavalcante | SOC | Férias | 16/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 169
          AND TipoAfastamento = 1
          AND DataInicio = '20271116'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271116',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Gabriel Arana da Silva | SOE III | Férias | 16/11/2027 a 25/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 196
          AND TipoAfastamento = 1
          AND DataInicio = '20271116'
          AND DataFim = '20271125'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271116',
            '20271125',
            NULL,
            GETDATE()
        );
    END;

    -- Marcelo Vasconcelos Dias | SOR | Férias | 16/11/2027 a 25/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 143
          AND TipoAfastamento = 1
          AND DataInicio = '20271116'
          AND DataFim = '20271125'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271116',
            '20271125',
            NULL,
            GETDATE()
        );
    END;

    -- Max Macedo Cavalcante | SOE II | Férias | 19/11/2027 a 28/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 220
          AND TipoAfastamento = 1
          AND DataInicio = '20271119'
          AND DataFim = '20271128'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271119',
            '20271128',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Férias | 22/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 1
          AND DataInicio = '20271122'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271122',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Sanlac Machado da Cunha | SOC | Férias | 22/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 162
          AND TipoAfastamento = 1
          AND DataInicio = '20271122'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271122',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Chiarelli Linhares Titoneli | SOT | Férias | 24/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 161
          AND TipoAfastamento = 1
          AND DataInicio = '20271124'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271124',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 26/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20271126'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271126',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Férias | 28/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 1
          AND DataInicio = '20271128'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271128',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 29/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 1
          AND DataInicio = '20271129'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271129',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 29/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 1
          AND DataInicio = '20271129'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271129',
            '20271130',
            NULL,
            GETDATE()
        );
    END;

    -- Josué Carvalho da Costa | SOE I | Férias | 30/11/2027 a 30/11/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20271130'
          AND DataFim = '20271130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271130',
            '20271130',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Dezembro
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 12/2027
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 28
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Adriano Viano Batista | SOC | Férias | 01/12/2027 a 30/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 164
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271230'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            1,
            '20271201',
            '20271230',
            NULL,
            GETDATE()
        );
    END;

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 01/12/2027 a 10/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 216
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271210'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271210',
            NULL,
            GETDATE()
        );
    END;

    -- Ananias Batista Gomes Junior | GAB | Férias | 01/12/2027 a 30/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 215
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271230'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271230',
            NULL,
            GETDATE()
        );
    END;

    -- Cinthia Versiani Pontes | SOC | Férias | 01/12/2027 a 10/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 163
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271210'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271210',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Pereira de Jesus | SOE II | Férias | 01/12/2027 a 30/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 186
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271230'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271230',
            NULL,
            GETDATE()
        );
    END;

    -- Edson Medina de Oliveira | GAB | Férias | 01/12/2027 a 04/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 130
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271204'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271204',
            NULL,
            GETDATE()
        );
    END;

    -- Fabio Silva Piazzarollo | SOE III | Férias | 01/12/2027 a 07/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 191
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271207'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271207',
            NULL,
            GETDATE()
        );
    END;

    -- Felipe Chiarelli Linhares Titoneli | SOT | Férias | 01/12/2027 a 23/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 161
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271223'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271223',
            NULL,
            GETDATE()
        );
    END;

    -- Francisco Lanna Guillen | SOE II | Férias | 01/12/2027 a 30/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 183
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271230'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271230',
            NULL,
            GETDATE()
        );
    END;

    -- Geovane Ribeiro Mathias | SOR | Férias | 01/12/2027 a 01/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 140
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271201'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271201',
            NULL,
            GETDATE()
        );
    END;

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 01/12/2027 a 08/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 157
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271208'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271208',
            NULL,
            GETDATE()
        );
    END;

    -- Josué Carvalho da Costa | SOE I | Férias | 01/12/2027 a 09/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 177
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271209'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271209',
            NULL,
            GETDATE()
        );
    END;

    -- Lincon Massahiro Takano | SOE IV | Férias | 01/12/2027 a 30/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 200
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271230'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271230',
            NULL,
            GETDATE()
        );
    END;

    -- Luiz Cesar Mendes de Almeida | SOE III | Férias | 01/12/2027 a 30/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 189
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271230'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271230',
            NULL,
            GETDATE()
        );
    END;

    -- Marcio Roberto Valente Caetano | GAB | Férias | 01/12/2027 a 30/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 206
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271230'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271230',
            NULL,
            GETDATE()
        );
    END;

    -- Patricia Araujo Ribeiro | SAAEI | Férias | 01/12/2027 a 30/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 222
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271230'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            1,
            '20271201',
            '20271230',
            NULL,
            GETDATE()
        );
    END;

    -- Pedro Rollemberg Mollo | SOE I | Férias | 01/12/2027 a 05/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 175
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271205'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271205',
            NULL,
            GETDATE()
        );
    END;

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 01/12/2027 a 08/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 139
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271208'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271208',
            NULL,
            GETDATE()
        );
    END;

    -- Sanlac Machado da Cunha | SOC | Férias | 01/12/2027 a 01/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 162
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271201'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271201',
            NULL,
            GETDATE()
        );
    END;

    -- Vanderlei Ferreira Dutra | SOE IV | Férias | 01/12/2027 a 30/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 184
          AND TipoAfastamento = 1
          AND DataInicio = '20271201'
          AND DataFim = '20271230'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271201',
            '20271230',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 05/12/2027 a 31/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 198
          AND TipoAfastamento = 1
          AND DataInicio = '20271205'
          AND DataFim = '20271231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271205',
            '20271231',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Férias | 08/12/2027 a 31/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 1
          AND DataInicio = '20271208'
          AND DataFim = '20271231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271208',
            '20271231',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Lebrão Arruda | SOE IV | Férias | 11/12/2027 a 31/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 201
          AND TipoAfastamento = 1
          AND DataInicio = '20271211'
          AND DataFim = '20271231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271211',
            '20271231',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 11/12/2027 a 31/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 1
          AND DataInicio = '20271211'
          AND DataFim = '20271231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271211',
            '20271231',
            NULL,
            GETDATE()
        );
    END;

    -- Renato Bizinoto Molas | SOE I | Férias | 12/12/2027 a 31/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 170
          AND TipoAfastamento = 1
          AND DataInicio = '20271212'
          AND DataFim = '20271231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271212',
            '20271231',
            NULL,
            GETDATE()
        );
    END;

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 15/12/2027 a 31/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 1
          AND DataInicio = '20271215'
          AND DataFim = '20271231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271215',
            '20271231',
            NULL,
            GETDATE()
        );
    END;

    -- Eduardo Cosme Carvalho da Silva | SOE I | Férias | 16/12/2027 a 31/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 174
          AND TipoAfastamento = 1
          AND DataInicio = '20271216'
          AND DataFim = '20271231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271216',
            '20271231',
            NULL,
            GETDATE()
        );
    END;

    -- Franthiesco L. Fernandes Nunes | SOE III | Férias | 22/12/2027 a 31/12/2027
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 194
          AND TipoAfastamento = 1
          AND DataInicio = '20271222'
          AND DataFim = '20271231'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20271222',
            '20271231',
            NULL,
            GETDATE()
        );
    END;
      ");

      // Janeiro 2028
      Sql(@"
-- ============================================================
-- AFASTAMENTOS - 01/2028
-- Fonte: PLANILHA AFASTAMENTOS 2027
-- Registros consolidados no mês: 10
-- Script idempotente.
-- Datas no padrão yyyyMMdd.
-- ============================================================

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 01/01/2028 a 13/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 199
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280113'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280113',
            NULL,
            GETDATE()
        );
    END;

    -- Antonio Jose Lima | GAB | Férias | 01/01/2028 a 06/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 212
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280106'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280106',
            NULL,
            GETDATE()
        );
    END;

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 01/01/2028 a 03/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 198
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280103'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280103',
            NULL,
            GETDATE()
        );
    END;

    -- Daniel Lebrão Arruda | SOE IV | Férias | 01/01/2028 a 09/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 201
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280109'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280109',
            NULL,
            GETDATE()
        );
    END;

    -- Eduardo Cosme Carvalho da Silva | SOE I | Férias | 01/01/2028 a 14/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 174
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280114'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280114',
            NULL,
            GETDATE()
        );
    END;

    -- Franthiesco L. Fernandes Nunes | SOE III | Férias | 01/01/2028 a 20/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 194
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280120'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280120',
            NULL,
            GETDATE()
        );
    END;

    -- Luiz Cesar Mendes de Almeida | SOE III | Férias | 01/01/2028 a 29/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 189
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280129'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280129',
            NULL,
            GETDATE()
        );
    END;

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 01/01/2028 a 09/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 148
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280109'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280109',
            NULL,
            GETDATE()
        );
    END;

    -- Renato Bizinoto Molas | SOE I | Férias | 01/01/2028 a 10/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 170
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280110'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280110',
            NULL,
            GETDATE()
        );
    END;

    -- Thallys Mendes Passos | SOE II | Férias | 01/01/2028 a 30/01/2028
    IF NOT EXISTS
    (
        SELECT 1
        FROM dbo.AfastamentoOperador
        WHERE OperadorID = 182
          AND TipoAfastamento = 1
          AND DataInicio = '20280101'
          AND DataFim = '20280130'
    )
    BEGIN
        INSERT INTO dbo.AfastamentoOperador
        (
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
            '20280101',
            '20280130',
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
