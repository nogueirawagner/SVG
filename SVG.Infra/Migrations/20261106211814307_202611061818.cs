namespace SVG.Infra.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class _202611061818 : DbMigration
    {
        public override void Up()
        {
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Endereco_Alvo') IS NULL
BEGIN
    IF COL_LENGTH(N'dbo.Planejamento', N'LinkGoogleMaps') IS NOT NULL
        EXEC sys.sp_rename N'dbo.Planejamento.LinkGoogleMaps', N'Link_Endereco_Alvo', N'COLUMN';
    ELSE
        ALTER TABLE dbo.Planejamento ADD Link_Endereco_Alvo varchar(2048) NULL;
END
ELSE IF COL_LENGTH(N'dbo.Planejamento', N'LinkGoogleMaps') IS NOT NULL
BEGIN
    -- Uma instalação parcial pode conter ambas as colunas. Não sobrescrever valores divergentes.
    EXEC(N'IF EXISTS (SELECT 1 FROM dbo.Planejamento WHERE Link_Endereco_Alvo IS NOT NULL AND LinkGoogleMaps IS NOT NULL AND Link_Endereco_Alvo COLLATE Latin1_General_100_BIN2 <> LinkGoogleMaps COLLATE Latin1_General_100_BIN2)
        THROW 51000, ''Links de endereço divergentes: concilie os valores antes de aplicar a migration.'', 1;
    UPDATE dbo.Planejamento SET Link_Endereco_Alvo = COALESCE(Link_Endereco_Alvo, LinkGoogleMaps);
    ALTER TABLE dbo.Planejamento DROP COLUMN LinkGoogleMaps;');
END;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'LocalBriefing') IS NULL
    ALTER TABLE dbo.Planejamento ADD [LocalBriefing] varchar(300) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'HorarioBriefingDOE') IS NULL
    ALTER TABLE dbo.Planejamento ADD [HorarioBriefingDOE] time NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'HorarioSaidaDOE') IS NULL
    ALTER TABLE dbo.Planejamento ADD [HorarioSaidaDOE] time NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'HorarioBriefingDP') IS NULL
    ALTER TABLE dbo.Planejamento ADD [HorarioBriefingDP] time NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'SocorristaAPH1') IS NULL
    ALTER TABLE dbo.Planejamento ADD [SocorristaAPH1] varchar(200) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'SocorristaAPH2') IS NULL
    ALTER TABLE dbo.Planejamento ADD [SocorristaAPH2] varchar(200) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'MotoristaVtrAPH') IS NULL
    ALTER TABLE dbo.Planejamento ADD [MotoristaVtrAPH] varchar(200) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'PrefixoVtrAPH') IS NULL
    ALTER TABLE dbo.Planejamento ADD [PrefixoVtrAPH] varchar(100) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'ResponsavelRelatorio') IS NULL
    ALTER TABLE dbo.Planejamento ADD [ResponsavelRelatorio] varchar(200) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'ResponsavelFotoMBA') IS NULL
    ALTER TABLE dbo.Planejamento ADD [ResponsavelFotoMBA] varchar(200) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'CoordenadaZPH') IS NULL
    ALTER TABLE dbo.Planejamento ADD [CoordenadaZPH] varchar(200) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Rota_DOE_Unidade_Apoio') IS NULL
    ALTER TABLE dbo.Planejamento ADD [Link_Rota_DOE_Unidade_Apoio] varchar(2048) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Rota_DP_Desemb') IS NULL
    ALTER TABLE dbo.Planejamento ADD [Link_Rota_DP_Desemb] varchar(2048) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Localizacao_Desemb') IS NULL
    ALTER TABLE dbo.Planejamento ADD [Link_Localizacao_Desemb] varchar(2048) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Localizacao_Hospital_1') IS NULL
    ALTER TABLE dbo.Planejamento ADD [Link_Localizacao_Hospital_1] varchar(2048) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Localizacao_Hospital_2') IS NULL
    ALTER TABLE dbo.Planejamento ADD [Link_Localizacao_Hospital_2] varchar(2048) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'DistanciaRotaDOEUnidadeApoioKm') IS NULL
    ALTER TABLE dbo.Planejamento ADD [DistanciaRotaDOEUnidadeApoioKm] decimal(10,2) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'DuracaoRotaDOEUnidadeApoioMinutos') IS NULL
    ALTER TABLE dbo.Planejamento ADD [DuracaoRotaDOEUnidadeApoioMinutos] int NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'DistanciaRotaDPDesembKm') IS NULL
    ALTER TABLE dbo.Planejamento ADD [DistanciaRotaDPDesembKm] decimal(10,2) NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'DuracaoRotaDPDesembMinutos') IS NULL
    ALTER TABLE dbo.Planejamento ADD [DuracaoRotaDPDesembMinutos] int NULL;");

            Sql(@"IF COL_LENGTH(N'dbo.PlanejamentoIntegrante', N'Entrada') IS NULL
    ALTER TABLE dbo.PlanejamentoIntegrante ADD Entrada varchar(100) NULL;");

        }

        public override void Down()
        {
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'LinkGoogleMaps') IS NOT NULL AND COL_LENGTH(N'dbo.Planejamento', N'Link_Endereco_Alvo') IS NOT NULL
    THROW 51001, 'As duas colunas de link existem. Revise os dados antes de reverter.', 1;");
            Sql(@"IF COL_LENGTH(N'dbo.PlanejamentoIntegrante', N'Entrada') IS NOT NULL
    ALTER TABLE dbo.PlanejamentoIntegrante DROP COLUMN [Entrada];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'DuracaoRotaDPDesembMinutos') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [DuracaoRotaDPDesembMinutos];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'DistanciaRotaDPDesembKm') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [DistanciaRotaDPDesembKm];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'DuracaoRotaDOEUnidadeApoioMinutos') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [DuracaoRotaDOEUnidadeApoioMinutos];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'DistanciaRotaDOEUnidadeApoioKm') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [DistanciaRotaDOEUnidadeApoioKm];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Localizacao_Hospital_2') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [Link_Localizacao_Hospital_2];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Localizacao_Hospital_1') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [Link_Localizacao_Hospital_1];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Localizacao_Desemb') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [Link_Localizacao_Desemb];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Rota_DP_Desemb') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [Link_Rota_DP_Desemb];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Rota_DOE_Unidade_Apoio') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [Link_Rota_DOE_Unidade_Apoio];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'CoordenadaZPH') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [CoordenadaZPH];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'ResponsavelFotoMBA') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [ResponsavelFotoMBA];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'ResponsavelRelatorio') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [ResponsavelRelatorio];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'PrefixoVtrAPH') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [PrefixoVtrAPH];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'MotoristaVtrAPH') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [MotoristaVtrAPH];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'SocorristaAPH2') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [SocorristaAPH2];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'SocorristaAPH1') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [SocorristaAPH1];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'HorarioBriefingDP') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [HorarioBriefingDP];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'HorarioSaidaDOE') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [HorarioSaidaDOE];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'HorarioBriefingDOE') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [HorarioBriefingDOE];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'LocalBriefing') IS NOT NULL
    ALTER TABLE dbo.Planejamento DROP COLUMN [LocalBriefing];");
            Sql(@"IF COL_LENGTH(N'dbo.Planejamento', N'Link_Endereco_Alvo') IS NOT NULL AND COL_LENGTH(N'dbo.Planejamento', N'LinkGoogleMaps') IS NULL
    EXEC sys.sp_rename N'dbo.Planejamento.Link_Endereco_Alvo', N'LinkGoogleMaps', N'COLUMN';");
        }
    }
}
