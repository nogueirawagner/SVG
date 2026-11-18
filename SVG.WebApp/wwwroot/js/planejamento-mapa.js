(function (root) {
    'use strict';
    function filtrar(registros, filtros, distancia) {
        return registros.filter(p => (!filtros.ano || p.Ano === Number(filtros.ano)) &&
            (!filtros.mes || p.Mes === Number(filtros.mes)) && (!filtros.secao || p.SecaoID === Number(filtros.secao)) &&
            (!filtros.raio || !filtros.centro || distancia(filtros.centro, { lat: p.Latitude, lng: p.Longitude }) <= filtros.raio + 0.000001));
    }
    if (typeof module !== 'undefined') module.exports = { filtrar };
    if (typeof document === 'undefined') return;
    const pagina = document.getElementById('planejamento-mapa-pagina');
    if (!pagina) return;
    const dados = JSON.parse(document.getElementById('planejamento-mapa-dados').textContent);
    const ano = document.getElementById('mapa-ano'), mes = document.getElementById('mapa-mes'), secao = document.getElementById('mapa-secao'), raio = document.getElementById('mapa-raio');
    const nomesMeses = ['Janeiro','Fevereiro','Março','Abril','Maio','Junho','Julho','Agosto','Setembro','Outubro','Novembro','Dezembro'];
    let centro = null, mapa;
    function opcoes(select, itens) {
        const valor = select.value;
        select.replaceChildren(new Option(select === secao ? 'Todas' : 'Todos', ''));
        itens.forEach(([id, nome]) => select.add(new Option(nome, String(id))));
        if ([...select.options].some(o => o.value === valor)) select.value = valor;
    }
    opcoes(ano, [...new Set(dados.map(p => p.Ano).filter(Boolean))].sort((a,b) => b-a).map(a => [a,a]));
    opcoes(secao, [...new Map(dados.map(p => [p.SecaoID,p.Secao]))].sort((a,b) => a[1].localeCompare(b[1], 'pt-BR')));
    function meses() {
        opcoes(mes, [...new Set(dados.filter(p => (!ano.value || p.Ano === Number(ano.value)) && (!secao.value || p.SecaoID === Number(secao.value))).map(p => p.Mes).filter(Boolean))].sort((a,b) => a-b).map(m => [m,nomesMeses[m-1]]));
    }
    function link(p) {
        const a = document.createElement('a');
        const url = new URL(pagina.dataset.detalhesUrl, location.origin);
        url.searchParams.set('id', p.ID);
        a.href = url.href; a.textContent = p.Titulo;
        return a;
    }
    function atualizar(ajustar = false) {
        const metros = Number(raio.value);
        const visiveis = filtrar(dados, { ano: ano.value, mes: mes.value, secao: secao.value, raio: metros, centro }, SvgMapas.distanciaMetros);
        document.getElementById('mapa-contagem').textContent = `${visiveis.length} de ${dados.length} planejamento(s) carregado(s).`;
        document.getElementById('mapa-instrucao').textContent = metros && !centro ? 'Clique no mapa para definir o centro e aplicar o raio selecionado.' : centro ? `Centro: ${centro.lat.toFixed(6)}, ${centro.lng.toFixed(6)}. ${metros ? `Raio de ${metros} m aplicado. Clique em outro ponto para mover o centro.` : 'Sem filtro de raio.'}` : 'Selecione um raio e clique no mapa para definir o centro da busca.';
        const lista = document.getElementById('mapa-resultados'); lista.replaceChildren();
        visiveis.forEach(p => { const li = document.createElement('li'); li.className = 'list-group-item'; li.append(link(p)); lista.append(li); });
        if (!visiveis.length) { const li = document.createElement('li'); li.className = 'list-group-item text-muted'; li.textContent = 'Nenhum planejamento encontrado neste conjunto de dados.'; lista.append(li); }
        // Um marcador por coordenada; o popup lista todos os planejamentos no mesmo endereço.
        const grupos = new Map();
        visiveis.forEach(p => { const chave = `${p.Latitude},${p.Longitude}`; if (!grupos.has(chave)) grupos.set(chave, []); grupos.get(chave).push(p); });
        mapa?.definirPontos([...grupos.values()].map(itens => ({ posicao: { lat: itens[0].Latitude, lng: itens[0].Longitude }, titulo: itens.map(p => p.Titulo).join(' | '), conteudo: () => {
            const div = document.createElement('div');
            itens.forEach(p => { const linha = document.createElement('p'); linha.append(link(p)); const endereco = document.createElement('div'); endereco.textContent = p.Endereco || 'Endereço não informado'; linha.append(endereco); div.append(linha); });
            return div;
        } })), ajustar && !metros);
        mapa?.definirRaio(centro, metros);
    }
    [ano, secao].forEach(select => select.addEventListener('change', () => { meses(); atualizar(true); }));
    mes.addEventListener('change', () => atualizar(true));
    raio.addEventListener('change', () => atualizar());
    document.getElementById('mapa-limpar-centro').addEventListener('click', () => { centro = null; atualizar(); });
    document.getElementById('mapa-limpar').addEventListener('click', () => { ano.value = ''; secao.value = ''; meses(); mes.value = ''; raio.value = '0'; centro = null; atualizar(true); });
    function erro(mensagem) { const aviso = document.getElementById('mapa-erro'); aviso.textContent = mensagem; aviso.hidden = false; }
    root.addEventListener('svg:mapa-erro', () => erro('Google Maps indisponível. Solicite a revisão da configuração ao administrador.'));
    meses(); atualizar();
    SvgMapas.criar(document.getElementById('planejamento-mapa'), { apiKey: pagina.dataset.apiKey, mapId: pagina.dataset.mapId, aoClicar: ponto => { centro = ponto; atualizar(); } })
        .then(instancia => { mapa = instancia; atualizar(true); })
        .catch(e => erro(e.message));
})(typeof window !== 'undefined' ? window : globalThis);
