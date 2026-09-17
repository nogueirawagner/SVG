namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202609151920 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        
        DELETE FROM VIATURA

        INSERT INTO dbo.Viatura
        (
            Prefixo,
            Placa,
            PlacaOficial,
            Marca,
            Modelo,
            Chassi,
            SessaoID,
            OperadorResponsavelID,
            TipoCaracterizacao,
            KmAtual,
            KmUltimoAbastecimento,
            KmProximaRevisao,
            Situacao
        )
        VALUES
        -- SOE I
        ('D-0204', 'UJD-1F79', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440543', 1, NULL, 1, 33, NULL, 10000, 1),

        ('D-0210', 'UJD-1G45', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440453', 1, NULL, 1, 60, NULL, 10000, 1),

        -- SOE II
        ('D-0212', 'UJD-1G17', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440496', 2, NULL, 1, 53, NULL, 10000, 1),

        ('D-0218', 'UJD-1G44', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440454', 2, NULL, 1, 31, NULL, 10000, 1),

        -- SOE III
        ('D-0224', 'UJD-1G27', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440570', 3, NULL, 1, 57, NULL, 10000, 1),

        ('D-0236', 'UJD-1G07', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440523', 3, NULL, 1, 31, NULL, 10000, 1),

        -- SOE IV
        ('D-0240', 'UJD-1F99', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440529', 4, NULL, 1, 38, NULL, 10000, 1),

        ('D-0246', 'UJD-1G10', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440510', 4, NULL, 1, 87, NULL, 10000, 1),

        -- SOR
        ('D-0206', 'UJD-1G11', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440503', 5, NULL, 1, 46, NULL, 10000, 1),

        -- GAB
        ('D-0208', 'UJD-1G19', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440489', 9, NULL, 1, 29, NULL, 10000, 1),

        -- SOT
        ('D-0244', 'UJD-1F88', NULL, 'CHEVROLET', 'TRAILBLAZER',
         '9BG156FK0TC440549', 6, NULL, 1, 58, NULL, 10000, 1);
    ");
    }

    public override void Down()
    {
      Sql(@"
        DELETE FROM dbo.Viatura
        WHERE Prefixo IN
        (
            'D-0204',
            'D-0210',
            'D-0212',
            'D-0218',
            'D-0224',
            'D-0236',
            'D-0240',
            'D-0246',
            'D-0206',
            'D-0208',
            'D-0244'
        );
    ");
    }
  }
}
