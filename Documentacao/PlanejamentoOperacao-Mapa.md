# Mapa de planejamentos

Tela autenticada: `/Planejamento/Mapa`, acessível por **Ver mapa** no Index.

## Dados e filtros

- Consulta única no carregamento: até 100 planejamentos com latitude e longitude válidas, por ID decrescente. Não usa a seção do usuário como restrição de acesso.
- Ano e mês usam a data do apoio (`DataPrevista`). Os combos são derivados somente dos registros carregados; meses se ajustam ao ano e à seção. Registros sem data aparecem com os filtros de data em Todos.
- Filtros de ano, mês, seção e raio combinados no navegador. Nenhuma requisição à aplicação ao filtrar ou clicar no mapa. O SDK do Google faz suas próprias requisições de mapas.
- Raios: sem seleção, 100, 400 e 500 metros. Clique no mapa para definir/mover o centro. Enquanto não houver centro, o raio não filtra e a tela orienta o usuário.
- Distância geodésica calculada localmente (Haversine, raio terrestre de 6.378.137 m, equivalente ao padrão esférico do Maps). Tolerância de 0,000001 m na borda para arredondamento numérico.
- Marcadores vermelhos; coordenadas coincidentes compartilham um marcador com todos os links. A lista abaixo do mapa permite acessar todos os resultados.

## Configuração Google Cloud

Usar o projeto gerenciado pela conta `engnogueirawgn@gmail.com`. O e-mail não é credencial de API e não é incluído no código. Nenhum recurso foi criado nessa conta por esta implementação.

1. Entrar no Google Cloud Console com essa conta e selecionar/criar um projeto.
2. Vincular faturamento ao projeto e habilitar **Maps JavaScript API**.
3. Criar uma chave de API para uso no navegador. Restringir a chave por **Sites / HTTP referrers**, incluindo apenas os endereços usados em desenvolvimento e produção, e restringir a API a **Maps JavaScript API**.
4. Criar um Map ID de JavaScript para produção. Sem configuração de MapId, a aplicação usa `DEMO_MAP_ID` para avaliação.
5. Conforme a preferência do projeto, preencher a seção `GoogleMaps` de `SVG.WebApp/appsettings.json`, no mesmo arquivo das connection strings:

```json
"GoogleMaps": {
  "ApiKey": "CHAVE_DO_PROJETO",
  "MapId": "MAP_ID_DO_PROJETO"
}
```

Os campos foram adicionados vazios; a chave ainda precisa ser fornecida. Reiniciar a aplicação após configurar. A chave de navegador aparece necessariamente no cliente; aplicar as restrições de sites e API no Google Cloud.

Sem chave, a tela mostra aviso e mantém a lista de resultados; não tenta geocodificar endereços nem faz requisições de Directions/Routes. Nenhuma migration necessária ou executada.

Documentação oficial:
- https://developers.google.com/maps/documentation/javascript/get-api-key
- https://developers.google.com/maps/documentation/javascript/advanced-markers/add-marker
- https://developers.google.com/maps/documentation/javascript/geometry

## Reutilização

`wwwroot/js/mapas/google-maps.js` é independente de Planejamento. Expõe `SvgMapas.criar(elemento, {apiKey, mapId, aoClicar})` e `SvgMapas.distanciaMetros(a, b)`. A instância possui `definirPontos(pontos, ajustar)`, `definirRaio(centro, metros)` e `destruir()`. Cada ponto fornece `posicao`, `titulo` e uma função `conteudo()` que retorna um nó DOM para seu popup. O SDK é carregado uma única vez por página.

`wwwroot/js/planejamento-mapa.js` adapta os dados do planejamento ao componente e controla filtros, contagem e lista. Conteúdo de registros é inserido com `textContent`, sem HTML vindo do banco. O JSON inicial usa o escape padrão de System.Text.Json.

Verificação local sem credenciais: `node SVG.Tests/planejamento-mapa-checks.cjs`. A suíte HTTP/Razor verifica a rota com repositório simulado. O mapa real precisa ser validado após configurar a chave e o projeto Google Cloud.
