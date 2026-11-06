# Implementação do núcleo de Planejamento

Alterações disponíveis para revisão em 05/11/2026. Nenhuma migration foi executada e nenhum banco foi alterado.

## Fluxo implementado

- Cadastro integrado de planejamento e alvos, com reutilização de pessoas existentes e vínculo N:N em PlanejamentoAlvo.
- Um endereço por planejamento, com latitude/longitude. Consulta pelo alvo reúne seus planejamentos e os endereços de cada ocasião.
- Seção derivada do operador autenticado; filtro opcional pela seção, sem restringir consultas entre seções.
- Rascunho, edição pelo autor/administrador, finalização e visualização geral. Finalizados são somente leitura. Vínculos já gravados não são removidos nesta entrega.
- Equipe, viaturas, horários, rotas, localizações de apoio, mandados, providências, comunicações, apoio médico e particularidades.
- Biblioteca de modelos e exportação de documentos continuam para etapas posteriores.

## Padrões e componentes

Controller → AppService → Service de domínio → Repository, com registros no SimpleInjector. Os contratos de entrada/resumo possuem prefixo `X`, incluindo `XPlanejamentoEntrada`. As entidades usam `DataHoraCriacao`, seguindo a convenção existente de `DateTime.Now`; a atualização usa `DataHoraAtualizacao`.

`ApplicationCultureFilter` está registrado globalmente no MVC. Usa cultura invariável durante o model binding dos formulários HTML (ponto decimal e datas ISO), restaurando a cultura original para actions e resultados. A cultura da interface não é alterada. Formulários novos devem enviar valores de máquina; textos numéricos com separadores locais precisam de conversão explícita. O teste HTTP verifica leitura decimal/ISO e apresentação pt-BR em outro controller.

## Fotos e vídeos

`AnexoPlanejamento` e `AnexoAlvo` armazenam `Caminho` relativo, nome original, MIME, data e vínculo. Não possuem coluna de conteúdo binário. `FotoPrincipal` distingue a fotografia exibida no dossiê.

Organização:

```text
Imagens/Planejamento/{PlanejamentoID}/{hash}.ext
Imagens/Alvo/{AlvoID}/{hash}.ext
```

Os diretórios separados evitam colisões entre IDs das duas entidades. Cada upload recebe um identificador SHA-256 gerado a partir de bytes aleatórios criptográficos. A extensão é definida pelo tipo reconhecido, não pelo nome enviado pelo navegador. Nomes originais nunca formam caminhos físicos.

`IArmazenamentoAnexos` separa gravação, leitura e exclusão da implementação física. `ArmazenamentoAnexosLocal` é o provedor desta entrega. Por padrão, a raiz é o diretório da aplicação Web, fora de `wwwroot`. Pode ser substituída pela configuração `ArmazenamentoAnexos:Raiz` (variável de ambiente `ArmazenamentoAnexos__Raiz`). O processo precisa de acesso de leitura e gravação. Configure uma raiz absoluta e persistente, fora de diretórios públicos; inclua os arquivos no backup junto ao banco. Os uploads são excluídos do Git e da publicação.

No Azure, um volume persistente pode receber a mesma árvore. Uma implementação futura para Blob Storage deve usar o mesmo caminho relativo como chave do objeto, em contêiner privado; nenhuma URL pública ou credencial é persistida. O provedor de Blob Storage não está implementado nesta entrega.

Formatos aceitos: JPEG, PNG, MP4 e WebM. Há identificação por assinatura e formato, sem transcodificação. Limites: 5 MB para foto principal, 50 MB por outro arquivo, 100 MB combinados por gravação; até 20 anexos do planejamento e 50 anexos de alvos. O formulário aceita múltiplos anexos para alvos novos ou existentes. Os arquivos são recebidos em memória dentro desses limites; suporte a vídeos maiores demandará upload por streaming. O servidor/reverse proxy precisa permitir o corpo multipart de até 105 MiB (`110100480` bytes); em IIS, configurar também `requestFiltering/requestLimits/maxAllowedContentLength`.

Leitura por actions autenticadas, com MIME explícito, `nosniff` e suporte a intervalos de bytes. Não há exposição via arquivos estáticos.

## Consistência e banco

O planejamento é inserido primeiro, seguido dos novos alvos e vínculos, na mesma transação SQL. Arquivos são gravados após obter os IDs; caminhos entram na transação. Em falha, o repository reverte o banco e tenta excluir os arquivos da solicitação. Falhas de limpeza são registradas em Trace. Banco e disco não compartilham transação distribuída: encerramento abrupto do processo pode deixar arquivos órfãos, exigindo reconciliação operacional. Não se deve apagar arquivos sem conferir referências no banco.

Controle de concorrência por rowversion; unicidade de vínculo planejamento/alvo e planejamento/operador; índices filtrados para CPF, código por planejamento e foto principal. Coordenadas possuem restrição de par e intervalos válidos.

`202611051200000_202611051200` mantém o nome no padrão `yyyyMMddHHmm`. Por solicitação do usuário, seu `Up` verifica existência em `OBJECT_ID`/catálogos `sys` antes de criar tabelas, chaves estrangeiras, índices e restrições. Assim, reutiliza objetos existentes após a aplicação anterior sob o nome PlanejamentoOperacional. O histórico do banco não foi editado; o EF registrará a nova identidade quando o usuário aplicar a migration. O `Down` bloqueia exclusão automática porque não distingue objetos preexistentes dos criados nesta execução. A verificação de existência não corrige diferenças de estrutura nem dados incompatíveis com restrições ausentes. O gerador offline permanece bloqueado para não sobrescrever essa reconciliação manual.

## Validação

```powershell
dotnet build SVG.Tests/SVG.Tests.csproj --no-restore -m:1 -p:BuildInParallel=false
dotnet run --project SVG.Tests/SVG.Tests.csproj --no-build --no-restore
```

Verificações de regras, modelo EF6 em memória, armazenamento em diretório temporário e HTTP/Razor com repositório simulado. Nenhum teste usa banco real. A integração SQL e a persistência em Azure devem ser validadas em ambiente próprio após a revisão e aplicação autorizada do esquema.


## Ajuste do formulário — 06/11/2026

A seção da view passou de Dados gerais para Informações Preliminares, com Nº Ordem de Serviço, Unidade Apoio, Data e hora Apoio (mantendo a propriedade DataPrevista), MBA, MP e Nº MBA. MBA e MP são marcações independentes. O formulário compartilhado por criação e edição não exibe Título nem Objetivo. Valores existentes desses campos são preservados; novos planejamentos recebem uma identificação automática baseada na OS, ou “Planejamento” quando ela não for informada. MBA, MP e NumeroMBA são persistidos e recuperados na edição. A proposta de esquema foi atualizada offline, sem aplicação ao banco.


## Endereço do Alvo e Google Maps — 06/11/2026

A seção passou a se chamar Endereço do Alvo. Latitude e longitude permanecem no modelo, mas foram removidas da digitação manual. O campo LinkGoogleMaps dispara uma consulta automática e mostra as coordenadas encontradas. Ao salvar, o servidor resolve novamente o link, ignorando coordenadas enviadas pelo navegador. Na edição de registros anteriores sem link, as coordenadas existentes são preservadas; remover um link já cadastrado limpa as coordenadas correspondentes.

O serviço aceita HTTPS em domínios específicos do Google Maps e expande redirecionamentos de links curtos (maps.app.goo.gl e goo.gl/maps), validando cada destino, com limite de seis requisições e tempo total de 12 segundos. Links com coordenadas do ponto em query/q ou no trecho !3d/!4d são interpretados. Rotas, resultados ambíguos e links apenas com o centro da câmera não são usados como localização do alvo. Nessas situações, a tela orienta selecionar o ponto e compartilhar seu link. Não há geocodificação por endereço, leitura de HTML ou necessidade de chave de API nesta entrega. Testes de redirecionamento usam HTTP simulado, sem comunicação real com o Google.

Referência do formato query: [Google Maps URLs](https://developers.google.com/maps/documentation/urls/get-started).

Migration incremental `20261106210851101_202611061808` preparada com coluna nullable varchar(2048), verificando sua existência. O snapshot foi comparado com o anterior: apenas LinkGoogleMaps foi acrescentado. Nenhuma migration foi aplicada, e os arquivos das migrations anteriores não foram alterados nesta entrega.


## Alinhamento com o modelo Word — 06/11/2026

A nomenclatura vigente é `Link_Endereco_Alvo`. A tela foi organizada nos 11 tópicos do modelo, com links distintos de rotas e localizações e campos complementares persistidos. A migration incremental `20261106211814307_202611061818` preserva o valor do link anterior ao renomear a coluna. Veja [mapeamento dos tópicos e campos](PlanejamentoOperacao-ModeloPadrao.md). Nenhuma migration foi executada nesta tarefa.
