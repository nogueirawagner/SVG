# Tela de planejamento baseada no modelo padrão

Referência: `Planejamento Operacoes/PADRAO_PLANEJAMENTO_SISTEMA.docx`. O Word permanece intacto; biblioteca de modelos e exportação continuam para etapa posterior.

## Tópicos na criação e edição

| Tópico do modelo | Campos e componentes |
| --- | --- |
| 1. Informações Preliminares | Ordem de serviço, unidade de apoio, data/hora do apoio, local do briefing, MBA, MP e número do MBA |
| 2. Identificação do Alvo | Consulta/reutilização de pessoas, identificação, foto e anexos de cada alvo; relação N:N preservada |
| 3. Endereço do Alvo | Endereço, referência e `Link_Endereco_Alvo`; coordenadas preenchidas a partir desse link |
| 4. Imagens | Fotos/vídeos do planejamento; sugestões do modelo apresentadas no formulário |
| 5. Quadro de Funções | Operador, entrada, função e prefixo/viatura |
| 6. Quadro de Horários | Briefing na DOE/SOR, saída da DOE e briefing na DP; horários sem data, armazenados como `time` |
| 7. Comunicações durante Trajeto | Canais das viaturas e operadores |
| 8. APH – Médico | Dois socorristas, prefixo da viatura, motorista e observações; orientações fixas do documento exibidas como conteúdo de referência |
| 9. Medidas Complementares | Responsáveis pelo relatório/escritura e conferência/foto do MBA; particularidades e registros adicionais existentes |
| 10. Resumo das Rotas | DOE → unidade de apoio e DP → desembarque, com link, distância em km e duração em minutos independentes |
| 11. Resumo das Localizações | Desembarque, alvo, hospital 1, hospital 2 e coordenada ZPH |

Cada tópico tem uma partial própria em `SVG.WebApp/Views/Planejamento`. Os novos campos são opcionais para manter a edição dos registros anteriores. Socorristas, motorista APH e responsáveis são identificações textuais; o quadro de funções continua vinculado aos operadores e viaturas cadastrados. Os horários são horários do planejamento, sem conversão de fuso nem inferência automática de passagem de dia.

## Links com responsabilidades distintas

| Uso | Propriedade persistida |
| --- | --- |
| Endereço/localização do alvo | `Link_Endereco_Alvo` |
| Rota DOE → unidade de apoio | `Link_Rota_DOE_Unidade_Apoio` |
| Rota DP → desembarque | `Link_Rota_DP_Desemb` |
| Localização do desembarque | `Link_Localizacao_Desemb` |
| Localização do hospital 1 | `Link_Localizacao_Hospital_1` |
| Localização do hospital 2 | `Link_Localizacao_Hospital_2` |

O resumo da localização do alvo exibe o mesmo link da seção Endereço do Alvo, em campo somente leitura sincronizado na tela. Não existe uma segunda propriedade para o mesmo endereço. Links de rotas e hospitais não alteram a latitude/longitude do alvo; aceitam HTTPS e têm validação própria. A coordenada ZPH é textual e distinta das coordenadas do alvo.

Os registros genéricos já existentes de horários, rotas, mandados, localizações e providências não são apagados nem convertidos automaticamente. Permanecem em Registros adicionais, dentro de Medidas Complementares, para permitir revisão sem inferir o significado de texto livre.

## Migration incremental

`20261106211814307_202611061818` renomeia a coluna de endereço com `sp_rename`, preservando os valores, e adiciona 20 campos ao planejamento e `Entrada` ao integrante. As colunas novas são opcionais. Se uma instalação parcial tiver ambas as colunas de link, valores não conflitantes são consolidados; divergências interrompem a migration sem escolher um valor arbitrário. Há verificações de existência nas operações. As migrations anteriores não foram alteradas e nenhuma migration foi executada nesta tarefa.

O snapshot foi comparado ao anterior: somente a renomeação e as colunas previstas foram detectadas. Validação inclui regras de horários/URLs/distâncias, mapeamento de edição, renderização dos 11 tópicos, postagem dos campos e leitura do snapshot EF6 sem conexão ao banco.
