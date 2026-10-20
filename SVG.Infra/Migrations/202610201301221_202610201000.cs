namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202610201000 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
SET NOCOUNT ON;

DECLARE @Carga TABLE
(
    Matricula varchar(20) NOT NULL,
    Prefixo varchar(20) NULL,
    Placa varchar(20) NULL,
    PlacaOficial varchar(20) NULL,
    Marca varchar(50) NOT NULL,
    Modelo varchar(80) NOT NULL,
    Chassi varchar(17) NULL,
    KmAtual int NOT NULL,
    KmUltimoAbastecimento int NULL,
    KmProximaRevisao int NULL
);

-- Dados não presentes na inspeção: KM inicial provisório 0 e demais campos NULL.
-- A placa vinculada do MEDINA fica NULL até confirmação.
INSERT INTO @Carga
(Matricula, Prefixo, Placa, PlacaOficial, Marca, Modelo, Chassi, KmAtual, KmUltimoAbastecimento, KmProximaRevisao)
VALUES
('57.752-9', NULL, 'TVK-2D18', 'UJD-1C46', 'CHEVROLET', 'TRAILBLAZER', NULL, 0, NULL, NULL),
('228.395-6', NULL, 'TVK-2D48', 'UJD-1F59', 'CHEVROLET', 'TRAILBLAZER', NULL, 0, NULL, NULL),
('230.856-8', NULL, 'PAL-9F78', 'REE-1C59', 'CHEVROLET', 'TRAILBLAZER', '9BG156FK0KC446626', 114780, 114296, 120900),
('89.260-2', NULL, NULL, 'UJD-1C19', 'CHEVROLET', 'TRAILBLAZER', NULL, 0, NULL, NULL),
('76.224-5', NULL, 'TVK-2C39', 'UJD-1C25', 'CHEVROLET', 'TRAILBLAZER', NULL, 0, NULL, NULL),
('76.685-2', NULL, 'PAL-9E29', 'REE-3G96', 'CHEVROLET', 'S10', '9BG148FK0LC436733', 121136, 121136, 125000),
('235.205-2', NULL, 'TVK-2E81', 'UJD-1C13', 'CHEVROLET', 'TRAILBLAZER', NULL, 0, NULL, NULL),
('230.301-9', NULL, 'TVK-2E18', 'UJD-1C65', 'CHEVROLET', 'TRAILBLAZER', NULL, 0, NULL, NULL),
('63.236-8', NULL, 'SSQ-9H57', 'SSP-7I19', 'NISSAN', 'SENTRA', '3N1AB8AE6SY201341', 25133, 25104, 27700),
('58.160-7', 'D-0238', 'RED-5E66', NULL, 'CHEVROLET', 'TRAILBLAZER', NULL, 0, NULL, NULL),
('236.639-8', NULL, 'PBG-9F37', 'SGT-3J44', 'NISSAN', 'KICKS', NULL, 0, NULL, NULL),
('192.112-6', NULL, 'PAL-9A10', 'REE-1C58', 'CHEVROLET', 'TRAILBLAZER', '9BG156FK0KC442059', 92236, 92236, 98900),
('236.647-9', 'D-0294', 'JEF-9451', NULL, 'YAMAHA', 'MOTOCICLETA', NULL, 0, NULL, NULL),
('231.443-6', 'D-0298', 'JEF-9481', NULL, 'YAMAHA', 'MOTOCICLETA', NULL, 0, NULL, NULL),
('231.046-5', 'D-0293', 'JEF-9461', NULL, 'YAMAHA', 'MOTOCICLETA', NULL, 0, NULL, NULL);

IF (SELECT COUNT(*) FROM @Carga) <> 15
    RAISERROR('Carga incompleta: eram esperadas 15 viaturas.', 16, 1);

IF EXISTS
(
    SELECT 1 FROM @Carga c
    OUTER APPLY (SELECT COUNT(*) AS Qtd FROM dbo.Operador o WHERE o.Matricula = c.Matricula) op
    WHERE op.Qtd <> 1
)
    RAISERROR('Carga cancelada: matrícula ausente ou duplicada em Operador.', 16, 1);

IF EXISTS
(
    SELECT 1 FROM @Carga c
    INNER JOIN dbo.Operador o ON o.Matricula = c.Matricula
    LEFT JOIN dbo.Sessao s ON s.ID = o.SessaoID
    WHERE s.ID IS NULL
)
    RAISERROR('Carga cancelada: operador sem seção válida.', 16, 1);

-- Não permite que placa oficial/vinculada da carga já pertença a outra viatura,
-- mesmo que esteja cadastrada na coluna oposta.
IF EXISTS
(
    SELECT 1 FROM @Carga c
    INNER JOIN dbo.Viatura v
      ON (c.Placa IS NOT NULL AND (v.Placa = c.Placa OR v.PlacaOficial = c.Placa))
      OR (c.PlacaOficial IS NOT NULL AND (v.Placa = c.PlacaOficial OR v.PlacaOficial = c.PlacaOficial))
      OR (c.Prefixo IS NOT NULL AND v.Prefixo = c.Prefixo)
      OR (c.Chassi IS NOT NULL AND v.Chassi = c.Chassi)
)
    RAISERROR('Carga cancelada: placa, prefixo ou chassi já existe em Viatura. Verifique especialmente UJD-1G19 / D-0208.', 16, 1);

IF EXISTS
(
    SELECT 1 FROM @Carga a JOIN @Carga b
      ON a.Matricula <> b.Matricula
     AND ((a.Placa IS NOT NULL AND (a.Placa = b.Placa OR a.Placa = b.PlacaOficial))
       OR (a.PlacaOficial IS NOT NULL AND (a.PlacaOficial = b.Placa OR a.PlacaOficial = b.PlacaOficial))
       OR (a.Prefixo IS NOT NULL AND a.Prefixo = b.Prefixo))
)
    RAISERROR('Carga cancelada: placa ou prefixo duplicado na própria carga.', 16, 1);

INSERT INTO dbo.Viatura
(
    Prefixo, Placa, PlacaOficial, Marca, Modelo, Ano, Chassi,
    SessaoID, OperadorResponsavelID, TipoCaracterizacao,
    KmAtual, KmUltimoAbastecimento, KmProximaRevisao, Situacao
)
SELECT
    c.Prefixo, c.Placa, c.PlacaOficial, c.Marca, c.Modelo, NULL, c.Chassi,
    o.SessaoID, o.ID, 2,
    c.KmAtual, c.KmUltimoAbastecimento, c.KmProximaRevisao, 1
FROM @Carga c
INNER JOIN dbo.Operador o ON o.Matricula = c.Matricula;
");
    }

    public override void Down()
    {
      // Reversão conservadora: impede exclusão se houve movimentação.
      // Só exclui os registros com matrícula, placa/prefixo e caracterização esperados.
      Sql(@"
SET NOCOUNT ON;
DECLARE @Alvos TABLE (Matricula varchar(20), Placa varchar(20) NULL, PlacaOficial varchar(20) NULL, Prefixo varchar(20) NULL);
INSERT INTO @Alvos VALUES
('57.752-9','TVK-2D18','UJD-1C46',NULL),
('228.395-6','TVK-2D48','UJD-1F59',NULL),
('230.856-8','PAL-9F78','REE-1C59',NULL),
('89.260-2',NULL,'UJD-1G19',NULL),
('76.224-5','TVK-2C39','UJD-1C25',NULL),
('76.685-2','PAL-9E29','REE-3G96',NULL),
('235.205-2','TVK-2E81','UJD-1C13',NULL),
('230.301-9','TVK-2E18','UJD-1C65',NULL),
('63.236-8','SSQ-9H57','SSP-7I19',NULL),
('58.160-7','RED-5E66',NULL,'D-0238'),
('236.639-8','PBG-9F37','SGT-3J44',NULL),
('192.112-6','PAL-9A10','REE-1C58',NULL),
('236.647-9','JEF-9451',NULL,'D-0294'),
('231.443-6','JEF-9481',NULL,'D-0298'),
('231.046-5','JEF-9461',NULL,'D-0293');

IF EXISTS
(
    SELECT 1 FROM dbo.Viatura v
    JOIN dbo.Operador o ON o.ID = v.OperadorResponsavelID
    JOIN @Alvos a ON a.Matricula = o.Matricula
       AND (a.Placa IS NULL OR a.Placa = v.Placa)
       AND (a.PlacaOficial IS NULL OR a.PlacaOficial = v.PlacaOficial)
       AND (a.Prefixo IS NULL OR a.Prefixo = v.Prefixo)
    WHERE v.TipoCaracterizacao = 2
      AND EXISTS (SELECT 1 FROM dbo.ViaturaMovimentacao m WHERE m.ViaturaID = v.ID)
)
    RAISERROR('Down cancelado: uma das viaturas da carga possui movimentações.', 16, 1);

DELETE v
FROM dbo.Viatura v
JOIN dbo.Operador o ON o.ID = v.OperadorResponsavelID
JOIN @Alvos a ON a.Matricula = o.Matricula
   AND (a.Placa IS NULL OR a.Placa = v.Placa)
   AND (a.PlacaOficial IS NULL OR a.PlacaOficial = v.PlacaOficial)
   AND (a.Prefixo IS NULL OR a.Prefixo = v.Prefixo)
WHERE v.TipoCaracterizacao = 2;
");
    }
  }
}
