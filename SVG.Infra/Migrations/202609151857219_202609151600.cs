namespace SVG.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202609151600 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Viatura", "PlacaOficial", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.Sessao", "Nome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Operador", "Matricula", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Operador", "Nome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Operador", "Telefone", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Operador", "Alcunha", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Operacao", "Coordenador", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Viatura", "Prefixo", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Viatura", "Placa", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.Viatura", "Marca", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Viatura", "Modelo", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.ViaturaMovimentacao", "Observacao", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Usuario", "Login", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Usuario", "Nome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Usuario", "PasswordHash", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Role", "Nome", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Role", "Nome", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Usuario", "PasswordHash", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Usuario", "Nome", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Usuario", "Login", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.ViaturaMovimentacao", "Observacao", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Viatura", "Modelo", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Viatura", "Marca", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Viatura", "Placa", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Viatura", "Prefixo", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Operacao", "Coordenador", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Operador", "Alcunha", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Operador", "Telefone", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Operador", "Nome", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Operador", "Matricula", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Sessao", "Nome", c => c.String(maxLength: 500, unicode: false));
            DropColumn("dbo.Viatura", "PlacaOficial");
        }
    }
}
