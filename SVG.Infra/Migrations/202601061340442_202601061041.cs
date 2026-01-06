namespace SVG.Infra.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class _202601061041 : DbMigration
  {
    public override void Up()
    {
      Sql(@"
       DECLARE @SessaoSorgId INT;

        -- ======================================================
        -- 2. RECUPERA O ID DA SESSÃO SORG
        -- ======================================================
        SELECT 
            @SessaoSorgId = ID
        FROM Sessao
        WHERE Nome = 'SORG';

        -- ======================================================
        -- 3. INSERÇÃO IDEMPOTENTE DOS OPERADORES
        -- ======================================================

        IF NOT EXISTS (SELECT 1 FROM Operador WHERE Matricula = '58.942-X')
        BEGIN
            INSERT INTO Operador (Matricula, Nome, SessaoID)
            VALUES ('58.942-X', 'Antonio Jose Lima', @SessaoSorgId);
        END

        IF NOT EXISTS (SELECT 1 FROM Operador WHERE Matricula = '217.314-X')
        BEGIN
            INSERT INTO Operador (Matricula, Nome, SessaoID)
            VALUES ('217.314-X', 'Ricardo Augusto Monteiro Da Silva', @SessaoSorgId);
        END

        IF NOT EXISTS (SELECT 1 FROM Operador WHERE Matricula = '63.424-7')
        BEGIN
            INSERT INTO Operador (Matricula, Nome, SessaoID)
            VALUES ('63.424-7', 'Mauricio Felipe Da Silva', @SessaoSorgId);
        END

        IF NOT EXISTS (SELECT 1 FROM Operador WHERE Matricula = '75.742-X')
        BEGIN
            INSERT INTO Operador (Matricula, Nome, SessaoID)
            VALUES ('75.742-X', 'Ananias Batista Gomes Junior', @SessaoSorgId);
        END

        IF NOT EXISTS (SELECT 1 FROM Operador WHERE Matricula = '57.950-5')
        BEGIN
            INSERT INTO Operador (Matricula, Nome, SessaoID)
            VALUES ('57.950-5', 'Alexandre J. R. Brito Fontes', @SessaoSorgId);
        END



      ");
    }

    public override void Down()
    {
    }
  }
}
