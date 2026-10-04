namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202609041310 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
-- ============================================================
-- AFASTAMENTOS CONSOLIDADOS - 2026 A 2028
-- Registros originais lidos das migrations: 761
-- Registros após consolidação: 595
-- Regra: mesmo operador + mesmo tipo, períodos sobrepostos ou
-- imediatamente consecutivos são tratados como um único período.
-- Operador resolvido por Matrícula; nenhum OperadorID é fixado.
-- Inserts idempotentes por OperadorID + Tipo + DataInicio + DataFim.
-- ============================================================


-- ==================== JANEIRO/2026 ====================

    -- Alberto Ganzaroli Neto | SOE II | Licença para tratamento de saúde própria | 01/01/2026 a 01/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260101',
        '20260101',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.676-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260101'
      );

    -- Vanderlei Ferreira Dutra | SOE II | Férias | 01/01/2026 a 01/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260101',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.682-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260101'
      );

    -- Marcelo Vieira de Sousa | GAB | Recesso Fim de Ano | 01/01/2026 a 01/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260101',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.418-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260101'
      );

    -- Ricardo Santos Textor | SOC | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Pablo Samora Bonifácio Medeiros | SOC | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.631-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Danilo Ricardo de Paiva Cunha | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.740-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Pericles M. de Rezende Junior | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.888-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Felipe Sousa Farias | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Vinicius Gomes dos Santos Fontes | SOC | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '229.161-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Marcelo Vasconcelos Dias | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.856-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Bruno Alves Bezerra Silva | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Hugo Leonardo Garcia Ferreira | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '234.273-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Marcelo Nunes | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.228-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Rebeca Severo Limongi | SAAEI | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.251-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Tiago Resende Brant | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.130-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Cinthia Versiani Pontes | SOC | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.639-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Silvestre Milhomem Amaral | SI | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '35.381-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Roberto Jean Philippe Corrêa | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.752-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Licença para tratamento de saúde própria | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Maiquel A. Cavalcante Mendes | SI | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.270-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Patricia Araujo Ribeiro | SAAEI | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.405-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Edson Medina de Oliveira | GAB | Recesso Fim de Ano | 01/01/2026 a 02/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        14,
        '20260101',
        '20260102',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '89.260-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 14
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260102'
      );

    -- Rayssa Polianna Silva | SOR | Licença para tratamento de saúde própria | 01/01/2026 a 03/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260101',
        '20260103',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260103'
      );

    -- Thallys Mendes Passos | SOE II | Férias | 01/01/2026 a 05/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260105',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.369-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260105'
      );

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Licença para tratamento de saúde própria | 01/01/2026 a 08/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260101',
        '20260108',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.719.773-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260108'
      );

    -- Higor Barbosa de Souza | SOE I | Férias | 01/01/2026 a 08/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260108',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.222-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260108'
      );

    -- Daniel Lebrão Arruda | SOE IV | Férias | 01/01/2026 a 11/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260111',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.600-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260111'
      );

    -- Renato Bizinoto Molas | SOE I | Férias | 01/01/2026 a 12/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.855-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260112'
      );

    -- Franthiesco L. Fernandes Nunes | SOE III | Férias | 01/01/2026 a 14/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260114',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.271-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260114'
      );

    -- Gabriel Arana da Silva | SOE III | Férias | 01/01/2026 a 22/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260122',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.229-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260122'
      );

    -- Wanderson Gomes dos Santos | SOE III | Férias | 01/01/2026 a 22/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260122',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.612-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260122'
      );

    -- Luiz Cesar Mendes de Almeida | SOE III | Férias | 01/01/2026 a 22/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260122',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.066-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260122'
      );

    -- Antonio Jose Lima | GAB | Férias | 01/01/2026 a 26/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260126',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.942-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260126'
      );

    -- Sidney da Silva de Oliveira | SOE II | Férias | 01/01/2026 a 29/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260101',
        '20260129',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.929-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260129'
      );

    -- Raphael Rodolfo Torres Gaia | SOR | Licença para tratamento de saúde própria | 01/01/2026 a 05/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260101',
        '20260505',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.647-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260101'
            AND a.DataFim = '20260505'
      );

    -- Marcelo Vieira de Sousa | GAB | Licença para tratamento de saúde própria | 02/01/2026 a 11/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260102',
        '20260511',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.418-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260102'
            AND a.DataFim = '20260511'
      );

    -- Eduardo Cosme Carvalho da Silva | SOE I | Férias | 03/01/2026 a 12/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260103',
        '20260112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.826-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260103'
            AND a.DataFim = '20260112'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 05/01/2026 a 05/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260105',
        '20260105',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260105'
            AND a.DataFim = '20260105'
      );

    -- Bruno Alves Bezerra Silva | SOR | Abono de ponto anual | 05/01/2026 a 09/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260105',
        '20260109',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260105'
            AND a.DataFim = '20260109'
      );

    -- Edson Medina de Oliveira | GAB | Férias | 05/01/2026 a 11/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260105',
        '20260111',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '89.260-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260105'
            AND a.DataFim = '20260111'
      );

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 05/01/2026 a 14/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260105',
        '20260114',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.552-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260105'
            AND a.DataFim = '20260114'
      );

    -- Felipe Sousa Farias | SOR | Férias | 05/01/2026 a 14/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260105',
        '20260114',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260105'
            AND a.DataFim = '20260114'
      );

    -- Cinthia Versiani Pontes | SOC | Férias | 05/01/2026 a 14/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260105',
        '20260114',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.639-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260105'
            AND a.DataFim = '20260114'
      );

    -- Silvestre Milhomem Amaral | SI | Férias | 05/01/2026 a 14/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260105',
        '20260114',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '35.381-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260105'
            AND a.DataFim = '20260114'
      );

    -- Marcio Roberto Valente Caetano | SOE IV | Licença para tratamento de saúde própria | 07/01/2026 a 11/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260107',
        '20260111',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.436-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260107'
            AND a.DataFim = '20260111'
      );

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 08/01/2026 a 17/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260108',
        '20260117',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '234.273-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260108'
            AND a.DataFim = '20260117'
      );

    -- Marcelo Nunes | SOT | Férias | 08/01/2026 a 17/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260108',
        '20260117',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.228-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260108'
            AND a.DataFim = '20260117'
      );

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 10/01/2026 a 13/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260110',
        '20260113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.462-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260110'
            AND a.DataFim = '20260113'
      );

    -- Diego Madureira Rodrigues | SOE I | Férias | 11/01/2026 a 30/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260111',
        '20260130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '186.000-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260111'
            AND a.DataFim = '20260130'
      );

    -- Mauricio Victor Cassis | SOR | Licença para tratamento de saúde própria | 12/01/2026 a 16/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260112',
        '20260116',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260112'
            AND a.DataFim = '20260116'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 12/01/2026 a 20/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260112',
        '20260120',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260112'
            AND a.DataFim = '20260120'
      );

    -- Juliano Dantas Bueno | SOT | Férias | 12/01/2026 a 21/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260112',
        '20260121',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '225.345-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260112'
            AND a.DataFim = '20260121'
      );

    -- Aurelio Gleria Cavalcante | SOC | Abono de ponto anual | 13/01/2026 a 13/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260113',
        '20260113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.058-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260113'
            AND a.DataFim = '20260113'
      );

    -- Marcio Roberto Valente Caetano | SOE IV | Férias | 14/01/2026 a 23/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260114',
        '20260123',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.436-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260114'
            AND a.DataFim = '20260123'
      );

    -- Cinthia Versiani Pontes | SOC | Abono de ponto anual | 15/01/2026 a 16/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260115',
        '20260116',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.639-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260115'
            AND a.DataFim = '20260116'
      );

    -- Marcelo Thomas | SOE I | Férias | 15/01/2026 a 24/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260115',
        '20260124',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.720-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260115'
            AND a.DataFim = '20260124'
      );

    -- Sanlac Machado da Cunha | SOC | Férias | 15/01/2026 a 24/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260115',
        '20260124',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.160-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260115'
            AND a.DataFim = '20260124'
      );

    -- Aurelio Gleria Cavalcante | SOC | Férias | 15/01/2026 a 29/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260115',
        '20260129',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.058-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260115'
            AND a.DataFim = '20260129'
      );

    -- Fabio Silva Piazzarollo | SOE III | Férias | 17/01/2026 a 26/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260117',
        '20260126',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.923-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260117'
            AND a.DataFim = '20260126'
      );

    -- Marcos Davila Teixeira | SOE IV | Férias | 18/01/2026 a 27/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260118',
        '20260127',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '189.289-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260118'
            AND a.DataFim = '20260127'
      );

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 19/01/2026 a 28/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260119',
        '20260128',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.752-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260119'
            AND a.DataFim = '20260128'
      );

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 19/01/2026 a 28/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260119',
        '20260128',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.224-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260119'
            AND a.DataFim = '20260128'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 19/01/2026 a 28/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260119',
        '20260128',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260119'
            AND a.DataFim = '20260128'
      );

    -- Cristiano Pereira de Jesus | SOE II | Férias | 20/01/2026 a 29/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260120',
        '20260129',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.212-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260120'
            AND a.DataFim = '20260129'
      );

    -- Frank Rodrigues Ferreira | SOT | Férias | 21/01/2026 a 21/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260121',
        '20260121',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.616-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260121'
            AND a.DataFim = '20260121'
      );

    -- Marcelo Vasconcelos Dias | SOR | Férias | 22/01/2026 a 22/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260122',
        '20260122',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.856-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260122'
            AND a.DataFim = '20260122'
      );

    -- Andre Ricardo Oliveira Marinho | SOE IV | Licença para tratamento de saúde própria | 22/01/2026 a 26/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260122',
        '20260126',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.809-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260122'
            AND a.DataFim = '20260126'
      );

    -- Leandro de Oliveira Sampaio | GAB | Férias | 22/01/2026 a 31/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260122',
        '20260131',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.545-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260122'
            AND a.DataFim = '20260131'
      );

    -- Klebson Alves Fonseca | SOE III | Férias | 25/01/2026 a 03/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260125',
        '20260203',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.929-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260125'
            AND a.DataFim = '20260203'
      );

    -- Marcio Roberto Valente Caetano | SOE IV | Abono de ponto anual | 26/01/2026 a 30/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260126',
        '20260130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.436-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260126'
            AND a.DataFim = '20260130'
      );

    -- Ricardo Santos Textor | SOC | Férias | 26/01/2026 a 04/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260126',
        '20260204',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260126'
            AND a.DataFim = '20260204'
      );

    -- Josué Carvalho da Costa | SOE I | Férias | 27/01/2026 a 30/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260127',
        '20260130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.637-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260127'
            AND a.DataFim = '20260130'
      );

    -- Tilia Rumi Okahara | SAAEI | Abono de ponto anual | 28/01/2026 a 30/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260128',
        '20260130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '63.236-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260128'
            AND a.DataFim = '20260130'
      );

    -- Igor Thiago Maux Lopes | SI | Férias | 28/01/2026 a 06/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260128',
        '20260206',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.112-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260128'
            AND a.DataFim = '20260206'
      );

    -- Honney Cordeiro | SOE II | Férias | 28/01/2026 a 16/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260128',
        '20260216',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.764-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260128'
            AND a.DataFim = '20260216'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 29/01/2026 a 29/01/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260129',
        '20260129',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260129'
            AND a.DataFim = '20260129'
      );

    -- Sidartha Souza de Quevedo | SOE I | Férias | 31/01/2026 a 03/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260131',
        '20260203',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '238.906-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260131'
            AND a.DataFim = '20260203'
      );


-- ==================== FEVEREIRO/2026 ====================

    -- Josué Carvalho da Costa | SOE I | Férias | 01/02/2026 a 05/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260201',
        '20260205',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.637-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260201'
            AND a.DataFim = '20260205'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 02/02/2026 a 02/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260202',
        '20260202',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260202'
            AND a.DataFim = '20260202'
      );

    -- Tilia Rumi Okahara | SAAEI | Abono de ponto anual | 02/02/2026 a 03/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260202',
        '20260203',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '63.236-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260202'
            AND a.DataFim = '20260203'
      );

    -- Rayssa Polianna Silva | SOR | Férias | 02/02/2026 a 11/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260202',
        '20260211',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260202'
            AND a.DataFim = '20260211'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Licença para tratamento de saúde própria | 02/02/2026 a 06/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260202',
        '20260506',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260202'
            AND a.DataFim = '20260506'
      );

    -- Bruno Lima Aguirra | SOE IV | Férias | 03/02/2026 a 12/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260203',
        '20260212',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.413-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260203'
            AND a.DataFim = '20260212'
      );

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 04/02/2026 a 13/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260204',
        '20260213',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.631-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260204'
            AND a.DataFim = '20260213'
      );

    -- Tilia Rumi Okahara | SAAEI | Férias | 04/02/2026 a 13/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260204',
        '20260213',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '63.236-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260204'
            AND a.DataFim = '20260213'
      );

    -- Francisco Lanna Guillen | SOE II | Férias | 05/02/2026 a 14/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260205',
        '20260214',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.540-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260205'
            AND a.DataFim = '20260214'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Licença para tratamento de saúde própria | 10/02/2026 a 19/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260210',
        '20260219',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260210'
            AND a.DataFim = '20260219'
      );

    -- Luis Ricardo Brasilino | SOE I | Férias | 12/02/2026 a 21/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260212',
        '20260221',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.650-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260212'
            AND a.DataFim = '20260221'
      );

    -- Tiago Resende Brant | SOT | Licença para tratamento de saúde própria | 12/02/2026 a 07/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260212',
        '20260907',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.130-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260212'
            AND a.DataFim = '20260907'
      );

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 13/02/2026 a 22/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260213',
        '20260222',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.047-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260213'
            AND a.DataFim = '20260222'
      );

    -- Bruno Alves Bezerra Silva | SOR | Férias | 14/02/2026 a 14/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260214',
        '20260214',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260214'
            AND a.DataFim = '20260214'
      );

    -- Bruno Lima Aguirra | SOE IV | Abono de ponto anual | 15/02/2026 a 17/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260215',
        '20260217',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.413-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260215'
            AND a.DataFim = '20260217'
      );

    -- Lincon Massahiro Takano | SOE IV | Férias | 15/02/2026 a 18/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260215',
        '20260218',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '47.567-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260215'
            AND a.DataFim = '20260218'
      );

    -- Patricia Araujo Ribeiro | SAAEI | Abono de ponto anual | 18/02/2026 a 20/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260218',
        '20260220',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.405-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260218'
            AND a.DataFim = '20260220'
      );

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 18/02/2026 a 26/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260218',
        '20260226',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.224-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260218'
            AND a.DataFim = '20260226'
      );

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 18/02/2026 a 27/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260218',
        '20260227',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '229.161-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260218'
            AND a.DataFim = '20260227'
      );

    -- Gustavo Amaral Yung | GAB | Férias | 19/02/2026 a 28/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260219',
        '20260228',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.039-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260219'
            AND a.DataFim = '20260228'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Curso | 23/02/2026 a 28/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        12,
        '20260223',
        '20260228',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 12
            AND a.DataInicio = '20260223'
            AND a.DataFim = '20260228'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 27/02/2026 a 27/02/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260227',
        '20260227',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260227'
            AND a.DataFim = '20260227'
      );

    -- Diego Madureira Rodrigues | SOE I | Licença para tratamento de saúde própria | 27/02/2026 a 08/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260227',
        '20260308',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '186.000-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260227'
            AND a.DataFim = '20260308'
      );


-- ==================== MARÇO/2026 ====================

    -- Adriano Viano Batista | SOC | Abono de ponto anual | 04/03/2026 a 05/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260304',
        '20260305',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.131-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260304'
            AND a.DataFim = '20260305'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Abono de ponto anual | 04/03/2026 a 06/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260304',
        '20260306',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260304'
            AND a.DataFim = '20260306'
      );

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 05/03/2026 a 03/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260305',
        '20260403',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.047-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260305'
            AND a.DataFim = '20260403'
      );

    -- Rafaela Lopes Andrade | SOC | Abono de ponto anual | 09/03/2026 a 13/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260309',
        '20260313',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.692-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260309'
            AND a.DataFim = '20260313'
      );

    -- Tilia Rumi Okahara | SAAEI | Abono de aniversário | 11/03/2026 a 11/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        3,
        '20260311',
        '20260311',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '63.236-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 3
            AND a.DataInicio = '20260311'
            AND a.DataFim = '20260311'
      );

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 11/03/2026 a 14/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260311',
        '20260314',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.809-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260311'
            AND a.DataFim = '20260314'
      );

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 16/03/2026 a 30/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260316',
        '20260330',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.321-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260316'
            AND a.DataFim = '20260330'
      );

    -- Igor Thiago Maux Lopes | SI | Abono de ponto anual | 19/03/2026 a 20/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260319',
        '20260320',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.112-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260319'
            AND a.DataFim = '20260320'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 19/03/2026 a 27/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260319',
        '20260327',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260319'
            AND a.DataFim = '20260327'
      );

    -- Ricardo Santos Textor | GAB | Férias | 21/03/2026 a 30/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260321',
        '20260330',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260321'
            AND a.DataFim = '20260330'
      );

    -- Alberto Ganzaroli Neto | SOE II | Férias | 21/03/2026 a 30/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260321',
        '20260330',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.676-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260321'
            AND a.DataFim = '20260330'
      );

    -- Felipe Chiarelli Linhares Titoneli | SOT | Férias | 23/03/2026 a 23/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260323',
        '20260323',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.534-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260323'
            AND a.DataFim = '20260323'
      );

    -- Mauricio Victor Cassis | SOR | Férias | 23/03/2026 a 23/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260323',
        '20260323',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260323'
            AND a.DataFim = '20260323'
      );

    -- Anderson Benevides Valença | SOE IV | Abono de ponto anual | 23/03/2026 a 25/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260323',
        '20260325',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.295-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260323'
            AND a.DataFim = '20260325'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Licença para tratamento de saúde própria | 24/03/2026 a 07/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260324',
        '20260407',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260324'
            AND a.DataFim = '20260407'
      );

    -- Bruno Lima Aguirra | SOE IV | Abono de ponto anual | 27/03/2026 a 28/03/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260327',
        '20260328',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.413-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260327'
            AND a.DataFim = '20260328'
      );

    -- Marcos Davila Teixeira | SOE IV | Licença para tratamento de saúde própria | 27/03/2026 a 22/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260327',
        '20260922',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '189.289-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260327'
            AND a.DataFim = '20260922'
      );

    -- Wanderson Gomes dos Santos | SOE III | Licença para tratamento de saúde própria | 29/03/2026 a 04/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260329',
        '20260404',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.612-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260329'
            AND a.DataFim = '20260404'
      );

    -- Lincon Massahiro Takano | SOE IV | Férias | 31/03/2026 a 05/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260331',
        '20260405',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '47.567-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260331'
            AND a.DataFim = '20260405'
      );

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 31/03/2026 a 05/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260331',
        '20260405',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.809-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260331'
            AND a.DataFim = '20260405'
      );


-- ==================== ABRIL/2026 ====================

    -- Josué Carvalho da Costa | SOE I | Férias | 05/04/2026 a 10/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260405',
        '20260410',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.637-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260405'
            AND a.DataFim = '20260410'
      );

    -- Geovane Ribeiro Mathias | SOR | Abono de ponto anual | 06/04/2026 a 10/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260406',
        '20260410',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.395-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260406'
            AND a.DataFim = '20260410'
      );

    -- Frank Rodrigues Ferreira | SOT | Férias | 06/04/2026 a 14/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260406',
        '20260414',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.616-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260406'
            AND a.DataFim = '20260414'
      );

    -- Gabriel Arana da Silva | SOE III | Férias | 06/04/2026 a 15/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260406',
        '20260415',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.229-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260406'
            AND a.DataFim = '20260415'
      );

    -- Ricardo Santos Textor | SOC | Férias | 06/04/2026 a 15/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260406',
        '20260415',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260406'
            AND a.DataFim = '20260415'
      );

    -- Santilhento Marcos da Silva | SOR | Férias | 06/04/2026 a 20/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260406',
        '20260420',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.672-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260406'
            AND a.DataFim = '20260420'
      );

    -- Rebeca Severo Limongi | SAAEI | Férias | 06/04/2026 a 20/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260406',
        '20260420',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.251-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260406'
            AND a.DataFim = '20260420'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 09/04/2026 a 17/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260409',
        '20260417',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260409'
            AND a.DataFim = '20260417'
      );

    -- Felipe Sousa Farias | SOR | Férias | 15/04/2026 a 24/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260415',
        '20260424',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260415'
            AND a.DataFim = '20260424'
      );

    -- Sanlac Machado da Cunha | SOC | Férias | 15/04/2026 a 24/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260415',
        '20260424',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.160-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260415'
            AND a.DataFim = '20260424'
      );

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 15/04/2026 a 29/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260415',
        '20260429',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.393-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260415'
            AND a.DataFim = '20260429'
      );

    -- Anderson Benevides Valença | SOE IV | Abono de ponto anual | 16/04/2026 a 17/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260416',
        '20260417',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.295-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260416'
            AND a.DataFim = '20260417'
      );

    -- Eduardo Cosme Carvalho da Silva | SOE I | Abono de ponto anual | 17/04/2026 a 21/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260417',
        '20260421',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.826-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260417'
            AND a.DataFim = '20260421'
      );

    -- Edson Medina de Oliveira | GAB | Licença para tratamento de saúde própria | 17/04/2026 a 30/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260417',
        '20260430',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '89.260-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260417'
            AND a.DataFim = '20260430'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Curso | 19/04/2026 a 30/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        12,
        '20260419',
        '20260430',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 12
            AND a.DataInicio = '20260419'
            AND a.DataFim = '20260430'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Curso | 19/04/2026 a 30/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        12,
        '20260419',
        '20260430',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 12
            AND a.DataInicio = '20260419'
            AND a.DataFim = '20260430'
      );

    -- Daniel Beltrame Faria | SOT | Férias | 20/04/2026 a 29/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260420',
        '20260429',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.205-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260420'
            AND a.DataFim = '20260429'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Curso | 21/04/2026 a 25/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        12,
        '20260421',
        '20260425',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 12
            AND a.DataInicio = '20260421'
            AND a.DataFim = '20260425'
      );

    -- Higor Barbosa de Souza | SOE I | Férias | 21/04/2026 a 30/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260421',
        '20260430',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.222-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260421'
            AND a.DataFim = '20260430'
      );

    -- Ricardo Santos Textor | SOC | Abono de ponto anual | 22/04/2026 a 24/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260422',
        '20260424',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260422'
            AND a.DataFim = '20260424'
      );

    -- Gustavo Amaral Yung | GAB | Abono de ponto anual | 22/04/2026 a 24/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260422',
        '20260424',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.039-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260422'
            AND a.DataFim = '20260424'
      );

    -- Mauricio Victor Cassis | SOR | Férias | 22/04/2026 a 30/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260422',
        '20260430',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260422'
            AND a.DataFim = '20260430'
      );

    -- Marcelo Vasconcelos Dias | SOR | Férias | 22/04/2026 a 01/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260422',
        '20260501',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.856-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260422'
            AND a.DataFim = '20260501'
      );

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 22/04/2026 a 01/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260422',
        '20260501',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.270-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260422'
            AND a.DataFim = '20260501'
      );

    -- Klebson Alves Fonseca | SOE III | Abono de ponto anual | 23/04/2026 a 25/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260423',
        '20260425',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.929-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260423'
            AND a.DataFim = '20260425'
      );

    -- Ricardo Santos Textor | SOC | Abono de ponto anual | 27/04/2026 a 27/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260427',
        '20260427',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260427'
            AND a.DataFim = '20260427'
      );

    -- Sanlac Machado da Cunha | SOC | Abono de ponto anual | 27/04/2026 a 28/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260427',
        '20260428',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.160-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260427'
            AND a.DataFim = '20260428'
      );

    -- Franthiesco L. Fernandes Nunes | SOE III | Abono de ponto anual | 27/04/2026 a 01/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260427',
        '20260501',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.271-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260427'
            AND a.DataFim = '20260501'
      );

    -- Igor Thiago Maux Lopes | SI | Férias | 27/04/2026 a 06/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260427',
        '20260506',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.112-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260427'
            AND a.DataFim = '20260506'
      );

    -- Gustavo Amaral Yung | GAB | Abono de ponto anual | 29/04/2026 a 30/04/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260429',
        '20260430',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.039-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260429'
            AND a.DataFim = '20260430'
      );


-- ==================== MAIO/2026 ====================

    -- Cleuber Medeiros Guimarães | SOE III | Abono de ponto anual | 01/05/2026 a 03/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260501',
        '20260503',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.393-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260501'
            AND a.DataFim = '20260503'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Licença-prêmio por assiduidade | 01/05/2026 a 09/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        5,
        '20260501',
        '20260509',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 5
            AND a.DataInicio = '20260501'
            AND a.DataFim = '20260509'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Licença-prêmio por assiduidade | 01/05/2026 a 09/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        5,
        '20260501',
        '20260509',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 5
            AND a.DataInicio = '20260501'
            AND a.DataFim = '20260509'
      );

    -- Bruno Lima Aguirra | SOE IV | Férias | 02/05/2026 a 11/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260502',
        '20260511',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.413-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260502'
            AND a.DataFim = '20260511'
      );

    -- Renato Bizinoto Molas | SOE I | Abono de ponto anual | 03/05/2026 a 07/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260503',
        '20260507',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.855-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260503'
            AND a.DataFim = '20260507'
      );

    -- Jorge Vinicius Moura Campos | SOE II | Licença para tratamento de saúde própria | 03/05/2026 a 25/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260503',
        '20261125',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.047-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260503'
            AND a.DataFim = '20261125'
      );

    -- Edson Medina de Oliveira | GAB | Férias | 04/05/2026 a 06/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260504',
        '20260506',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '89.260-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260504'
            AND a.DataFim = '20260506'
      );

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 04/05/2026 a 13/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260504',
        '20260513',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.631-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260504'
            AND a.DataFim = '20260513'
      );

    -- Pericles M. de Rezende Junior | SOT | Férias | 04/05/2026 a 02/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260504',
        '20260602',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.888-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260504'
            AND a.DataFim = '20260602'
      );

    -- Fabio Silva Piazzarollo | SOE III | Férias | 05/05/2026 a 14/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260505',
        '20260514',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.923-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260505'
            AND a.DataFim = '20260514'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Abono de ponto anual | 11/05/2026 a 12/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260511',
        '20260512',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260511'
            AND a.DataFim = '20260512'
      );

    -- Geovane Ribeiro Mathias | SOR | Férias | 11/05/2026 a 16/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260511',
        '20260516',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.395-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260511'
            AND a.DataFim = '20260516'
      );

    -- Diego Madureira Rodrigues | SOE I | Licença para tratamento de saúde própria | 11/05/2026 a 24/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260511',
        '20260524',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '186.000-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260511'
            AND a.DataFim = '20260524'
      );

    -- Andre Ricardo Oliveira Marinho | SOE IV | Licença para tratar de interesse particular | 14/05/2026 a 14/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        6,
        '20260514',
        '20260514',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.809-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 6
            AND a.DataInicio = '20260514'
            AND a.DataFim = '20260514'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Abono de ponto anual | 14/05/2026 a 15/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260514',
        '20260515',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260514'
            AND a.DataFim = '20260515'
      );

    -- Leandro de Oliveira Sampaio | GAB | Licença para tratamento de saúde própria | 16/05/2026 a 01/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260516',
        '20261001',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.545-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260516'
            AND a.DataFim = '20261001'
      );

    -- Luis Ricardo Brasilino | SOE I | Licença para tratamento de saúde própria | 17/05/2026 a 30/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260517',
        '20260630',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.650-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260517'
            AND a.DataFim = '20260630'
      );

    -- Rayssa Polianna Silva | SOR | Abono de ponto anual | 18/05/2026 a 19/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260518',
        '20260519',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260518'
            AND a.DataFim = '20260519'
      );

    -- Rafaela Lopes Andrade | SOC | Férias | 18/05/2026 a 27/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260518',
        '20260527',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.692-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260518'
            AND a.DataFim = '20260527'
      );

    -- Daniel Lebrão Arruda | SOE IV | Abono de ponto anual | 22/05/2026 a 24/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260522',
        '20260524',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.600-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260522'
            AND a.DataFim = '20260524'
      );

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 22/05/2026 a 27/05/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260522',
        '20260527',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.462-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260522'
            AND a.DataFim = '20260527'
      );

    -- Cristiano Pereira de Jesus | SOE II | Férias | 24/05/2026 a 02/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260524',
        '20260602',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.212-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260524'
            AND a.DataFim = '20260602'
      );

    -- Bruno Alves Bezerra Silva | SOR | Férias | 26/05/2026 a 03/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260526',
        '20260603',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260526'
            AND a.DataFim = '20260603'
      );

    -- Anderson Benevides Valença | SOE IV | Férias | 29/05/2026 a 12/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260529',
        '20260612',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.295-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260529'
            AND a.DataFim = '20260612'
      );


-- ==================== JUNHO/2026 ====================

    -- Ananias Batista Gomes Junior | GAB | Abono de aniversário | 01/06/2026 a 01/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        3,
        '20260601',
        '20260601',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.742-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 3
            AND a.DataInicio = '20260601'
            AND a.DataFim = '20260601'
      );

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 01/06/2026 a 05/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260601',
        '20260605',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.321-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260601'
            AND a.DataFim = '20260605'
      );

    -- Rubens Torres Deolindo | SOE III | Férias | 02/06/2026 a 11/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260602',
        '20260611',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.812-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260602'
            AND a.DataFim = '20260611'
      );

    -- Andre Ricardo Oliveira Marinho | SOE IV | Abono de ponto anual | 03/06/2026 a 07/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260603',
        '20260607',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.809-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260603'
            AND a.DataFim = '20260607'
      );

    -- Rayssa Polianna Silva | SOR | Férias | 08/06/2026 a 08/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260608',
        '20260608',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260608'
            AND a.DataFim = '20260608'
      );

    -- Frank Rodrigues Ferreira | SOT | Abono de ponto anual | 08/06/2026 a 09/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260608',
        '20260609',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.616-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260608'
            AND a.DataFim = '20260609'
      );

    -- Cristiano Pereira de Jesus | SOE II | Abono de ponto anual | 09/06/2026 a 13/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260609',
        '20260613',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.212-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260609'
            AND a.DataFim = '20260613'
      );

    -- Patricia Araujo Ribeiro | SAAEI | Abono de aniversário | 12/06/2026 a 12/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        3,
        '20260612',
        '20260612',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.405-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 3
            AND a.DataInicio = '20260612'
            AND a.DataFim = '20260612'
      );

    -- Edson Medina de Oliveira | GAB | Férias | 15/06/2026 a 15/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260615',
        '20260615',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '89.260-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260615'
            AND a.DataFim = '20260615'
      );

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 18/06/2026 a 18/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260618',
        '20260618',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.647-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260618'
            AND a.DataFim = '20260618'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 20/06/2026 a 29/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260620',
        '20260629',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260620'
            AND a.DataFim = '20260629'
      );

    -- Felipe Sousa Farias | SOR | Abono de ponto anual | 22/06/2026 a 22/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260622',
        '20260622',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260622'
            AND a.DataFim = '20260622'
      );

    -- Marcelo Thomas | GAB | Licença para tratamento de saúde própria | 23/06/2026 a 23/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260623',
        '20260623',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.720-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260623'
            AND a.DataFim = '20260623'
      );

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 23/06/2026 a 02/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260623',
        '20260702',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.462-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260623'
            AND a.DataFim = '20260702'
      );

    -- Pedro Rollemberg Mollo | SOE I | Férias | 24/06/2026 a 03/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260624',
        '20260703',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260624'
            AND a.DataFim = '20260703'
      );

    -- Francisco Lanna Guillen | SOE II | Férias | 25/06/2026 a 04/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260625',
        '20260704',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.540-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260625'
            AND a.DataFim = '20260704'
      );

    -- Mauricio Victor Cassis | SOR | Abono de ponto anual | 26/06/2026 a 26/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260626',
        '20260626',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260626'
            AND a.DataFim = '20260626'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 29/06/2026 a 07/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260629',
        '20260707',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260629'
            AND a.DataFim = '20260707'
      );

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 29/06/2026 a 08/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260629',
        '20260708',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.752-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260629'
            AND a.DataFim = '20260708'
      );

    -- Danilo Ricardo de Paiva Cunha | SOT | Abono de ponto anual | 30/06/2026 a 30/06/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260630',
        '20260630',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.740-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260630'
            AND a.DataFim = '20260630'
      );


-- ==================== JULHO/2026 ====================

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 01/07/2026 a 01/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260701',
        '20260701',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260701'
            AND a.DataFim = '20260701'
      );

    -- Felipe Chiarelli Linhares Titoneli | SOT | Férias | 01/07/2026 a 09/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260701',
        '20260709',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.534-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260701'
            AND a.DataFim = '20260709'
      );

    -- Luis Ricardo Brasilino | SOE I | Férias | 01/07/2026 a 10/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260701',
        '20260710',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.650-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260701'
            AND a.DataFim = '20260710'
      );

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 03/07/2026 a 12/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260703',
        '20260712',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.224-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260703'
            AND a.DataFim = '20260712'
      );

    -- Franthiesco L. Fernandes Nunes | SOE III | Férias | 03/07/2026 a 17/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260703',
        '20260717',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.271-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260703'
            AND a.DataFim = '20260717'
      );

    -- Ricardo Santos Textor | GAB | Férias | 04/07/2026 a 13/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260704',
        '20260713',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260704'
            AND a.DataFim = '20260713'
      );

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 05/07/2026 a 14/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260705',
        '20260714',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.552-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260705'
            AND a.DataFim = '20260714'
      );

    -- Sidney da Silva de Oliveira | SOE II | Férias | 06/07/2026 a 09/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260706',
        '20260709',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.929-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260706'
            AND a.DataFim = '20260709'
      );

    -- Juliano Dantas Bueno | SOT | Férias | 06/07/2026 a 15/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260706',
        '20260715',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '225.345-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260706'
            AND a.DataFim = '20260715'
      );

    -- Eduardo Cosme Carvalho da Silva | SOE I | Férias | 06/07/2026 a 15/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260706',
        '20260715',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.826-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260706'
            AND a.DataFim = '20260715'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Licença para tratamento de saúde própria | 06/07/2026 a 04/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260706',
        '20260804',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260706'
            AND a.DataFim = '20260804'
      );

    -- Higor Barbosa de Souza | SOE I | Licença para tratamento de saúde própria | 06/07/2026 a 03/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260706',
        '20261003',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.222-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260706'
            AND a.DataFim = '20261003'
      );

    -- Aurelio Gleria Cavalcante | SOC | Abono de ponto anual | 07/07/2026 a 10/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260707',
        '20260710',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.058-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260707'
            AND a.DataFim = '20260710'
      );

    -- Honney Cordeiro | SOE II | Férias | 07/07/2026 a 16/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260707',
        '20260716',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.764-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260707'
            AND a.DataFim = '20260716'
      );

    -- Adenauer Dantas Justo | SI | Férias | 07/07/2026 a 26/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260707',
        '20260726',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '36.007-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260707'
            AND a.DataFim = '20260726'
      );

    -- Luiz Cesar Mendes de Almeida | SOE III | Abono de ponto anual | 08/07/2026 a 12/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260708',
        '20260712',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.066-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260708'
            AND a.DataFim = '20260712'
      );

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 08/07/2026 a 17/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260708',
        '20260717',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '229.161-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260708'
            AND a.DataFim = '20260717'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 09/07/2026 a 17/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260709',
        '20260717',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260709'
            AND a.DataFim = '20260717'
      );

    -- Diego Madureira Rodrigues | SOE I | Férias | 10/07/2026 a 19/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260710',
        '20260719',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '186.000-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260710'
            AND a.DataFim = '20260719'
      );

    -- Geovane Ribeiro Mathias | SOR | Férias | 13/07/2026 a 17/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260713',
        '20260717',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.395-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260713'
            AND a.DataFim = '20260717'
      );

    -- Cinthia Versiani Pontes | SOC | Férias | 13/07/2026 a 22/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260713',
        '20260722',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.639-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260713'
            AND a.DataFim = '20260722'
      );

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 13/07/2026 a 22/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260713',
        '20260722',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.270-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260713'
            AND a.DataFim = '20260722'
      );

    -- Sidney da Silva de Oliveira | SOE II | Licença para tratamento de saúde própria | 17/07/2026 a 19/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260717',
        '20260719',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.929-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260717'
            AND a.DataFim = '20260719'
      );

    -- Luis Ricardo Brasilino | SOE I | Abono de ponto anual | 18/07/2026 a 20/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260718',
        '20260720',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.650-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260718'
            AND a.DataFim = '20260720'
      );

    -- Sidartha Souza de Quevedo | SOE I | Férias | 18/07/2026 a 23/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260718',
        '20260723',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '238.906-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260718'
            AND a.DataFim = '20260723'
      );

    -- Marcelo Thomas | GAB | Férias | 18/07/2026 a 27/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260718',
        '20260727',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.720-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260718'
            AND a.DataFim = '20260727'
      );

    -- Max Macedo Cavalcante | SOE II | Férias | 19/07/2026 a 02/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260719',
        '20260802',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.722.557-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260719'
            AND a.DataFim = '20260802'
      );

    -- Patricia Araujo Ribeiro | SAAEI | Abono de ponto anual | 20/07/2026 a 24/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260720',
        '20260724',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.405-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260720'
            AND a.DataFim = '20260724'
      );

    -- Klebson Alves Fonseca | SOE III | Férias | 20/07/2026 a 29/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260720',
        '20260729',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.929-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260720'
            AND a.DataFim = '20260729'
      );

    -- Mauricio Victor Cassis | SOR | Férias | 20/07/2026 a 29/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260720',
        '20260729',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260720'
            AND a.DataFim = '20260729'
      );

    -- Frank Rodrigues Ferreira | SOT | Férias | 20/07/2026 a 29/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260720',
        '20260729',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.616-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260720'
            AND a.DataFim = '20260729'
      );

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 20/07/2026 a 03/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260720',
        '20260803',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.393-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260720'
            AND a.DataFim = '20260803'
      );

    -- Alberto Ganzaroli Neto | SOE II | Licença para tratamento de saúde própria | 22/07/2026 a 31/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260722',
        '20260731',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.676-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260722'
            AND a.DataFim = '20260731'
      );

    -- Bruno Alves Bezerra Silva | SOR | Licença para tratar de interesse particular | 23/07/2026 a 23/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        6,
        '20260723',
        '20260723',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 6
            AND a.DataInicio = '20260723'
            AND a.DataFim = '20260723'
      );

    -- Lincon Massahiro Takano | SOE IV | Férias | 25/07/2026 a 31/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260725',
        '20260731',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '47.567-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260725'
            AND a.DataFim = '20260731'
      );

    -- Antonio Jose Lima | GAB | Licença para tratamento de saúde própria | 26/07/2026 a 02/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260726',
        '20260802',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.942-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260726'
            AND a.DataFim = '20260802'
      );

    -- Rayssa Polianna Silva | SOR | Férias | 27/07/2026 a 04/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260727',
        '20260804',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260727'
            AND a.DataFim = '20260804'
      );

    -- Rubens Torres Deolindo | SOE III | Abono de ponto anual | 28/07/2026 a 29/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260728',
        '20260729',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.812-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260728'
            AND a.DataFim = '20260729'
      );

    -- Marcio Romeiro Pereira Junior | SOE IV | Licença para tratamento de saúde própria | 28/07/2026 a 26/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260728',
        '20260826',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.552-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260728'
            AND a.DataFim = '20260826'
      );

    -- Mauricio Victor Cassis | SOR | Licença para tratar de interesse particular | 30/07/2026 a 30/07/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        6,
        '20260730',
        '20260730',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 6
            AND a.DataInicio = '20260730'
            AND a.DataFim = '20260730'
      );


-- ==================== AGOSTO/2026 ====================

    -- Klebson Alves Fonseca | SOE III | Licença para tratamento de saúde própria | 01/08/2026 a 01/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260801',
        '20260801',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.929-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260801'
            AND a.DataFim = '20260801'
      );

    -- Wanderson Gomes dos Santos | SOE III | Abono de ponto anual | 01/08/2026 a 03/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260801',
        '20260803',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.612-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260801'
            AND a.DataFim = '20260803'
      );

    -- Rubens Torres Deolindo | SOE III | Férias | 01/08/2026 a 10/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260801',
        '20260810',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.812-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260801'
            AND a.DataFim = '20260810'
      );

    -- Bruno Alves Bezerra Silva | SOR | Férias | 03/08/2026 a 12/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260803',
        '20260812',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260803'
            AND a.DataFim = '20260812'
      );

    -- Josué Carvalho da Costa | SOE I | Férias | 03/08/2026 a 12/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260803',
        '20260812',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.637-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260803'
            AND a.DataFim = '20260812'
      );

    -- Alberto Ganzaroli Neto | SOE II | Férias | 04/08/2026 a 13/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260804',
        '20260813',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.676-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260804'
            AND a.DataFim = '20260813'
      );

    -- Gabriel Arana da Silva | SOE III | Férias | 05/08/2026 a 14/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260805',
        '20260814',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.229-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260805'
            AND a.DataFim = '20260814'
      );

    -- Silvestre Milhomem Amaral | SI | Férias | 05/08/2026 a 14/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260805',
        '20260814',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '35.381-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260805'
            AND a.DataFim = '20260814'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 05/08/2026 a 14/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260805',
        '20260814',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260805'
            AND a.DataFim = '20260814'
      );

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 06/08/2026 a 15/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260806',
        '20260815',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.809-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260806'
            AND a.DataFim = '20260815'
      );

    -- Thallys Mendes Passos | SOE II | Abono de ponto anual | 08/08/2026 a 09/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260808',
        '20260809',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.369-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260808'
            AND a.DataFim = '20260809'
      );

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 09/08/2026 a 18/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260809',
        '20260818',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.719.773-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260809'
            AND a.DataFim = '20260818'
      );

    -- Edson Medina de Oliveira | GAB | Jogos Policiais | 11/08/2026 a 13/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        13,
        '20260811',
        '20260813',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '89.260-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 13
            AND a.DataInicio = '20260811'
            AND a.DataFim = '20260813'
      );

    -- Adenauer Dantas Justo | SI | Jogos Policiais | 11/08/2026 a 14/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        13,
        '20260811',
        '20260814',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '36.007-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 13
            AND a.DataInicio = '20260811'
            AND a.DataFim = '20260814'
      );

    -- Daniel Beltrame Faria | SOT | Férias | 11/08/2026 a 20/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260811',
        '20260820',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.205-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260811'
            AND a.DataFim = '20260820'
      );

    -- Marcelo Vasconcelos Dias | SOR | Férias | 12/08/2026 a 21/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260812',
        '20260821',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.856-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260812'
            AND a.DataFim = '20260821'
      );

    -- Hugo Leonardo Garcia Ferreira | SOT | Licença Paternidade | 12/08/2026 a 31/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        15,
        '20260812',
        '20260831',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '234.273-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 15
            AND a.DataInicio = '20260812'
            AND a.DataFim = '20260831'
      );

    -- Rayssa Polianna Silva | SOR | Abono de ponto anual | 14/08/2026 a 14/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260814',
        '20260814',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260814'
            AND a.DataFim = '20260814'
      );

    -- Bruno Lima Aguirra | SOE IV | Férias | 14/08/2026 a 23/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260814',
        '20260823',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.413-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260814'
            AND a.DataFim = '20260823'
      );

    -- Alberto Ganzaroli Neto | SOE II | Abono de ponto anual | 16/08/2026 a 20/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260816',
        '20260820',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.676-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260816'
            AND a.DataFim = '20260820'
      );

    -- Gabriel Arana da Silva | SOE III | Abono de ponto anual | 17/08/2026 a 19/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260817',
        '20260819',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.229-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260817'
            AND a.DataFim = '20260819'
      );

    -- Geovane Ribeiro Mathias | SOR | Férias | 17/08/2026 a 26/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260817',
        '20260826',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.395-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260817'
            AND a.DataFim = '20260826'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 17/08/2026 a 26/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260817',
        '20260826',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260817'
            AND a.DataFim = '20260826'
      );

    -- Rafaela Lopes Andrade | SOC | Férias | 17/08/2026 a 26/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260817',
        '20260826',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.692-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260817'
            AND a.DataFim = '20260826'
      );

    -- Edson Medina de Oliveira | GAB | Férias | 20/08/2026 a 28/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260820',
        '20260828',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '89.260-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260820'
            AND a.DataFim = '20260828'
      );

    -- Antonio Jose Lima | GAB | Abono de ponto anual | 21/08/2026 a 21/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260821',
        '20260821',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.942-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260821'
            AND a.DataFim = '20260821'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 21/08/2026 a 30/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260821',
        '20260830',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260821'
            AND a.DataFim = '20260830'
      );

    -- Alberto Ganzaroli Neto | SOE II | Férias | 24/08/2026 a 02/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260824',
        '20260902',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.676-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260824'
            AND a.DataFim = '20260902'
      );

    -- Pablo Samora Bonifácio Medeiros | SOC | Abono de ponto anual | 26/08/2026 a 28/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260826',
        '20260828',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.631-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260826'
            AND a.DataFim = '20260828'
      );

    -- Frank Rodrigues Ferreira | SOT | Férias | 26/08/2026 a 04/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260826',
        '20260904',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.616-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260826'
            AND a.DataFim = '20260904'
      );

    -- Pedro Rollemberg Mollo | SOE I | Férias | 27/08/2026 a 03/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260827',
        '20260903',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260827'
            AND a.DataFim = '20260903'
      );

    -- Francisco Lanna Guillen | SOE II | Férias | 28/08/2026 a 06/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260828',
        '20260906',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.540-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260828'
            AND a.DataFim = '20260906'
      );

    -- Marcio Romeiro Pereira Junior | SOE IV | Licença para tratamento de saúde própria | 28/08/2026 a 11/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260828',
        '20260911',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.552-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260828'
            AND a.DataFim = '20260911'
      );

    -- Marcio Roberto Valente Caetano | GAB | Abono de aniversário | 29/08/2026 a 29/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        3,
        '20260829',
        '20260829',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.436-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 3
            AND a.DataInicio = '20260829'
            AND a.DataFim = '20260829'
      );

    -- Fabio Silva Piazzarollo | SOE III | Abono de ponto anual | 29/08/2026 a 31/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260829',
        '20260831',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.923-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260829'
            AND a.DataFim = '20260831'
      );

    -- Rayssa Polianna Silva | SOR | Abono de ponto anual | 31/08/2026 a 31/08/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260831',
        '20260831',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260831'
            AND a.DataFim = '20260831'
      );

    -- Pablo Samora Bonifácio Medeiros | SOC | Abono de ponto anual | 31/08/2026 a 01/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260831',
        '20260901',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.631-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260831'
            AND a.DataFim = '20260901'
      );

    -- Raphael Rodolfo Torres Gaia | SOR | Abono de ponto anual | 31/08/2026 a 01/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260831',
        '20260901',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.647-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260831'
            AND a.DataFim = '20260901'
      );

    -- Felipe Sousa Farias | SOR | Férias | 31/08/2026 a 07/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260831',
        '20260907',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260831'
            AND a.DataFim = '20260907'
      );

    -- Marcelo Nunes | SOT | Férias | 31/08/2026 a 09/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260831',
        '20260909',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.228-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260831'
            AND a.DataFim = '20260909'
      );


-- ==================== SETEMBRO/2026 ====================

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 03/09/2026 a 12/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260903',
        '20260912',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.462-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260903'
            AND a.DataFim = '20260912'
      );

    -- Anderson Benevides Valença | SOE IV | Férias | 03/09/2026 a 17/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260903',
        '20260917',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.295-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260903'
            AND a.DataFim = '20260917'
      );

    -- Sidney da Silva de Oliveira | SOE II | Férias | 05/09/2026 a 15/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260905',
        '20260915',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.929-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260905'
            AND a.DataFim = '20260915'
      );

    -- Klebson Alves Fonseca | SOE III | Abono de ponto anual | 06/09/2026 a 07/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260906',
        '20260907',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.929-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260906'
            AND a.DataFim = '20260907'
      );

    -- Pedro Rollemberg Mollo | SOE I | Férias | 08/09/2026 a 09/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260908',
        '20260909',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260908'
            AND a.DataFim = '20260909'
      );

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 08/09/2026 a 10/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260908',
        '20260910',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.740-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260908'
            AND a.DataFim = '20260910'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 08/09/2026 a 13/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260908',
        '20260913',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260908'
            AND a.DataFim = '20260913'
      );

    -- Cleuber Medeiros Guimarães | SOE III | Abono de ponto anual | 10/09/2026 a 11/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260910',
        '20260911',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.393-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260910'
            AND a.DataFim = '20260911'
      );

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 10/09/2026 a 19/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260910',
        '20260919',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.719.773-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260910'
            AND a.DataFim = '20260919'
      );

    -- Daniel Beltrame Faria | SOT | Abono de ponto anual | 11/09/2026 a 11/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260911',
        '20260911',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.205-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260911'
            AND a.DataFim = '20260911'
      );

    -- Marcio Roberto Valente Caetano | GAB | Férias | 11/09/2026 a 20/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260911',
        '20260920',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.436-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260911'
            AND a.DataFim = '20260920'
      );

    -- Pedro Rollemberg Mollo | SOE I | Licença para tratamento de saúde própria | 11/09/2026 a 25/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260911',
        '20260925',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260911'
            AND a.DataFim = '20260925'
      );

    -- Wagner Alves Gonçalves Nogueira | SOR | Licença para tratamento de saúde própria | 14/09/2026 a 01/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260914',
        '20261001',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.321-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260914'
            AND a.DataFim = '20261001'
      );

    -- Marcio Romeiro Pereira Junior | SOE IV | Licença para tratamento de saúde própria | 14/09/2026 a 13/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        8,
        '20260914',
        '20261013',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.552-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 8
            AND a.DataInicio = '20260914'
            AND a.DataFim = '20261013'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Abono de ponto anual | 17/09/2026 a 18/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260917',
        '20260918',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260917'
            AND a.DataFim = '20260918'
      );

    -- Fabio Silva Piazzarollo | SOE III | Abono de ponto anual | 18/09/2026 a 19/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260918',
        '20260919',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.923-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260918'
            AND a.DataFim = '20260919'
      );

    -- Sidartha Souza de Quevedo | SOE I | Férias | 20/09/2026 a 29/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260920',
        '20260929',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '238.906-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260920'
            AND a.DataFim = '20260929'
      );

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 21/09/2026 a 22/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260921',
        '20260922',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '234.273-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260921'
            AND a.DataFim = '20260922'
      );

    -- Fabio Silva Piazzarollo | SOE III | Férias | 22/09/2026 a 01/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260922',
        '20261001',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.923-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260922'
            AND a.DataFim = '20261001'
      );

    -- Marcos Davila Teixeira | SOE IV | Férias | 23/09/2026 a 12/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260923',
        '20261012',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '189.289-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260923'
            AND a.DataFim = '20261012'
      );

    -- Max Macedo Cavalcante | SOE II | Abono de ponto anual | 24/09/2026 a 26/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260924',
        '20260926',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.722.557-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260924'
            AND a.DataFim = '20260926'
      );

    -- Pedro Rollemberg Mollo | SOE I | Abono de ponto anual | 28/09/2026 a 30/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260928',
        '20260930',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260928'
            AND a.DataFim = '20260930'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Jogos Policiais | 28/09/2026 a 30/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        13,
        '20260928',
        '20260930',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 13
            AND a.DataInicio = '20260928'
            AND a.DataFim = '20260930'
      );

    -- Honney Cordeiro | SOE II | Jogos Policiais | 28/09/2026 a 30/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        13,
        '20260928',
        '20260930',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.764-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 13
            AND a.DataInicio = '20260928'
            AND a.DataFim = '20260930'
      );

    -- Santilhento Marcos da Silva | SOR | Férias | 28/09/2026 a 12/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260928',
        '20261012',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.672-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260928'
            AND a.DataFim = '20261012'
      );

    -- Max Macedo Cavalcante | SOE II | Abono de ponto anual | 29/09/2026 a 30/09/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20260929',
        '20260930',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.722.557-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20260929'
            AND a.DataFim = '20260930'
      );

    -- Rafaela Lopes Andrade | SOC | Férias | 30/09/2026 a 09/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20260930',
        '20261009',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.692-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20260930'
            AND a.DataFim = '20261009'
      );


-- ==================== OUTUBRO/2026 ====================

    -- Sidartha Souza de Quevedo | SOE I | Abono de ponto anual | 02/10/2026 a 04/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261002',
        '20261004',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '238.906-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261002'
            AND a.DataFim = '20261004'
      );

    -- Leandro de Oliveira Sampaio | GAB | Férias | 02/10/2026 a 11/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261002',
        '20261011',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.545-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261002'
            AND a.DataFim = '20261011'
      );

    -- Higor Barbosa de Souza | SOE I | Férias | 04/10/2026 a 23/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261004',
        '20261023',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.222-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261004'
            AND a.DataFim = '20261023'
      );

    -- Mauricio Victor Cassis | SOR | Abono de ponto anual | 05/10/2026 a 08/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261005',
        '20261008',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261005'
            AND a.DataFim = '20261008'
      );

    -- Roberto Jean Philippe Corrêa | SOR | Abono de ponto anual | 05/10/2026 a 09/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261005',
        '20261009',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.752-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261005'
            AND a.DataFim = '20261009'
      );

    -- Paulo Roberto Tavares Brandão | GAB | Abono de ponto anual | 05/10/2026 a 09/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261005',
        '20261009',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.224-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261005'
            AND a.DataFim = '20261009'
      );

    -- Igor Thiago Maux Lopes | SI | Férias | 05/10/2026 a 14/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261005',
        '20261014',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.112-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261005'
            AND a.DataFim = '20261014'
      );

    -- Tiago Resende Brant | SOT | Férias | 05/10/2026 a 14/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261005',
        '20261014',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.130-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261005'
            AND a.DataFim = '20261014'
      );

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 05/10/2026 a 14/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261005',
        '20261014',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.270-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261005'
            AND a.DataFim = '20261014'
      );

    -- Pedro Rollemberg Mollo | SOE I | Abono de ponto anual | 06/10/2026 a 07/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261006',
        '20261007',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261006'
            AND a.DataFim = '20261007'
      );

    -- Sanlac Machado da Cunha | SOC | Férias | 06/10/2026 a 15/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261006',
        '20261015',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.160-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261006'
            AND a.DataFim = '20261015'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Abono de ponto anual | 08/10/2026 a 09/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261008',
        '20261009',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261008'
            AND a.DataFim = '20261009'
      );

    -- Antonio Jose Lima | GAB | Abono de ponto anual | 10/10/2026 a 13/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261010',
        '20261013',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.942-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261010'
            AND a.DataFim = '20261013'
      );

    -- Franthiesco L. Fernandes Nunes | SOE III | Férias | 12/10/2026 a 26/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261012',
        '20261026',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.271-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261012'
            AND a.DataFim = '20261026'
      );

    -- Wagner Alves Gonçalves Nogueira | SOR | Abono de aniversário | 13/10/2026 a 13/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        3,
        '20261013',
        '20261013',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.321-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 3
            AND a.DataInicio = '20261013'
            AND a.DataFim = '20261013'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Abono de ponto anual | 13/10/2026 a 13/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261013',
        '20261013',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261013'
            AND a.DataFim = '20261013'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 13/10/2026 a 16/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261013',
        '20261016',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261013'
            AND a.DataFim = '20261016'
      );

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 13/10/2026 a 22/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261013',
        '20261022',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.631-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261013'
            AND a.DataFim = '20261022'
      );

    -- Leandro de Oliveira Sampaio | GAB | Férias | 13/10/2026 a 22/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261013',
        '20261022',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.545-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261013'
            AND a.DataFim = '20261022'
      );

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 13/10/2026 a 30/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261013',
        '20261030',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '234.273-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261013'
            AND a.DataFim = '20261030'
      );

    -- Marcelo Thomas | GAB | Férias | 14/10/2026 a 23/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261014',
        '20261023',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.720-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261014'
            AND a.DataFim = '20261023'
      );

    -- Tilia Rumi Okahara | SAAEI | Férias | 14/10/2026 a 23/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261014',
        '20261023',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '63.236-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261014'
            AND a.DataFim = '20261023'
      );

    -- Ananias Batista Gomes Junior | GAB | Férias | 14/10/2026 a 23/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261014',
        '20261023',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.742-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261014'
            AND a.DataFim = '20261023'
      );

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 14/10/2026 a 28/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261014',
        '20261028',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.321-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261014'
            AND a.DataFim = '20261028'
      );

    -- Tiago Resende Brant | SOT | Férias | 19/10/2026 a 28/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261019',
        '20261028',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.130-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261019'
            AND a.DataFim = '20261028'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 19/10/2026 a 28/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261019',
        '20261028',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261019'
            AND a.DataFim = '20261028'
      );

    -- Edson Medina de Oliveira | GAB | Férias | 19/10/2026 a 28/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261019',
        '20261028',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '89.260-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261019'
            AND a.DataFim = '20261028'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Jogos Policiais | 20/10/2026 a 22/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        13,
        '20261020',
        '20261022',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 13
            AND a.DataInicio = '20261020'
            AND a.DataFim = '20261022'
      );

    -- Gabriel Arana da Silva | SOE III | Férias | 20/10/2026 a 29/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261020',
        '20261029',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.229-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261020'
            AND a.DataFim = '20261029'
      );

    -- Honney Cordeiro | SOE II | Abono de ponto anual | 23/10/2026 a 24/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261023',
        '20261024',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.764-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261023'
            AND a.DataFim = '20261024'
      );

    -- Cristiano Jardim de Gusmão | SOE IV | Abono de ponto anual | 25/10/2026 a 27/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261025',
        '20261027',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.462-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261025'
            AND a.DataFim = '20261027'
      );

    -- Pericles M. de Rezende Junior | SOT | Abono de ponto anual | 26/10/2026 a 27/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261026',
        '20261027',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.888-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261026'
            AND a.DataFim = '20261027'
      );

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 26/10/2026 a 01/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261026',
        '20261101',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.740-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261026'
            AND a.DataFim = '20261101'
      );

    -- Sidartha Souza de Quevedo | SOE I | Férias | 26/10/2026 a 04/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261026',
        '20261104',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '238.906-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261026'
            AND a.DataFim = '20261104'
      );

    -- Max Macedo Cavalcante | SOE II | Férias | 27/10/2026 a 10/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261027',
        '20261110',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.722.557-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261027'
            AND a.DataFim = '20261110'
      );

    -- Felipe Sousa Farias | SOR | Férias | 28/10/2026 a 29/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261028',
        '20261029',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261028'
            AND a.DataFim = '20261029'
      );

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 28/10/2026 a 06/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261028',
        '20261106',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.719.773-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261028'
            AND a.DataFim = '20261106'
      );

    -- Pericles M. de Rezende Junior | SOT | Abono de ponto anual | 29/10/2026 a 30/10/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261029',
        '20261030',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.888-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261029'
            AND a.DataFim = '20261030'
      );

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 29/10/2026 a 07/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261029',
        '20261107',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.552-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261029'
            AND a.DataFim = '20261107'
      );


-- ==================== NOVEMBRO/2026 ====================

    -- Ricardo Santos Textor | GAB | Férias | 01/11/2026 a 10/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261101',
        '20261110',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261101'
            AND a.DataFim = '20261110'
      );

    -- Klebson Alves Fonseca | SOE III | Férias | 01/11/2026 a 10/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261101',
        '20261110',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.929-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261101'
            AND a.DataFim = '20261110'
      );

    -- Antonio Jose Lima | GAB | Férias | 01/11/2026 a 30/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261101',
        '20261130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.942-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261101'
            AND a.DataFim = '20261130'
      );

    -- Vanderlei Ferreira Dutra | SOE IV | Abono de ponto anual | 02/11/2026 a 06/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261102',
        '20261106',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.682-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261102'
            AND a.DataFim = '20261106'
      );

    -- Felipe Sousa Farias | SOR | Abono de ponto anual | 03/11/2026 a 06/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261103',
        '20261106',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261103'
            AND a.DataFim = '20261106'
      );

    -- Marcelo Vasconcelos Dias | SOR | Férias | 03/11/2026 a 12/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261103',
        '20261112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.856-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261103'
            AND a.DataFim = '20261112'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 03/11/2026 a 12/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261103',
        '20261112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261103'
            AND a.DataFim = '20261112'
      );

    -- Ruy Lins Wanderley Neto | SOT | Férias | 03/11/2026 a 12/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261103',
        '20261112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.110-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261103'
            AND a.DataFim = '20261112'
      );

    -- Daniel Beltrame Faria | SOT | Férias | 03/11/2026 a 12/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261103',
        '20261112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.205-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261103'
            AND a.DataFim = '20261112'
      );

    -- Luis Ricardo Brasilino | SOE I | Férias | 03/11/2026 a 12/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261103',
        '20261112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.650-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261103'
            AND a.DataFim = '20261112'
      );

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 03/11/2026 a 12/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261103',
        '20261112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.224-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261103'
            AND a.DataFim = '20261112'
      );

    -- Rebeca Severo Limongi | SAAEI | Férias | 03/11/2026 a 17/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261103',
        '20261117',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.251-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261103'
            AND a.DataFim = '20261117'
      );

    -- Aurelio Gleria Cavalcante | SOC | Férias | 03/11/2026 a 17/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261103',
        '20261117',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.058-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261103'
            AND a.DataFim = '20261117'
      );

    -- Adenauer Dantas Justo | SI | Férias | 04/11/2026 a 13/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261104',
        '20261113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '36.007-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261104'
            AND a.DataFim = '20261113'
      );

    -- Sidney da Silva de Oliveira | SOE II | Férias | 04/11/2026 a 18/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261104',
        '20261118',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.929-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261104'
            AND a.DataFim = '20261118'
      );

    -- Rubens Torres Deolindo | SOE III | Férias | 09/11/2026 a 18/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261109',
        '20261118',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.812-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261109'
            AND a.DataFim = '20261118'
      );

    -- Felipe Chiarelli Linhares Titoneli | SOT | Férias | 09/11/2026 a 28/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261109',
        '20261128',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.534-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261109'
            AND a.DataFim = '20261128'
      );

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 10/11/2026 a 19/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261110',
        '20261119',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '229.161-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261110'
            AND a.DataFim = '20261119'
      );

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 12/11/2026 a 10/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261112',
        '20261210',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.647-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261112'
            AND a.DataFim = '20261210'
      );

    -- Wanderson Gomes dos Santos | SOE III | Férias | 13/11/2026 a 12/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261113',
        '20261212',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.612-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261113'
            AND a.DataFim = '20261212'
      );

    -- Lincon Massahiro Takano | SOE IV | Férias | 14/11/2026 a 23/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261114',
        '20261123',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '47.567-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261114'
            AND a.DataFim = '20261123'
      );

    -- Honney Cordeiro | SOE II | Abono de ponto anual | 16/11/2026 a 18/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261116',
        '20261118',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.764-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261116'
            AND a.DataFim = '20261118'
      );

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 16/11/2026 a 25/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261116',
        '20261125',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.740-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261116'
            AND a.DataFim = '20261125'
      );

    -- Mauricio Victor Cassis | SOR | Férias | 16/11/2026 a 25/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261116',
        '20261125',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261116'
            AND a.DataFim = '20261125'
      );

    -- Marcelo Nunes | SOT | Férias | 16/11/2026 a 25/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261116',
        '20261125',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.228-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261116'
            AND a.DataFim = '20261125'
      );

    -- Silvestre Milhomem Amaral | SI | Férias | 16/11/2026 a 25/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261116',
        '20261125',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '35.381-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261116'
            AND a.DataFim = '20261125'
      );

    -- Rebeca Severo Limongi | SAAEI | Abono de ponto anual | 18/11/2026 a 19/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261118',
        '20261119',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.251-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261118'
            AND a.DataFim = '20261119'
      );

    -- Pedro Rollemberg Mollo | SOE I | Férias | 19/11/2026 a 28/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261119',
        '20261128',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261119'
            AND a.DataFim = '20261128'
      );

    -- Bruno Alves Bezerra Silva | SOR | Férias | 21/11/2026 a 30/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261121',
        '20261130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261121'
            AND a.DataFim = '20261130'
      );

    -- Geovane Ribeiro Mathias | SOR | Licença para tratar de interesse particular | 23/11/2026 a 23/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        6,
        '20261123',
        '20261123',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.395-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 6
            AND a.DataInicio = '20261123'
            AND a.DataFim = '20261123'
      );

    -- Rebeca Severo Limongi | SAAEI | Abono de ponto anual | 23/11/2026 a 25/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261123',
        '20261125',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.251-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261123'
            AND a.DataFim = '20261125'
      );

    -- Ricardo Santos Textor | SOC | Férias | 23/11/2026 a 02/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261123',
        '20261202',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261123'
            AND a.DataFim = '20261202'
      );

    -- Geovane Ribeiro Mathias | SOR | Férias | 24/11/2026 a 03/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261124',
        '20261203',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.395-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261124'
            AND a.DataFim = '20261203'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 25/11/2026 a 04/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261125',
        '20261204',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261125'
            AND a.DataFim = '20261204'
      );

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 26/11/2026 a 30/11/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261126',
        '20261130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.047-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261126'
            AND a.DataFim = '20261130'
      );

    -- Cristiano Pereira de Jesus | SOE II | Férias | 28/11/2026 a 07/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261128',
        '20261207',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.212-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261128'
            AND a.DataFim = '20261207'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 29/11/2026 a 08/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261129',
        '20261208',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261129'
            AND a.DataFim = '20261208'
      );

    -- Juliano Dantas Bueno | SOT | Férias | 30/11/2026 a 09/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261130',
        '20261209',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '225.345-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261130'
            AND a.DataFim = '20261209'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 30/11/2026 a 09/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261130',
        '20261209',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261130'
            AND a.DataFim = '20261209'
      );

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 30/11/2026 a 09/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261130',
        '20261209',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.752-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261130'
            AND a.DataFim = '20261209'
      );

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 30/11/2026 a 09/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261130',
        '20261209',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.809-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261130'
            AND a.DataFim = '20261209'
      );


-- ==================== DEZEMBRO/2026 ====================

    -- Marcio Roberto Valente Caetano | GAB | Férias | 01/12/2026 a 09/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261201',
        '20261209',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.436-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261201'
            AND a.DataFim = '20261209'
      );

    -- Rayssa Polianna Silva | SOR | Férias | 01/12/2026 a 10/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261201',
        '20261210',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261201'
            AND a.DataFim = '20261210'
      );

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 01/12/2026 a 10/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261201',
        '20261210',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.740-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261201'
            AND a.DataFim = '20261210'
      );

    -- Josué Carvalho da Costa | SOE I | Férias | 01/12/2026 a 10/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261201',
        '20261210',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.637-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261201'
            AND a.DataFim = '20261210'
      );

    -- Cinthia Versiani Pontes | SOC | Férias | 01/12/2026 a 10/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261201',
        '20261210',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.639-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261201'
            AND a.DataFim = '20261210'
      );

    -- Tilia Rumi Okahara | SAAEI | Férias | 01/12/2026 a 10/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261201',
        '20261210',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '63.236-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261201'
            AND a.DataFim = '20261210'
      );

    -- Eduardo Cosme Carvalho da Silva | SOE I | Férias | 01/12/2026 a 10/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261201',
        '20261210',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.826-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261201'
            AND a.DataFim = '20261210'
      );

    -- Thallys Mendes Passos | SOE II | Férias | 06/12/2026 a 04/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261206',
        '20270104',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.369-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261206'
            AND a.DataFim = '20270104'
      );

    -- Francisco Lanna Guillen | SOE II | Abono de ponto anual | 10/12/2026 a 14/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261210',
        '20261214',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.540-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261210'
            AND a.DataFim = '20261214'
      );

    -- Raphael Rodolfo Torres Gaia | SOR | Abono de ponto anual | 11/12/2026 a 11/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261211',
        '20261211',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.647-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261211'
            AND a.DataFim = '20261211'
      );

    -- Daniel Lebrão Arruda | SOE IV | Férias | 12/12/2026 a 10/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261212',
        '20270110',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.600-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261212'
            AND a.DataFim = '20270110'
      );

    -- Raphael Rodolfo Torres Gaia | SOR | Abono de ponto anual | 14/12/2026 a 15/12/2026
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20261214',
        '20261215',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.647-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20261214'
            AND a.DataFim = '20261215'
      );

    -- Renato Bizinoto Molas | SOE I | Férias | 14/12/2026 a 12/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261214',
        '20270112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.855-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261214'
            AND a.DataFim = '20270112'
      );

    -- Antonio Jose Lima | GAB | Férias | 31/12/2026 a 29/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20261231',
        '20270129',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.942-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20261231'
            AND a.DataFim = '20270129'
      );


-- ==================== JANEIRO/2027 ====================

    -- Vanderlei Ferreira Dutra | SOE IV | Férias | 01/01/2027 a 04/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270101',
        '20270104',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.682-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270101'
            AND a.DataFim = '20270104'
      );

    -- Ananias Batista Gomes Junior | GAB | Férias | 01/01/2027 a 06/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270101',
        '20270106',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.742-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270101'
            AND a.DataFim = '20270106'
      );

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 01/01/2027 a 10/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270101',
        '20270110',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.647-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270101'
            AND a.DataFim = '20270110'
      );

    -- Luiz Cesar Mendes de Almeida | SOE III | Férias | 01/01/2027 a 29/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270101',
        '20270129',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.066-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270101'
            AND a.DataFim = '20270129'
      );

    -- Patricia Araujo Ribeiro | SAAEI | Abono de ponto anual | 04/01/2027 a 04/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        2,
        '20270104',
        '20270104',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.405-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 2
            AND a.DataInicio = '20270104'
            AND a.DataFim = '20270104'
      );

    -- Klebson Alves Fonseca | SOE III | Férias | 04/01/2027 a 13/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270104',
        '20270113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.929-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270104'
            AND a.DataFim = '20270113'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 04/01/2027 a 13/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270104',
        '20270113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270104'
            AND a.DataFim = '20270113'
      );

    -- Ruy Lins Wanderley Neto | SOT | Férias | 04/01/2027 a 13/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270104',
        '20270113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.110-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270104'
            AND a.DataFim = '20270113'
      );

    -- Silvestre Milhomem Amaral | SI | Férias | 04/01/2027 a 13/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270104',
        '20270113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '35.381-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270104'
            AND a.DataFim = '20270113'
      );

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 04/01/2027 a 13/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270104',
        '20270113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.752-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270104'
            AND a.DataFim = '20270113'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 04/01/2027 a 13/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270104',
        '20270113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270104'
            AND a.DataFim = '20270113'
      );

    -- Aurelio Gleria Cavalcante | SOC | Férias | 04/01/2027 a 18/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270104',
        '20270118',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.058-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270104'
            AND a.DataFim = '20270118'
      );

    -- Marcelo Thomas | GAB | Férias | 04/01/2027 a 31/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270104',
        '20270131',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.720-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270104'
            AND a.DataFim = '20270131'
      );

    -- Diego Madureira Rodrigues | SOE I | Férias | 06/01/2027 a 25/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270106',
        '20270125',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '186.000-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270106'
            AND a.DataFim = '20270125'
      );

    -- Sidney da Silva de Oliveira | SOE II | Férias | 11/01/2027 a 20/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270111',
        '20270120',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.929-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270111'
            AND a.DataFim = '20270120'
      );

    -- Max Macedo Cavalcante | SOE II | Férias | 11/01/2027 a 20/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270111',
        '20270120',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.722.557-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270111'
            AND a.DataFim = '20270120'
      );

    -- Frank Rodrigues Ferreira | SOT | Férias | 11/01/2027 a 20/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270111',
        '20270120',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.616-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270111'
            AND a.DataFim = '20270120'
      );

    -- Leandro de Oliveira Sampaio | GAB | Férias | 11/01/2027 a 20/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270111',
        '20270120',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.545-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270111'
            AND a.DataFim = '20270120'
      );

    -- Marcos Davila Teixeira | SOE IV | Férias | 13/01/2027 a 22/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270113',
        '20270122',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '189.289-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270113'
            AND a.DataFim = '20270122'
      );

    -- Bruno Lima Aguirra | SOE IV | Férias | 13/01/2027 a 27/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270113',
        '20270127',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.413-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270113'
            AND a.DataFim = '20270127'
      );

    -- Josué Carvalho da Costa | SOE I | Férias | 14/01/2027 a 23/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270114',
        '20270123',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.637-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270114'
            AND a.DataFim = '20270123'
      );

    -- Ricardo Santos Textor | SOC | Férias | 18/01/2027 a 27/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270118',
        '20270127',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270118'
            AND a.DataFim = '20270127'
      );

    -- Mauricio Victor Cassis | SOR | Férias | 18/01/2027 a 27/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270118',
        '20270127',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270118'
            AND a.DataFim = '20270127'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 18/01/2027 a 27/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270118',
        '20270127',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270118'
            AND a.DataFim = '20270127'
      );

    -- Juliano Dantas Bueno | SOT | Férias | 20/01/2027 a 29/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270120',
        '20270129',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '225.345-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270120'
            AND a.DataFim = '20270129'
      );

    -- Fabio Silva Piazzarollo | SOE III | Férias | 20/01/2027 a 29/01/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270120',
        '20270129',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.923-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270120'
            AND a.DataFim = '20270129'
      );

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 25/01/2027 a 03/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270125',
        '20270203',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.552-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270125'
            AND a.DataFim = '20270203'
      );

    -- Sanlac Machado da Cunha | SOC | Férias | 25/01/2027 a 03/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270125',
        '20270203',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.160-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270125'
            AND a.DataFim = '20270203'
      );

    -- Sidartha Souza de Quevedo | SOE I | Férias | 26/01/2027 a 04/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270126',
        '20270204',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '238.906-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270126'
            AND a.DataFim = '20270204'
      );

    -- Igor Thiago Maux Lopes | SI | Férias | 27/01/2027 a 05/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270127',
        '20270205',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.112-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270127'
            AND a.DataFim = '20270205'
      );

    -- Bruno Alves Bezerra Silva | SOR | Férias | 27/01/2027 a 05/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270127',
        '20270205',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270127'
            AND a.DataFim = '20270205'
      );

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 28/01/2027 a 06/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270128',
        '20270206',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.393-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270128'
            AND a.DataFim = '20270206'
      );

    -- Anderson Benevides Valença | SOE IV | Férias | 29/01/2027 a 12/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270129',
        '20270212',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.295-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270129'
            AND a.DataFim = '20270212'
      );


-- ==================== FEVEREIRO/2027 ====================

    -- Alberto Ganzaroli Neto | SOE II | Férias | 04/02/2027 a 13/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270204',
        '20270213',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.676-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270204'
            AND a.DataFim = '20270213'
      );

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 04/02/2027 a 13/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270204',
        '20270213',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.047-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270204'
            AND a.DataFim = '20270213'
      );

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 08/02/2027 a 17/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270208',
        '20270217',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.224-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270208'
            AND a.DataFim = '20270217'
      );

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 10/02/2027 a 19/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270210',
        '20270219',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.631-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270210'
            AND a.DataFim = '20270219'
      );

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 10/02/2027 a 19/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270210',
        '20270219',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '234.273-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270210'
            AND a.DataFim = '20270219'
      );

    -- Rayssa Polianna Silva | SOR | Férias | 11/02/2027 a 20/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270211',
        '20270220',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270211'
            AND a.DataFim = '20270220'
      );

    -- Marcelo Nunes | SOT | Férias | 11/02/2027 a 20/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270211',
        '20270220',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.228-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270211'
            AND a.DataFim = '20270220'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 15/02/2027 a 24/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270215',
        '20270224',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270215'
            AND a.DataFim = '20270224'
      );

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 15/02/2027 a 24/02/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270215',
        '20270224',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.270-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270215'
            AND a.DataFim = '20270224'
      );


-- ==================== MARÇO/2027 ====================

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 01/03/2027 a 10/03/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270301',
        '20270310',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.321-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270301'
            AND a.DataFim = '20270310'
      );

    -- Rafaela Lopes Andrade | SOC | Férias | 01/03/2027 a 10/03/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270301',
        '20270310',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.692-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270301'
            AND a.DataFim = '20270310'
      );

    -- Wanderson Gomes dos Santos | SOE III | Férias | 05/03/2027 a 14/03/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270305',
        '20270314',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.612-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270305'
            AND a.DataFim = '20270314'
      );

    -- Rubens Torres Deolindo | SOE III | Férias | 13/03/2027 a 22/03/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270313',
        '20270322',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.812-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270313'
            AND a.DataFim = '20270322'
      );

    -- Patricia Araujo Ribeiro | SAAEI | Férias | 15/03/2027 a 24/03/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270315',
        '20270324',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.405-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270315'
            AND a.DataFim = '20270324'
      );

    -- Ricardo Santos Textor | SOC | Férias | 15/03/2027 a 30/03/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270315',
        '20270330',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270315'
            AND a.DataFim = '20270330'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 16/03/2027 a 25/03/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270316',
        '20270325',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270316'
            AND a.DataFim = '20270325'
      );

    -- Pericles M. de Rezende Junior | SOT | Férias | 31/03/2027 a 09/04/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270331',
        '20270409',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.888-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270331'
            AND a.DataFim = '20270409'
      );


-- ==================== ABRIL/2027 ====================

    -- Daniel Beltrame Faria | SOT | Férias | 05/04/2027 a 14/04/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270405',
        '20270414',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.205-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270405'
            AND a.DataFim = '20270414'
      );

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 06/04/2027 a 15/04/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270406',
        '20270415',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.719.773-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270406'
            AND a.DataFim = '20270415'
      );

    -- Luis Ricardo Brasilino | SOE I | Férias | 12/04/2027 a 21/04/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270412',
        '20270421',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.650-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270412'
            AND a.DataFim = '20270421'
      );

    -- Ruy Lins Wanderley Neto | SOT | Férias | 14/04/2027 a 23/04/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270414',
        '20270423',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.110-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270414'
            AND a.DataFim = '20270423'
      );

    -- Gabriel Arana da Silva | SOE III | Férias | 18/04/2027 a 27/04/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270418',
        '20270427',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.229-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270418'
            AND a.DataFim = '20270427'
      );

    -- Cinthia Versiani Pontes | SOC | Férias | 19/04/2027 a 08/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270419',
        '20270508',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.639-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270419'
            AND a.DataFim = '20270508'
      );

    -- Higor Barbosa de Souza | SOE I | Férias | 24/04/2027 a 03/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270424',
        '20270503',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.222-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270424'
            AND a.DataFim = '20270503'
      );

    -- Felipe Sousa Farias | SOR | Férias | 26/04/2027 a 05/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270426',
        '20270505',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270426'
            AND a.DataFim = '20270505'
      );

    -- Marcelo Vasconcelos Dias | SOR | Férias | 26/04/2027 a 05/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270426',
        '20270505',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.856-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270426'
            AND a.DataFim = '20270505'
      );


-- ==================== MAIO/2027 ====================

    -- Geovane Ribeiro Mathias | SOR | Férias | 10/05/2027 a 19/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270510',
        '20270519',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.395-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270510'
            AND a.DataFim = '20270519'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 10/05/2027 a 19/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270510',
        '20270519',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270510'
            AND a.DataFim = '20270519'
      );

    -- Tiago Resende Brant | SOT | Férias | 10/05/2027 a 19/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270510',
        '20270519',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.130-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270510'
            AND a.DataFim = '20270519'
      );

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 17/05/2027 a 26/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270517',
        '20270526',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '229.161-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270517'
            AND a.DataFim = '20270526'
      );

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 17/05/2027 a 26/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270517',
        '20270526',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '234.273-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270517'
            AND a.DataFim = '20270526'
      );

    -- Juliano Dantas Bueno | SOT | Férias | 19/05/2027 a 28/05/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270519',
        '20270528',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '225.345-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270519'
            AND a.DataFim = '20270528'
      );

    -- Luis Ricardo Brasilino | SOE I | Férias | 26/05/2027 a 04/06/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270526',
        '20270604',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.650-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270526'
            AND a.DataFim = '20270604'
      );

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 31/05/2027 a 09/06/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270531',
        '20270609',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.631-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270531'
            AND a.DataFim = '20270609'
      );

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 31/05/2027 a 09/06/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270531',
        '20270609',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.740-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270531'
            AND a.DataFim = '20270609'
      );

    -- Santilhento Marcos da Silva | SOR | Férias | 31/05/2027 a 14/06/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270531',
        '20270614',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.672-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270531'
            AND a.DataFim = '20270614'
      );


-- ==================== JUNHO/2027 ====================

    -- Rubens Torres Deolindo | SOE III | Férias | 01/06/2027 a 10/06/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270601',
        '20270610',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.812-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270601'
            AND a.DataFim = '20270610'
      );

    -- Wanderson Gomes dos Santos | SOE III | Férias | 09/06/2027 a 18/06/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270609',
        '20270618',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.612-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270609'
            AND a.DataFim = '20270618'
      );

    -- Pedro Rollemberg Mollo | SOE I | Férias | 23/06/2027 a 02/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270623',
        '20270702',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270623'
            AND a.DataFim = '20270702'
      );

    -- Sidney da Silva de Oliveira | SOE II | Férias | 28/06/2027 a 07/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270628',
        '20270707',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.929-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270628'
            AND a.DataFim = '20270707'
      );

    -- Bruno Alves Bezerra Silva | SOR | Férias | 30/06/2027 a 09/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270630',
        '20270709',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270630'
            AND a.DataFim = '20270709'
      );


-- ==================== JULHO/2027 ====================

    -- Sidartha Souza de Quevedo | SOE I | Férias | 01/07/2027 a 10/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270701',
        '20270710',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '238.906-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270701'
            AND a.DataFim = '20270710'
      );

    -- Antonio Jose Lima | GAB | Férias | 01/07/2027 a 30/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270701',
        '20270730',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.942-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270701'
            AND a.DataFim = '20270730'
      );

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 05/07/2027 a 14/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270705',
        '20270714',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.752-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270705'
            AND a.DataFim = '20270714'
      );

    -- Adenauer Dantas Justo da SI | SI | Férias | 05/07/2027 a 19/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270705',
        '20270719',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '36.007-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270705'
            AND a.DataFim = '20270719'
      );

    -- Max Macedo Cavalcante | SOE II | Férias | 06/07/2027 a 15/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270706',
        '20270715',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.722.557-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270706'
            AND a.DataFim = '20270715'
      );

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 07/07/2027 a 16/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270707',
        '20270716',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '229.161-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270707'
            AND a.DataFim = '20270716'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 12/07/2027 a 21/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270712',
        '20270721',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270712'
            AND a.DataFim = '20270721'
      );

    -- Marcelo Vasconcelos Dias | SOR | Férias | 12/07/2027 a 21/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270712',
        '20270721',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.856-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270712'
            AND a.DataFim = '20270721'
      );

    -- Tiago Resende Brant | SOT | Férias | 12/07/2027 a 21/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270712',
        '20270721',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.130-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270712'
            AND a.DataFim = '20270721'
      );

    -- Frank Rodrigues Ferreira | SOT | Férias | 12/07/2027 a 21/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270712',
        '20270721',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.616-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270712'
            AND a.DataFim = '20270721'
      );

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 12/07/2027 a 21/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270712',
        '20270721',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.270-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270712'
            AND a.DataFim = '20270721'
      );

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 12/07/2027 a 21/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270712',
        '20270721',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.224-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270712'
            AND a.DataFim = '20270721'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 12/07/2027 a 21/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270712',
        '20270721',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270712'
            AND a.DataFim = '20270721'
      );

    -- Diego Madureira Rodrigues | SOE I | Férias | 13/07/2027 a 22/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270713',
        '20270722',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '186.000-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270713'
            AND a.DataFim = '20270722'
      );

    -- Ricardo Santos Textor | GAB | Férias | 14/07/2027 a 23/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270714',
        '20270723',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270714'
            AND a.DataFim = '20270723'
      );

    -- Leandro de Oliveira Sampaio | GAB | Férias | 15/07/2027 a 24/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270715',
        '20270724',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.545-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270715'
            AND a.DataFim = '20270724'
      );

    -- Igor Thiago Maux Lopes | SI | Férias | 19/07/2027 a 28/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270719',
        '20270728',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.112-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270719'
            AND a.DataFim = '20270728'
      );

    -- Pericles M. de Rezende Junior | SOT | Férias | 19/07/2027 a 28/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270719',
        '20270728',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.888-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270719'
            AND a.DataFim = '20270728'
      );

    -- Klebson Alves Fonseca | SOE III | Férias | 19/07/2027 a 28/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270719',
        '20270728',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.929-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270719'
            AND a.DataFim = '20270728'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 19/07/2027 a 28/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270719',
        '20270728',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270719'
            AND a.DataFim = '20270728'
      );

    -- Marcos Davila Teixeira | SOE IV | Férias | 20/07/2027 a 29/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270720',
        '20270729',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '189.289-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270720'
            AND a.DataFim = '20270729'
      );

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 20/07/2027 a 29/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270720',
        '20270729',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.552-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270720'
            AND a.DataFim = '20270729'
      );

    -- Mauricio Victor Cassis | SOR | Férias | 20/07/2027 a 29/07/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270720',
        '20270729',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270720'
            AND a.DataFim = '20270729'
      );

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 23/07/2027 a 01/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270723',
        '20270801',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.393-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270723'
            AND a.DataFim = '20270801'
      );

    -- Felipe Sousa Farias | SOR | Férias | 26/07/2027 a 04/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270726',
        '20270804',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270726'
            AND a.DataFim = '20270804'
      );

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 30/07/2027 a 08/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270730',
        '20270808',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.047-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270730'
            AND a.DataFim = '20270808'
      );


-- ==================== AGOSTO/2027 ====================

    -- Anderson Benevides Valença | SOE IV | Férias | 01/08/2027 a 15/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270801',
        '20270815',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.295-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270801'
            AND a.DataFim = '20270815'
      );

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 03/08/2027 a 12/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270803',
        '20270812',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.321-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270803'
            AND a.DataFim = '20270812'
      );

    -- Gabriel Arana da Silva | SOE III | Férias | 04/08/2027 a 13/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270804',
        '20270813',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.229-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270804'
            AND a.DataFim = '20270813'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 05/08/2027 a 14/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270805',
        '20270814',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270805'
            AND a.DataFim = '20270814'
      );

    -- Sidartha Souza de Quevedo | SOE I | Férias | 06/08/2027 a 15/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270806',
        '20270815',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '238.906-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270806'
            AND a.DataFim = '20270815'
      );

    -- Daniel Beltrame Faria | SOT | Férias | 09/08/2027 a 18/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270809',
        '20270818',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.205-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270809'
            AND a.DataFim = '20270818'
      );

    -- Silvestre Milhomem Amaral | SI | Férias | 09/08/2027 a 18/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270809',
        '20270818',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '35.381-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270809'
            AND a.DataFim = '20270818'
      );

    -- Geovane Ribeiro Mathias | SOR | Férias | 16/08/2027 a 25/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270816',
        '20270825',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.395-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270816'
            AND a.DataFim = '20270825'
      );

    -- Alvaro H. M. da Silva Santos | SOR | Férias | 16/08/2027 a 25/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270816',
        '20270825',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.046-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270816'
            AND a.DataFim = '20270825'
      );

    -- Pedro Rollemberg Mollo | SOE I | Férias | 22/08/2027 a 31/08/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270822',
        '20270831',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270822'
            AND a.DataFim = '20270831'
      );

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 23/08/2027 a 01/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270823',
        '20270901',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.740-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270823'
            AND a.DataFim = '20270901'
      );

    -- Rafaela Lopes Andrade | SOC | Férias | 23/08/2027 a 01/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270823',
        '20270901',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.692-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270823'
            AND a.DataFim = '20270901'
      );


-- ==================== SETEMBRO/2027 ====================

    -- Alberto Ganzaroli Neto | SOE II | Férias | 01/09/2027 a 10/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270901',
        '20270910',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.676-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270901'
            AND a.DataFim = '20270910'
      );

    -- Fabio Silva Piazzarollo | SOE III | Férias | 01/09/2027 a 10/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270901',
        '20270910',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.923-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270901'
            AND a.DataFim = '20270910'
      );

    -- Honney Cordeiro | SOE II | Férias | 01/09/2027 a 30/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270901',
        '20270930',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.764-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270901'
            AND a.DataFim = '20270930'
      );

    -- Higor Barbosa de Souza | SOE I | Férias | 03/09/2027 a 12/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270903',
        '20270912',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.222-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270903'
            AND a.DataFim = '20270912'
      );

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 08/09/2027 a 17/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270908',
        '20270917',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '234.273-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270908'
            AND a.DataFim = '20270917'
      );

    -- Rayssa Polianna Silva | SOR | Férias | 11/09/2027 a 17/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270911',
        '20270917',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270911'
            AND a.DataFim = '20270917'
      );

    -- Sanlac Machado da Cunha | SOC | Férias | 13/09/2027 a 22/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270913',
        '20270922',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.160-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270913'
            AND a.DataFim = '20270922'
      );

    -- Cleuber Medeiros Guimarães | SOE III | Férias | 13/09/2027 a 22/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270913',
        '20270922',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.393-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270913'
            AND a.DataFim = '20270922'
      );

    -- Rebeca Severo Limongi | SAAEI | Férias | 14/09/2027 a 23/09/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270914',
        '20270923',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.251-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270914'
            AND a.DataFim = '20270923'
      );

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 25/09/2027 a 04/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270925',
        '20271004',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.719.773-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270925'
            AND a.DataFim = '20271004'
      );

    -- Josué Carvalho da Costa | SOE I | Férias | 27/09/2027 a 06/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270927',
        '20271006',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.637-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270927'
            AND a.DataFim = '20271006'
      );

    -- Rafaela Lopes Andrade | SOC | Férias | 29/09/2027 a 08/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20270929',
        '20271008',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.692-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20270929'
            AND a.DataFim = '20271008'
      );


-- ==================== OUTUBRO/2027 ====================

    -- Tiago Resende Brant | SOT | Férias | 04/10/2027 a 13/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271004',
        '20271013',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.130-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271004'
            AND a.DataFim = '20271013'
      );

    -- Santilhento Marcos da Silva | SOR | Férias | 04/10/2027 a 18/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271004',
        '20271018',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.672-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271004'
            AND a.DataFim = '20271018'
      );

    -- Vicente Cezar Ferreira Junior | SOR | Férias | 05/10/2027 a 14/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271005',
        '20271014',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.837-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271005'
            AND a.DataFim = '20271014'
      );

    -- Luis Ricardo Brasilino | SOE I | Férias | 09/10/2027 a 18/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271009',
        '20271018',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.650-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271009'
            AND a.DataFim = '20271018'
      );

    -- Sidney da Silva de Oliveira | SOE II | Férias | 10/10/2027 a 19/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271010',
        '20271019',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.929-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271010'
            AND a.DataFim = '20271019'
      );

    -- Klebson Alves Fonseca | SOE III | Férias | 11/10/2027 a 20/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271011',
        '20271020',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.929-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271011'
            AND a.DataFim = '20271020'
      );

    -- Ricardo Santos Textor | GAB | Férias | 12/10/2027 a 22/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271012',
        '20271022',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.617-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271012'
            AND a.DataFim = '20271022'
      );

    -- Frank Rodrigues Ferreira | SOT | Férias | 13/10/2027 a 22/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271013',
        '20271022',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.616-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271013'
            AND a.DataFim = '20271022'
      );

    -- Leandro de Oliveira Sampaio | GAB | Férias | 13/10/2027 a 22/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271013',
        '20271022',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.545-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271013'
            AND a.DataFim = '20271022'
      );

    -- Wanderson Gomes dos Santos | SOE III | Férias | 15/10/2027 a 24/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271015',
        '20271024',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.612-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271015'
            AND a.DataFim = '20271024'
      );

    -- Juliano Dantas Bueno | SOT | Férias | 18/10/2027 a 27/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271018',
        '20271027',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '225.345-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271018'
            AND a.DataFim = '20271027'
      );

    -- Daniel M. de L. e Alvarenga Peixoto | SOT | Férias | 18/10/2027 a 27/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271018',
        '20271027',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.685-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271018'
            AND a.DataFim = '20271027'
      );

    -- Wagner Alves Gonçalves Nogueira | SOR | Férias | 19/10/2027 a 28/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271019',
        '20271028',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.321-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271019'
            AND a.DataFim = '20271028'
      );

    -- Marcos Davila Teixeira | SOE IV | Férias | 20/10/2027 a 29/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271020',
        '20271029',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '189.289-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271020'
            AND a.DataFim = '20271029'
      );

    -- Marcio Romeiro Pereira Junior | SOE IV | Férias | 20/10/2027 a 29/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271020',
        '20271029',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.552-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271020'
            AND a.DataFim = '20271029'
      );

    -- Pericles M. de Rezende Junior | SOT | Férias | 20/10/2027 a 29/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271020',
        '20271029',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.888-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271020'
            AND a.DataFim = '20271029'
      );

    -- Pablo Samora Bonifácio Medeiros | SOC | Férias | 21/10/2027 a 30/10/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271021',
        '20271030',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.631-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271021'
            AND a.DataFim = '20271030'
      );

    -- Rubens Torres Deolindo | SOE III | Férias | 23/10/2027 a 01/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271023',
        '20271101',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.812-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271023'
            AND a.DataFim = '20271101'
      );

    -- Bruno Lima Aguirra | SOE IV | Férias | 24/10/2027 a 07/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271024',
        '20271107',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.413-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271024'
            AND a.DataFim = '20271107'
      );

    -- Rayssa Polianna Silva | SOR | Férias | 25/10/2027 a 03/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271025',
        '20271103',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.716.352-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271025'
            AND a.DataFim = '20271103'
      );

    -- Felipe Sousa Farias | SOR | Férias | 25/10/2027 a 03/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271025',
        '20271103',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.226-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271025'
            AND a.DataFim = '20271103'
      );

    -- Jorge Vinicius Moura Campos | SOE II | Férias | 30/10/2027 a 08/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271030',
        '20271108',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.047-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271030'
            AND a.DataFim = '20271108'
      );


-- ==================== NOVEMBRO/2027 ====================

    -- Tilia Rumi Okahara | SAAEI | Férias | 01/11/2027 a 30/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271101',
        '20271130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '63.236-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271101'
            AND a.DataFim = '20271130'
      );

    -- Luiz Cesar Mendes de Almeida | SOE III | Férias | 01/11/2027 a 30/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271101',
        '20271230',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.066-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271101'
            AND a.DataFim = '20271230'
      );

    -- Vanderlei Ferreira Dutra | SOE IV | Férias | 01/11/2027 a 30/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271101',
        '20271230',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.682-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271101'
            AND a.DataFim = '20271230'
      );

    -- Ananias Batista Gomes Junior | GAB | Férias | 01/11/2027 a 30/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271101',
        '20271230',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '75.742-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271101'
            AND a.DataFim = '20271230'
      );

    -- Adriano Viano Batista | SOC | Férias | 01/11/2027 a 30/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271101',
        '20271230',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.131-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271101'
            AND a.DataFim = '20271230'
      );

    -- Patricia Araujo Ribeiro | SAAEI | Férias | 01/11/2027 a 30/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271101',
        '20271230',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '78.405-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271101'
            AND a.DataFim = '20271230'
      );

    -- Igor Thiago Maux Lopes | SI | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '192.112-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Danilo Ricardo de Paiva Cunha | SOT | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.740-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Vinicius Gomes dos Santos Fontes | SOC | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '229.161-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Kennedy Ben Oliveira Primo | SOT | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.301-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Bruno Alves Bezerra Silva | SOR | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.033-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Ruy Lins Wanderley Neto | SOT | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.110-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Mauricio Victor Cassis | SOR | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.443-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Rebeca Severo Limongi | SAAEI | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.251-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Silvestre Milhomem Amaral | SI | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '35.381-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Paulo Roberto Tavares Brandão | GAB | Férias | 03/11/2027 a 12/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271103',
        '20271112',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.224-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271103'
            AND a.DataFim = '20271112'
      );

    -- Edson Medina de Oliveira | GAB | Férias | 05/11/2027 a 04/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271105',
        '20271204',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '89.260-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271105'
            AND a.DataFim = '20271204'
      );

    -- Pedro H. Duarte Medeiros de Brito | SOE III | Férias | 08/11/2027 a 17/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271108',
        '20271117',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.719.773-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271108'
            AND a.DataFim = '20271117'
      );

    -- Higor Barbosa de Souza | SOE I | Férias | 14/11/2027 a 23/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271114',
        '20271123',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.222-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271114'
            AND a.DataFim = '20271123'
      );

    -- Alberto Ganzaroli Neto | SOE II | Férias | 14/11/2027 a 23/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271114',
        '20271123',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '233.676-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271114'
            AND a.DataFim = '20271123'
      );

    -- Daniel Beltrame Faria | SOT | Férias | 15/11/2027 a 24/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271115',
        '20271124',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.205-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271115'
            AND a.DataFim = '20271124'
      );

    -- Maiquel A. Cavalcante Mendes | SI | Férias | 15/11/2027 a 24/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271115',
        '20271124',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '59.270-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271115'
            AND a.DataFim = '20271124'
      );

    -- Gabriel Arana da Silva | SOE III | Férias | 16/11/2027 a 25/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271116',
        '20271125',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.229-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271116'
            AND a.DataFim = '20271125'
      );

    -- Marcelo Vasconcelos Dias | SOR | Férias | 16/11/2027 a 25/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271116',
        '20271125',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '230.856-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271116'
            AND a.DataFim = '20271125'
      );

    -- Aurelio Gleria Cavalcante | SOC | Férias | 16/11/2027 a 30/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271116',
        '20271130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.058-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271116'
            AND a.DataFim = '20271130'
      );

    -- Adenauer Dantas Justo da SI | SI | Férias | 16/11/2027 a 30/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271116',
        '20271130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '36.007-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271116'
            AND a.DataFim = '20271130'
      );

    -- Max Macedo Cavalcante | SOE II | Férias | 19/11/2027 a 28/11/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271119',
        '20271128',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.722.557-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271119'
            AND a.DataFim = '20271128'
      );

    -- Geovane Ribeiro Mathias | SOR | Férias | 22/11/2027 a 01/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271122',
        '20271201',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '228.395-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271122'
            AND a.DataFim = '20271201'
      );

    -- Sanlac Machado da Cunha | SOC | Férias | 22/11/2027 a 01/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271122',
        '20271201',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.160-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271122'
            AND a.DataFim = '20271201'
      );

    -- Felipe Chiarelli Linhares Titoneli | SOT | Férias | 24/11/2027 a 23/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271124',
        '20271223',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '1.721.534-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271124'
            AND a.DataFim = '20271223'
      );

    -- Pedro Rollemberg Mollo | SOE I | Férias | 26/11/2027 a 05/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271126',
        '20271205',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '188.479-4'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271126'
            AND a.DataFim = '20271205'
      );

    -- Fabio Silva Piazzarollo | SOE III | Férias | 28/11/2027 a 07/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271128',
        '20271207',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.923-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271128'
            AND a.DataFim = '20271207'
      );

    -- Hugo Leonardo Garcia Ferreira | SOT | Férias | 29/11/2027 a 08/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271129',
        '20271208',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '234.273-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271129'
            AND a.DataFim = '20271208'
      );

    -- Roberto Jean Philippe Corrêa | SOR | Férias | 29/11/2027 a 08/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271129',
        '20271208',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.752-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271129'
            AND a.DataFim = '20271208'
      );

    -- Josué Carvalho da Costa | SOE I | Férias | 30/11/2027 a 09/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271130',
        '20271209',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.637-1'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271130'
            AND a.DataFim = '20271209'
      );


-- ==================== DEZEMBRO/2027 ====================

    -- Cinthia Versiani Pontes | SOC | Férias | 01/12/2027 a 10/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271201',
        '20271210',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.639-8'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271201'
            AND a.DataFim = '20271210'
      );

    -- Alexandre J. R. Brito Fontes | GAB | Férias | 01/12/2027 a 10/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271201',
        '20271210',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.950-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271201'
            AND a.DataFim = '20271210'
      );

    -- Cristiano Pereira de Jesus | SOE II | Férias | 01/12/2027 a 30/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271201',
        '20271230',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.212-5'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271201'
            AND a.DataFim = '20271230'
      );

    -- Lincon Massahiro Takano | SOE IV | Férias | 01/12/2027 a 30/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271201',
        '20271230',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '47.567-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271201'
            AND a.DataFim = '20271230'
      );

    -- Francisco Lanna Guillen | SOE II | Férias | 01/12/2027 a 30/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271201',
        '20271230',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.540-2'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271201'
            AND a.DataFim = '20271230'
      );

    -- Marcio Roberto Valente Caetano | GAB | Férias | 01/12/2027 a 30/12/2027
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271201',
        '20271230',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.436-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271201'
            AND a.DataFim = '20271230'
      );

    -- Cristiano Jardim de Gusmão | SOE IV | Férias | 05/12/2027 a 03/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271205',
        '20280103',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.462-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271205'
            AND a.DataFim = '20280103'
      );

    -- Antonio Jose Lima | GAB | Férias | 08/12/2027 a 06/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271208',
        '20280106',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '58.942-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271208'
            AND a.DataFim = '20280106'
      );

    -- Raphael Rodolfo Torres Gaia | SOR | Férias | 11/12/2027 a 09/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271211',
        '20280109',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '236.647-9'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271211'
            AND a.DataFim = '20280109'
      );

    -- Daniel Lebrão Arruda | SOE IV | Férias | 11/12/2027 a 09/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271211',
        '20280109',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.600-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271211'
            AND a.DataFim = '20280109'
      );

    -- Renato Bizinoto Molas | SOE I | Férias | 12/12/2027 a 10/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271212',
        '20280110',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '227.855-3'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271212'
            AND a.DataFim = '20280110'
      );

    -- Andre Ricardo Oliveira Marinho | SOE IV | Férias | 15/12/2027 a 13/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271215',
        '20280113',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '57.809-6'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271215'
            AND a.DataFim = '20280113'
      );

    -- Eduardo Cosme Carvalho da Silva | SOE I | Férias | 16/12/2027 a 14/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271216',
        '20280114',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '76.826-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271216'
            AND a.DataFim = '20280114'
      );

    -- Franthiesco L. Fernandes Nunes | SOE III | Férias | 22/12/2027 a 20/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20271222',
        '20280120',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '235.271-0'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20271222'
            AND a.DataFim = '20280120'
      );


-- ==================== JANEIRO/2028 ====================

    -- Luiz Cesar Mendes de Almeida | SOE III | Férias | 01/01/2028 a 29/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20280101',
        '20280129',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '231.066-X'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20280101'
            AND a.DataFim = '20280129'
      );

    -- Thallys Mendes Passos | SOE II | Férias | 01/01/2028 a 30/01/2028
    INSERT INTO dbo.AfastamentoOperador
    (
        OperadorID,
        TipoAfastamento,
        DataInicio,
        DataFim,
        Observacao,
        DataHoraCriacao
    )
    SELECT
        o.ID,
        1,
        '20280101',
        '20280130',
        NULL,
        GETDATE()
    FROM dbo.Operador o
    WHERE o.Matricula = '77.369-7'
      AND NOT EXISTS
      (
          SELECT 1
          FROM dbo.AfastamentoOperador a
          WHERE a.OperadorID = o.ID
            AND a.TipoAfastamento = 1
            AND a.DataInicio = '20280101'
            AND a.DataFim = '20280130'
      );

      ");
    }

    public override void Down()
    {
    }
  }
}
