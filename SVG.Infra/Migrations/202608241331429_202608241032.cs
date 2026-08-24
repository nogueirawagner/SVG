namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202608241032 : DbMigration
    {
    public override void Up()
    {
      Sql(@"
/* ===============================================================
   SVG.DOE
   Consolidação dos dados dos operadores

   Inclui:
      - Alcunha
      - DataIngressoDOE
      - NumericaDOE
      - NumericaSecao

   NumericaSecao:
      Atualmente representa a numérica interna da SOR.

   IMPORTANTE:
      Os UPDATEs utilizam ID + Nome como validação adicional.
   =============================================================== */

SET NOCOUNT ON;
SET XACT_ABORT ON;

BEGIN TRY

    BEGIN TRANSACTION;

    /* ===========================================================
       1. CRIAÇÃO DAS NOVAS COLUNAS
       =========================================================== */

    IF COL_LENGTH('dbo.Operador', 'DataIngressoDOE') IS NULL
    BEGIN
        ALTER TABLE dbo.Operador
        ADD DataIngressoDOE DATE NULL;
    END;

    IF COL_LENGTH('dbo.Operador', 'NumericaDOE') IS NULL
    BEGIN
        ALTER TABLE dbo.Operador
        ADD NumericaDOE INT NULL;
    END;

    IF COL_LENGTH('dbo.Operador', 'NumericaSecao') IS NULL
    BEGIN
        ALTER TABLE dbo.Operador
        ADD NumericaSecao INT NULL;
    END;


    /* ===========================================================
       2. DADOS DOE
       Alcunha + DataIngressoDOE + NumericaDOE
       =========================================================== */

    ;WITH DadosDOE AS
    (
        SELECT *
        FROM
        (
            VALUES

            /* DELEGADO */
            (130, 'Edson Medina de Oliveira',
                  'DR. MEDINA',        CONVERT(date,'20190111'), 1),

            /* AGENTES */
            (200, 'Lincon Massahiro Takano',
                  'LINCON',            CONVERT(date,'19990915'), 1),

            (199, 'Andre Ricardo Oliveira Marinho',
                  'ANDRÉ RICARDO',     CONVERT(date,'19990222'), 3),

            (201, 'Daniel Lebrão Arruda',
                  'DANIEL LEBRÃO',     CONVERT(date,'20000619'), 4),

            (184, 'Vanderlei Ferreira Dutra',
                  'VANDERLEI DUTRA',   CONVERT(date,'20010107'), 5),

            (198, 'Cristiano Jardim de Gusmão',
                  'CRISTIANO GUSMÃO',  CONVERT(date,'20011204'), 6),

            (139, 'Roberto Jean Philippe Corrêa',
                  'ROBERTO JEAN',      CONVERT(date,'20031028'), 7),

            (131, 'Paulo Roberto Tavares Brandão',
                  'BRANDÃO',           CONVERT(date,'20060329'), 8),

            (191, 'Fabio Silva Piazzarollo',
                  'PIAZZA',            CONVERT(date,'19990211'), 10),

            (181, 'Honney Cordeiro',
                  'HONNEY',            CONVERT(date,'20070208'), 11),

            (206, 'Marcio Roberto Valente Caetano',
                  'CAETANO',           CONVERT(date,'20080407'), 12),

            (173, 'Marcelo Thomas',
                  'THOMAS',            CONVERT(date,'20000320'), 13),

            (162, 'Sanlac Machado da Cunha',
                  'SANLAC',            CONVERT(date,'20050519'), 14),

            (153, 'Daniel M. de L. e Alvarenga Peixoto',
                  'DANIEL MATHEUS',    CONVERT(date,'20210804'), 16),

            (141, 'Vicente Cezar Ferreira Junior',
                  'FERREIRA',          CONVERT(date,'20100301'), 18),

            (136, 'Maiquel A. Cavalcante Mendes',
                  'MAIQUEL',           CONVERT(date,'20220225'), 21),

            (175, 'Pedro Rollemberg Mollo',
                  'PEDRO ROLLEMBERG',  CONVERT(date,'20130227'), 22),

            (202, 'Bruno Lima Aguirra',
                  'AGUIRRA',           CONVERT(date,'20130227'), 25),

            (170, 'Renato Bizinoto Molas',
                  'RENATO BIZINOTO',   CONVERT(date,'20150302'), 29),

            (143, 'Marcelo Vasconcelos Dias',
                  'MARCELO DIAS',      CONVERT(date,'20150415'), 30),

            (145, 'Alvaro H. M. da Silva Santos',
                  'ÁLVARO',            CONVERT(date,'20160227'), 31),

            (140, 'Geovane Ribeiro Mathias',
                  'MATHIAS',           CONVERT(date,'20160310'), 32),

            (135, 'Igor Thiago Maux Lopes',
                  'IGOR',              CONVERT(date,'20141222'), 33),

            (146, 'Mauricio Victor Cassis',
                  'CASSIS',            CONVERT(date,'20160701'), 34),

            (147, 'Santilhento Marcos da Silva',
                  'SANTILHENO',        CONVERT(date,'20180201'), 35),

            (132, 'Leandro de Oliveira Sampaio',
                  'LEANDRO SAMPAIO',   CONVERT(date,'20060530'), 36),

            (137, 'Silvestre Milhomem Amaral',
                  'SILVESTRE',         CONVERT(date,'20080407'), 38),

            (174, 'Eduardo Cosme Carvalho da Silva',
                  'EDUARDO COSME',     CONVERT(date,'20110222'), 39),

            (171, 'Diego Madureira Rodrigues',
                  'DIEGO RODRIGUES',   CONVERT(date,'20130227'), 40),

            (165, 'Ricardo Santos Textor',
                  'RICARDO',           CONVERT(date,'20130301'), 41),

            (193, 'Cleuber Medeiros Guimarães',
                  'CLEUBER',           CONVERT(date,'20130828'), 42),

            (176, 'Marcello Bentes C. Albuquerque',
                  'BENTES',            CONVERT(date,'20140901'), 43),

            (204, 'Marcio Romeiro Pereira Junior',
                  'ROMEIRO',           CONVERT(date,'20160629'), 44),

            (190, 'Klebson Alves Fonseca',
                  'KLEBSON',           CONVERT(date,'20160703'), 46),

            (189, 'Luiz Cesar Mendes de Almeida',
                  'CÉSAR',             CONVERT(date,'20160705'), 47),

            (155, 'Danilo Ricardo de Paiva Cunha',
                  'DANILO',            CONVERT(date,'20160712'), 48),

            (182, 'Thallys Mendes Passos',
                  'THALLYS',           CONVERT(date,'20161207'), 49),

            (158, 'Marcelo Nunes',
                  'MARCELO NUNES',     CONVERT(date,'20180131'), 50),

            (152, 'Daniel Beltrame Faria',
                  'BELTRAME',          CONVERT(date,'20180131'), 51),

            (185, 'Alberto Ganzaroli Neto',
                  'ALBERTO',           CONVERT(date,'20180201'), 52),

            (159, 'Tiago Resende Brant',
                  'THIAGO BRANT',      CONVERT(date,'20180202'), 53),

            (142, 'Felipe Sousa Farias',
                  'FELIPE FARIAS',     CONVERT(date,'20180207'), 54),

            (203, 'Marcos Davila Teixeira',
                  'MARCOS',            CONVERT(date,'20181019'), 56),

            (192, 'Rubens Torres Deolindo',
                  'RUBENS',            CONVERT(date,'20190205'), 58),

            (177, 'Josué Carvalho da Costa',
                  'CARVALHO',          CONVERT(date,'20190206'), 59),

            (160, 'Frank Rodrigues Ferreira',
                  'FRANK',             CONVERT(date,'20190211'), 60),

            (186, 'Cristiano Pereira de Jesus',
                  'CRISTIANO PEREIRA', CONVERT(date,'20190213'), 61),

            (148, 'Raphael Rodolfo Torres Gaia',
                  'GAIA',              CONVERT(date,'20190415'), 62),

            (212, 'Antonio Jose Lima',
                  'LIMA',              CONVERT(date,'20190724'), 63),

            (151, 'Kennedy Ben Oliveira Primo',
                  'KENNEDY',           CONVERT(date,'20210803'), 64),

            (154, 'Juliano Dantas Bueno',
                  'BUENO',             CONVERT(date,'20220810'), 65),

            (156, 'Pericles M. de Rezende Junior',
                  'PERICLES',          CONVERT(date,'20230515'), 66),

            (187, 'Jorge Vinicius Moura Campos',
                  'JORGE',             CONVERT(date,'20231019'), 67),

            (194, 'Franthiesco L. Fernandes Nunes',
                  'FRANTIESCO',        CONVERT(date,'20240131'), 68),

            (179, 'Sidartha Souza de Quevedo',
                  'SIDARTHA',          CONVERT(date,'20240131'), 69),

            (144, 'Bruno Alves Bezerra Silva',
                  'BRUNO',             CONVERT(date,'20240201'), 70),

            (157, 'Hugo Leonardo Garcia Ferreira',
                  'HUGO',              CONVERT(date,'20240201'), 71),

            (161, 'Felipe Chiarelli Linhares Titoneli',
                  'CHIARELLI',         CONVERT(date,'20250904'), 72),

            (150, 'Wagner Alves Gonçalves Nogueira',
                  'NOGUEIRA',          CONVERT(date,'20250904'), 73),

            (149, 'Rayssa Polianna Silva',
                  'RAYSSA',            CONVERT(date,'20250904'), 74),

            (178, 'Luis Ricardo Brasilino',
                  'BRASILINO',         CONVERT(date,'20250904'), 75),

            (195, 'Pedro H. Duarte Medeiros de Brito',
                  'PEDRO HENRIQUE',    CONVERT(date,'20250904'), 76),

            (196, 'Gabriel Arana da Silva',
                  'ARANA',             CONVERT(date,'20250904'), 77),

            (205, 'Anderson Benevides Valença',
                  'BENEVIDES',         CONVERT(date,'20250904'), 78),

            (188, 'Sidney da Silva de Oliveira',
                  'SIDNEY',            CONVERT(date,'20250904'), 79),

            (180, 'Higor Barbosa de Souza',
                  'HIGOR',             CONVERT(date,'20250904'), 80),

            (197, 'Wanderson Gomes dos Santos',
                  'WANDERSON',         CONVERT(date,'20250904'), 81)

        ) V
        (
            OperadorID,
            Nome,
            Alcunha,
            DataIngressoDOE,
            NumericaDOE
        )
    )

    UPDATE O
       SET O.Alcunha         = D.Alcunha,
           O.DataIngressoDOE = D.DataIngressoDOE,
           O.NumericaDOE     = D.NumericaDOE
    FROM dbo.Operador O
    INNER JOIN DadosDOE D
        ON D.OperadorID = O.ID
       AND D.Nome       = O.Nome;


    /* ===========================================================
       3. NUMÉRICA INTERNA DA SOR
       =========================================================== */

    ;WITH DadosSOR AS
    (
        SELECT *
        FROM
        (
            VALUES
                (139, 'Roberto Jean Philippe Corrêa',      7),
                (140, 'Geovane Ribeiro Mathias',           32),
                (141, 'Vicente Cezar Ferreira Junior',     18),
                (142, 'Felipe Sousa Farias',               36),
                (143, 'Marcelo Vasconcelos Dias',          30),
                (144, 'Bruno Alves Bezerra Silva',         38),
                (145, 'Alvaro H. M. da Silva Santos',      31),
                (146, 'Mauricio Victor Cassis',            34),
                (147, 'Santilhento Marcos da Silva',       35),
                (148, 'Raphael Rodolfo Torres Gaia',       37),
                (149, 'Rayssa Polianna Silva',             40),
                (150, 'Wagner Alves Gonçalves Nogueira',   39)
        ) V
        (
            OperadorID,
            Nome,
            NumericaSecao
        )
    )

    UPDATE O
       SET O.NumericaSecao = S.NumericaSecao
    FROM dbo.Operador O
    INNER JOIN DadosSOR S
        ON S.OperadorID = O.ID
       AND S.Nome       = O.Nome;


    /* ===========================================================
       4. VALIDAÇÕES
       =========================================================== */

    DECLARE @QtdDOE INT;
    DECLARE @QtdSOR INT;

    SELECT @QtdDOE = COUNT(*)
    FROM dbo.Operador
    WHERE NumericaDOE IS NOT NULL;

    SELECT @QtdSOR = COUNT(*)
    FROM dbo.Operador
    WHERE NumericaSecao IS NOT NULL;


    PRINT 'Operadores com Numérica DOE: '
          + CAST(@QtdDOE AS varchar(10));

    PRINT 'Operadores com Numérica de Seção: '
          + CAST(@QtdSOR AS varchar(10));


    /* ===========================================================
       5. COMMIT
       =========================================================== */

    COMMIT TRANSACTION;

END TRY
BEGIN CATCH

    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;

    THROW;

END CATCH;
GO


        ");
    }

    public override void Down()
        {
        }
    }
}