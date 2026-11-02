# Migração de auditoria das movimentações de viatura

A migração já está preparada nos arquivos `SVG.Infra/Migrations/202611020920.*`. Não é necessário gerar outra. Comando de referência para geração no Console do Gerenciador de Pacotes do Visual Studio:

```powershell
Add-Migration 202611020920 -Project SVG.Infra -StartupProject SVG.WebApp
```

Revisar a migração antes de aplicá-la. Ela acrescenta `OperadorResponsavelID` em `ViaturaMovimentacao`, com índice e chave estrangeira para `Operador`, sem exclusão em cascata. O campo é anulável para preservar registros antigos cujo autor autenticado não é conhecido. Todas as novas retiradas, devoluções e fechamentos automáticos exigem e gravam o operador autenticado. Não preencher o histórico com `OperadorID`, pois ele pode representar outra pessoa.

`NivelCombustivelAtual` é apenas uma propriedade de consulta, não uma coluna nova. A listagem utiliza o último nível informado na movimentação.

Somente após revisão e autorização explícita do usuário:

```powershell
Update-Database -v -Project SVG.Infra -StartupProject SVG.WebApp
```

Os arquivos gerados já existentes foram revisados e renomeados para o padrão solicitado, preservando o identificador interno do Entity Framework. Nenhuma atualização do banco foi executada nesta alteração. A migração anterior de combustível permanece separada.
