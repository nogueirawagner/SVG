# Exportação do planejamento para PDF

- Ação autenticada `GET /Planejamento/GerarPdf/{id}`: mesma abrangência de consulta dos detalhes. Rascunhos e finalizados podem ser exportados. Retorna download `application/pdf`, nome igual ao título do Index acrescido de `.pdf` (caracteres inválidos em nomes de arquivo são substituídos por hífen), sem cache; inexistente retorna 404.
- Botões **Gerar PDF** no topo e ao final de Detalhes; ícone na última coluna do Index.
- `PlanejamentoDocumentoAppService` reúne o planejamento e as fotos principais. `IGeradorPlanejamentoPdf` separa o contrato da implementação `GeradorPlanejamentoPdf`, na infraestrutura.
- Modelo inicial próprio para PDF, baseado nos agrupamentos da tela. Não interpreta o Word e não implementa ainda a biblioteca de modelos por seção. Essa biblioteca poderá substituir/selecionar o gerador sem acoplar sua lógica ao controller ou às views.
- Conteúdo: título, preliminares, endereço, alvos/fotos/filiação, imagens em subgrupos e ordem, equipe com tabela e linhas verticais, horários, comunicações, APH, medidas, rotas, localizações, itens adicionais e datas de registro.
- Imagens são lidas exclusivamente por `IArmazenamentoAnexos`; não há requisições remotas para capturar páginas ou arquivos. Vídeos aparecem como links autenticados para baixar no sistema. Imagens indisponíveis são identificadas no documento. Limite de 50 MB por imagem e 200 MB acumulados por exportação; acima disso a tela informa o erro.
- Geração em memória, sem criar PDFs permanentes no servidor e sem alterações de banco/migrations. Arquivos de exemplo são somente testes com dados fictícios.
- Dependência: PDFsharp-MigraDoc **6.2.0**, licença MIT confirmada no pacote; fontes DejaVu Sans regular/negrito embarcadas como recursos, com licença incluída, para funcionar também sem fontes do sistema/Azure.
- Testes: geração de documento multipágina com foto, quatro subgrupos de imagens, vídeo, 65 integrantes e texto longo; leitura do PDF, conferência visual por rasterização, download HTTP, bloqueio anônimo e 404.

Gerar exemplo local (sem banco): `dotnet run --project SVG.Tests -- --pdf-planejamento`. Saída: `tmp/pdfs/Planejamento-exemplo.pdf`.
