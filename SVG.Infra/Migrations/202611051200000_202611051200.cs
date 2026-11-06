namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class _202611051200 : DbMigration
    {
        public override void Up()
        {
            // Reconcilia o nome da migration sem recriar objetos já existentes.
            // Primeiro as tabelas; depois os relacionamentos, índices e restrições.
            Sql(@"IF OBJECT_ID(N'dbo.Planejamento', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Planejamento] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SecaoID] int NOT NULL,
    [CriadorOperadorID] int NOT NULL,
    [Titulo] varchar(200) NOT NULL,
    [MBA] bit NOT NULL,
    [MP] bit NOT NULL,
    [NumeroMBA] varchar(100) NULL,
    [DataPrevista] datetime NULL,
    [Situacao] varchar(20) NOT NULL,
    [OrdemServico] varchar(100) NULL,
    [UnidadeApoio] varchar(200) NULL,
    [Objetivo] varchar(8000) NULL,
    [Endereco] varchar(1000) NULL,
    [Referencia] varchar(1000) NULL,
    [Latitude] decimal(10,7) NULL,
    [Longitude] decimal(10,7) NULL,
    [CanalViaturas] varchar(200) NULL,
    [CanalOperadores] varchar(200) NULL,
    [ApoioMedico] varchar(8000) NULL,
    [Particularidades] varchar(8000) NULL,
    [DataHoraCriacao] datetime NOT NULL,
    [DataHoraAtualizacao] datetime NOT NULL,
    [AtualizadoPorOperadorID] int NOT NULL,
    [Versao] rowversion NOT NULL,
    CONSTRAINT [PK_dbo.Planejamento] PRIMARY KEY ([ID])
    );
END;");

            Sql(@"IF OBJECT_ID(N'dbo.PlanejamentoAlvo', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[PlanejamentoAlvo] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [PlanejamentoID] int NOT NULL,
    [AlvoID] int NOT NULL,
    [Codigo] varchar(30) NULL,
    [Observacoes] varchar(8000) NULL,
    CONSTRAINT [PK_dbo.PlanejamentoAlvo] PRIMARY KEY ([ID])
    );
END;");

            Sql(@"IF OBJECT_ID(N'dbo.Alvo', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Alvo] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(200) NOT NULL,
    [Alcunha] varchar(200) NULL,
    [CPF] varchar(11) NULL,
    [RG] varchar(100) NULL,
    [DataNascimento] datetime NULL,
    [NomeMae] varchar(200) NULL,
    [NomePai] varchar(200) NULL,
    [DataHoraCriacao] datetime NOT NULL,
    CONSTRAINT [PK_dbo.Alvo] PRIMARY KEY ([ID])
    );
END;");

            Sql(@"IF OBJECT_ID(N'dbo.AnexoAlvo', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[AnexoAlvo] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AlvoID] int NOT NULL,
    [NomeArquivo] varchar(255) NOT NULL,
    [TipoMime] varchar(100) NOT NULL,
    [Caminho] varchar(500) NOT NULL,
    [DataHoraCriacao] datetime NOT NULL,
    [FotoPrincipal] bit NOT NULL,
    CONSTRAINT [PK_dbo.AnexoAlvo] PRIMARY KEY ([ID])
    );
END;");

            Sql(@"IF OBJECT_ID(N'dbo.InformacaoAlvo', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[InformacaoAlvo] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AlvoID] int NOT NULL,
    [Texto] varchar(8000) NOT NULL,
    [Fonte] varchar(500) NULL,
    [DataHoraCriacao] datetime NOT NULL,
    CONSTRAINT [PK_dbo.InformacaoAlvo] PRIMARY KEY ([ID])
    );
END;");

            Sql(@"IF OBJECT_ID(N'dbo.AnexoPlanejamento', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[AnexoPlanejamento] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [PlanejamentoID] int NOT NULL,
    [NomeArquivo] varchar(255) NOT NULL,
    [TipoMime] varchar(100) NOT NULL,
    [Caminho] varchar(500) NOT NULL,
    [DataHoraCriacao] datetime NOT NULL,
    CONSTRAINT [PK_dbo.AnexoPlanejamento] PRIMARY KEY ([ID])
    );
END;");

            Sql(@"IF OBJECT_ID(N'dbo.PlanejamentoIntegrante', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[PlanejamentoIntegrante] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [PlanejamentoID] int NOT NULL,
    [OperadorID] int NOT NULL,
    [ViaturaID] int NULL,
    [Funcao] varchar(300) NOT NULL,
    CONSTRAINT [PK_dbo.PlanejamentoIntegrante] PRIMARY KEY ([ID])
    );
END;");

            Sql(@"IF OBJECT_ID(N'dbo.PlanejamentoItem', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[PlanejamentoItem] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [PlanejamentoID] int NOT NULL,
    [Tipo] varchar(20) NOT NULL,
    [Descricao] varchar(1000) NOT NULL,
    [DataHora] datetime NULL,
    [Responsavel] varchar(200) NULL,
    [Url] varchar(2000) NULL,
    [DistanciaKm] decimal(10,2) NULL,
    [DuracaoMinutos] int NULL,
    CONSTRAINT [PK_dbo.PlanejamentoItem] PRIMARY KEY ([ID])
    );
END;");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.Planejamento') AND name = N'FK_dbo.Planejamento_dbo.Sessao_SecaoID')
    ALTER TABLE [dbo].[Planejamento] ADD CONSTRAINT [FK_dbo.Planejamento_dbo.Sessao_SecaoID] FOREIGN KEY ([SecaoID]) REFERENCES [dbo].[Sessao] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.Planejamento') AND name = N'IX_SecaoID')
    CREATE INDEX [IX_SecaoID] ON [dbo].[Planejamento] ([SecaoID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.PlanejamentoAlvo') AND name = N'FK_dbo.PlanejamentoAlvo_dbo.Alvo_AlvoID')
    ALTER TABLE [dbo].[PlanejamentoAlvo] ADD CONSTRAINT [FK_dbo.PlanejamentoAlvo_dbo.Alvo_AlvoID] FOREIGN KEY ([AlvoID]) REFERENCES [dbo].[Alvo] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.PlanejamentoAlvo') AND name = N'FK_dbo.PlanejamentoAlvo_dbo.Planejamento_PlanejamentoID')
    ALTER TABLE [dbo].[PlanejamentoAlvo] ADD CONSTRAINT [FK_dbo.PlanejamentoAlvo_dbo.Planejamento_PlanejamentoID] FOREIGN KEY ([PlanejamentoID]) REFERENCES [dbo].[Planejamento] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.PlanejamentoAlvo') AND name = N'IX_PlanejamentoID_AlvoID')
    CREATE UNIQUE INDEX [IX_PlanejamentoID_AlvoID] ON [dbo].[PlanejamentoAlvo] ([PlanejamentoID], [AlvoID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.PlanejamentoAlvo') AND name = N'IX_AlvoID')
    CREATE INDEX [IX_AlvoID] ON [dbo].[PlanejamentoAlvo] ([AlvoID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.Alvo') AND name = N'IX_Nome')
    CREATE INDEX [IX_Nome] ON [dbo].[Alvo] ([Nome]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.AnexoAlvo') AND name = N'FK_dbo.AnexoAlvo_dbo.Alvo_AlvoID')
    ALTER TABLE [dbo].[AnexoAlvo] ADD CONSTRAINT [FK_dbo.AnexoAlvo_dbo.Alvo_AlvoID] FOREIGN KEY ([AlvoID]) REFERENCES [dbo].[Alvo] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.AnexoAlvo') AND name = N'IX_AlvoID')
    CREATE INDEX [IX_AlvoID] ON [dbo].[AnexoAlvo] ([AlvoID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.InformacaoAlvo') AND name = N'FK_dbo.InformacaoAlvo_dbo.Alvo_AlvoID')
    ALTER TABLE [dbo].[InformacaoAlvo] ADD CONSTRAINT [FK_dbo.InformacaoAlvo_dbo.Alvo_AlvoID] FOREIGN KEY ([AlvoID]) REFERENCES [dbo].[Alvo] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.InformacaoAlvo') AND name = N'IX_AlvoID')
    CREATE INDEX [IX_AlvoID] ON [dbo].[InformacaoAlvo] ([AlvoID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.AnexoPlanejamento') AND name = N'FK_dbo.AnexoPlanejamento_dbo.Planejamento_PlanejamentoID')
    ALTER TABLE [dbo].[AnexoPlanejamento] ADD CONSTRAINT [FK_dbo.AnexoPlanejamento_dbo.Planejamento_PlanejamentoID] FOREIGN KEY ([PlanejamentoID]) REFERENCES [dbo].[Planejamento] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.AnexoPlanejamento') AND name = N'IX_PlanejamentoID')
    CREATE INDEX [IX_PlanejamentoID] ON [dbo].[AnexoPlanejamento] ([PlanejamentoID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.PlanejamentoIntegrante') AND name = N'FK_dbo.PlanejamentoIntegrante_dbo.Operador_OperadorID')
    ALTER TABLE [dbo].[PlanejamentoIntegrante] ADD CONSTRAINT [FK_dbo.PlanejamentoIntegrante_dbo.Operador_OperadorID] FOREIGN KEY ([OperadorID]) REFERENCES [dbo].[Operador] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.PlanejamentoIntegrante') AND name = N'FK_dbo.PlanejamentoIntegrante_dbo.Planejamento_PlanejamentoID')
    ALTER TABLE [dbo].[PlanejamentoIntegrante] ADD CONSTRAINT [FK_dbo.PlanejamentoIntegrante_dbo.Planejamento_PlanejamentoID] FOREIGN KEY ([PlanejamentoID]) REFERENCES [dbo].[Planejamento] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.PlanejamentoIntegrante') AND name = N'FK_dbo.PlanejamentoIntegrante_dbo.Viatura_ViaturaID')
    ALTER TABLE [dbo].[PlanejamentoIntegrante] ADD CONSTRAINT [FK_dbo.PlanejamentoIntegrante_dbo.Viatura_ViaturaID] FOREIGN KEY ([ViaturaID]) REFERENCES [dbo].[Viatura] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.PlanejamentoIntegrante') AND name = N'IX_PlanejamentoID_OperadorID')
    CREATE UNIQUE INDEX [IX_PlanejamentoID_OperadorID] ON [dbo].[PlanejamentoIntegrante] ([PlanejamentoID], [OperadorID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.PlanejamentoIntegrante') AND name = N'IX_ViaturaID')
    CREATE INDEX [IX_ViaturaID] ON [dbo].[PlanejamentoIntegrante] ([ViaturaID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID(N'dbo.PlanejamentoItem') AND name = N'FK_dbo.PlanejamentoItem_dbo.Planejamento_PlanejamentoID')
    ALTER TABLE [dbo].[PlanejamentoItem] ADD CONSTRAINT [FK_dbo.PlanejamentoItem_dbo.Planejamento_PlanejamentoID] FOREIGN KEY ([PlanejamentoID]) REFERENCES [dbo].[Planejamento] ([ID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.PlanejamentoItem') AND name = N'IX_PlanejamentoID')
    CREATE INDEX [IX_PlanejamentoID] ON [dbo].[PlanejamentoItem] ([PlanejamentoID]);");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.Alvo') AND name = N'UX_Alvo_CPF')
    CREATE UNIQUE INDEX [UX_Alvo_CPF] ON dbo.Alvo (CPF) WHERE CPF IS NOT NULL;");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.PlanejamentoAlvo') AND name = N'UX_PlanejamentoAlvo_Codigo')
    CREATE UNIQUE INDEX [UX_PlanejamentoAlvo_Codigo] ON dbo.PlanejamentoAlvo (PlanejamentoID,Codigo) WHERE Codigo IS NOT NULL;");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.AnexoAlvo') AND name = N'UX_AnexoAlvo_FotoPrincipal')
    CREATE UNIQUE INDEX [UX_AnexoAlvo_FotoPrincipal] ON dbo.AnexoAlvo (AlvoID) WHERE FotoPrincipal = 1;");

            Sql(@"IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE parent_object_id = OBJECT_ID(N'dbo.Planejamento') AND name = N'CK_Planejamento_Coordenadas')
    ALTER TABLE dbo.Planejamento ADD CONSTRAINT CK_Planejamento_Coordenadas CHECK ((Latitude IS NULL AND Longitude IS NULL) OR (Latitude IS NOT NULL AND Longitude IS NOT NULL AND Latitude BETWEEN -90 AND 90 AND Longitude BETWEEN -180 AND 180));");

        }

        public override void Down()
        {
            // Up pode apenas reconhecer tabelas criadas pela migration de nome anterior.
            // Não é possível distinguir esses objetos dos criados por esta execução.
            throw new NotSupportedException("Reversão automática indisponível: esta migration pode reutilizar tabelas e dados preexistentes.");
        }
    }
}
