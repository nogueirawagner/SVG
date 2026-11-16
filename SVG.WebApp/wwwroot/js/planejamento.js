(() => {
    'use strict';
    document.querySelectorAll('.preservar-linhas').forEach(p => p.style.whiteSpace = 'pre-wrap');
    document.querySelectorAll('.alvo-foto').forEach(img => {
        const ausente = () => { img.hidden = true; const aviso = img.nextElementSibling; if (aviso?.classList.contains('foto-ausente')) aviso.hidden = false; };
        img.addEventListener('error', ausente);
        if (img.complete && img.naturalWidth === 0) ausente();
    });
    const form = document.getElementById('planejamento-form');
    if (!form) return;
    let alterado = false;
    // Mantém os controles no DOM: recolher nunca descarta valores ou arquivos selecionados.
    const grupos = [];
    const abrirGrupo = grupo => grupos.forEach(item => {
        const aberto = item === grupo;
        item.corpo.hidden = !aberto;
        item.botao.setAttribute('aria-expanded', String(aberto));
        item.icone.textContent = aberto ? '−' : '+';
    });
    document.querySelectorAll('#planejamento-grupos > section').forEach((section, index) => {
        const titulo = section.querySelector('h2');
        if (!titulo) return;
        const botao = document.createElement('button');
        botao.type = 'button';
        botao.className = 'btn text-start w-100 d-flex justify-content-between align-items-center p-0 fs-5';
        botao.append(document.createTextNode(titulo.textContent));
        const icone = document.createElement('span');
        icone.setAttribute('aria-hidden', 'true');
        botao.append(icone);
        const corpo = document.createElement('div');
        corpo.id = `planejamento-grupo-${index}`;
        corpo.className = 'pt-3';
        botao.id = `${corpo.id}-titulo`;
        botao.setAttribute('aria-controls', corpo.id);
        corpo.setAttribute('aria-labelledby', botao.id);
        const conteudo = [...section.childNodes].filter(node => node !== titulo);
        corpo.append(...conteudo);
        titulo.replaceChildren(botao);
        titulo.classList.add('mb-0');
        section.append(corpo);
        const grupo = { corpo, botao, icone };
        grupos.push(grupo);
        botao.addEventListener('click', () => abrirGrupo(corpo.hidden ? grupo : null));
    });
    abrirGrupo(null);
    const revelarCampo = campo => {
        const grupo = grupos.find(item => item.corpo.contains(campo));
        if (grupo) abrirGrupo(grupo);
    };
    const erros = JSON.parse(document.getElementById('planejamento-campos-invalidos')?.textContent || '[]');
    const campoComErro = [...form.elements].find(campo => erros.includes(campo.name));
    if (campoComErro) { revelarCampo(campoComErro); campoComErro.focus(); }
    // Valida após abrir o grupo, evitando controles inválidos invisíveis ao navegador.
    form.noValidate = true;
    const mapsLink = document.getElementById('Link_Endereco_Alvo');
    if (mapsLink) {
        const latitude = document.getElementById('Latitude');
        const longitude = document.getElementById('Longitude');
        const status = document.getElementById('maps-status');
        let timer, pending, version = 0;
        const consultar = async current => {
            pending = new AbortController();
            try {
                const response = await fetch(mapsLink.dataset.mapsUrl, {
                    method: 'POST', signal: pending.signal,
                    body: new URLSearchParams({
                        link: mapsLink.value.trim(),
                        __RequestVerificationToken: form.querySelector('[name="__RequestVerificationToken"]').value
                    })
                });
                if (response.redirected) throw new Error('Sua sessão expirou. Entre novamente para consultar o link.');
                const result = await response.json();
                if (current !== version) return;
                if (!response.ok) throw new Error(result.mensagem || 'Não foi possível obter as coordenadas.');
                latitude.value = result.latitude;
                longitude.value = result.longitude;
                status.textContent = `Latitude: ${result.latitude} · Longitude: ${result.longitude}`;
                status.className = 'form-text text-success';
            } catch (error) {
                if (current !== version || error.name === 'AbortError') return;
                status.textContent = error instanceof SyntaxError ? 'Não foi possível consultar o link. Verifique sua sessão e tente novamente.' : error.message;
                status.className = 'form-text text-danger';
            }
        };
        mapsLink.addEventListener('input', () => {
            clearTimeout(timer); pending?.abort();
            const current = ++version;
            const resumo = document.getElementById('link-alvo-resumo');
            if (resumo) resumo.value = mapsLink.value.trim();
            latitude.value = ''; longitude.value = '';
            status.className = 'form-text';
            if (!mapsLink.value.trim()) { status.textContent = 'Cole o link de compartilhar do ponto no Google Maps.'; return; }
            status.textContent = 'Buscando coordenadas…';
            timer = setTimeout(() => consultar(current), 600);
        });
    }
    const reindexar = container => {
        [...container.children].forEach((row, i) => {
            row.querySelectorAll('[data-campo]').forEach(input => input.name = `${container.dataset.colecao}[${i}].${input.dataset.campo}`);
            row.querySelectorAll('[data-anexos-alvo]').forEach(input => input.name = `AnexosAlvo_${i}`);
            row.querySelectorAll('[data-foto]').forEach(input => input.name = `Foto_${i}`);
        });
    };
    const adicionar = (id, template) => {
        const container = document.getElementById(id);
        const row = document.getElementById(template).content.firstElementChild.cloneNode(true);
        container.append(row); reindexar(container); alterado = true; return row;
    };
    const operadoresPorSecao = JSON.parse(document.getElementById('operadores-por-secao')?.textContent || '[]');
    const selecaoSecao = document.getElementById('integrantes-secao');
    const listaOperadoresSecao = document.getElementById('lista-operadores-secao');
    const operadoresIncluidos = () => new Set([...document.querySelectorAll('#integrantes [data-campo="OperadorID"]')].map(input => input.value));
    const atualizarSecoesIntegrantes = () => {
        document.querySelectorAll('#integrantes > .registro').forEach(row => {
            const operadorId = row.querySelector('[data-campo="OperadorID"]').value;
            const operador = operadoresPorSecao.find(op => String(op.ID) === operadorId);
            const secao = operador ? [...selecaoSecao.options].find(option => option.value === String(operador.SessaoID)) : null;
            const viaturas = row.querySelector('[data-campo="ViaturaID"]');
            const secaoId = operador ? String(operador.SessaoID) : '';
            if (viaturas.dataset.secaoOrdenada !== secaoId) {
                const selecionada = viaturas.value;
                const opcoes = [...viaturas.options].sort((a, b) => {
                    // Mantém "Não definida" e prioriza as viaturas da seção do operador.
                    if (!a.value) return -1;
                    if (!b.value) return 1;
                    const prioridadeA = secaoId && a.dataset.secao === secaoId ? 0 : 1;
                    const prioridadeB = secaoId && b.dataset.secao === secaoId ? 0 : 1;
                    return prioridadeA - prioridadeB || a.textContent.localeCompare(b.textContent, 'pt-BR', { numeric: true });
                });
                viaturas.append(...opcoes);
                viaturas.value = selecionada;
                viaturas.dataset.secaoOrdenada = secaoId;
            }
            row.querySelector('[data-secao-integrante]').textContent = `Seção - ${secao?.textContent || 'Não informada'}`;
            // Matiz estável por seção, compartilhado por todos os seus operadores.
            row.style.backgroundColor = secao ? `hsl(${(Number(operador.SessaoID) * 137.508) % 360}, 45%, 95%)` : '';
        });
    };
    const atualizarBotoesOperadores = () => {
        const incluidos = operadoresIncluidos();
        listaOperadoresSecao?.querySelectorAll('[data-incluir-operador]').forEach(botao => {
            botao.disabled = incluidos.has(botao.dataset.incluirOperador);
            botao.textContent = botao.disabled ? 'Adicionado' : 'Adicionar';
            botao.setAttribute('aria-disabled', String(botao.disabled));
        });
        // A identidade do integrante fica fixa até sua remoção. O select continua
        // habilitado para enviar o OperadorID normalmente ao salvar o formulário.
        document.querySelectorAll('#integrantes [data-campo="OperadorID"]').forEach(select => {
            if (!select.value) return;
            select.dataset.operadorIncluido ||= select.value;
            select.value = select.dataset.operadorIncluido;
            [...select.options].forEach(option => option.disabled = option.value !== select.value);
            select.title = 'Para trocar o operador, remova este integrante e adicione o desejado.';
        });
        atualizarSecoesIntegrantes();
    };
    const incluirOperador = op => {
        if (operadoresIncluidos().has(String(op.ID))) return false;
        const row = adicionar('integrantes', 'modelo-integrante');
        row.querySelector('[data-campo="OperadorID"]').value = String(op.ID);
        return true;
    };
    const mostrarOperadoresSecao = () => {
        if (!selecaoSecao || !listaOperadoresSecao) return;
        listaOperadoresSecao.replaceChildren();
        document.getElementById('integrantes-secao-status').textContent = '';
        const operadores = operadoresPorSecao.filter(op => String(op.SessaoID) === selecaoSecao.value)
            .sort((a, b) => (a.Nome || '').localeCompare(b.Nome || '', 'pt-BR'));
        const adicionarItem = (texto, vazio = false) => {
            const item = document.createElement('li');
            item.className = `list-group-item${vazio ? ' text-muted' : ''}`;
            item.textContent = texto;
            listaOperadoresSecao.append(item);
            return item;
        };
        if (!selecaoSecao.value) adicionarItem('Selecione uma seção para visualizar os operadores.', true);
        else if (!operadores.length) adicionarItem('Esta seção não possui operadores.', true);
        else operadores.forEach(op => {
            const item = adicionarItem('');
            item.classList.add('d-flex', 'justify-content-between', 'align-items-center', 'gap-3');
            const nome = document.createElement('span');
            nome.textContent = `${op.Nome}${op.Matricula ? ` (${op.Matricula})` : ''}`;
            const botao = document.createElement('button');
            botao.type = 'button';
            botao.className = 'btn btn-outline-primary btn-sm flex-shrink-0';
            botao.dataset.incluirOperador = String(op.ID);
            botao.setAttribute('aria-label', `Adicionar ${op.Nome}`);
            botao.addEventListener('click', () => {
                if (incluirOperador(op)) document.getElementById('integrantes-secao-status').textContent = `${op.Nome} adicionado(a). Preencha a função do integrante.`;
                atualizarBotoesOperadores();
            });
            item.append(nome, botao);
        });
        atualizarBotoesOperadores();
    };
    selecaoSecao?.addEventListener('change', mostrarOperadoresSecao);
    mostrarOperadoresSecao();
    document.getElementById('adicionar-operadores-secao')?.addEventListener('click', () => {
        const secao = document.getElementById('integrantes-secao').value;
        const status = document.getElementById('integrantes-secao-status');
        if (!secao) { status.textContent = 'Selecione uma seção.'; return; }
        let incluidos = 0;
        const operadores = operadoresPorSecao.filter(op => String(op.SessaoID) === secao);
        operadores.forEach(op => { if (incluirOperador(op)) incluidos++; });
        atualizarBotoesOperadores();
        status.textContent = operadores.length === 0 ? 'Esta seção não possui operadores.' :
            incluidos === 0 ? 'Todos os operadores desta seção já estão incluídos.' :
            `${incluidos} operador(es) adicionado(s). Preencha a função de cada integrante.`;
    });
    document.addEventListener('click', e => {
        const add = e.target.closest('[data-adicionar]');
        if (add) adicionar(add.dataset.adicionar, add.dataset.template);
        const remover = e.target.closest('[data-remover]');
        if (remover) { const row = remover.closest('.registro'); const container = row.parentElement; row.remove(); reindexar(container); alterado = true; atualizarBotoesOperadores(); }
    });
    document.getElementById('integrantes')?.addEventListener('change', atualizarBotoesOperadores);
    form.addEventListener('input', () => alterado = true);
    form.addEventListener('submit', e => {
        const invalido = [...form.elements].find(campo => campo.willValidate && !campo.validity.valid);
        if (invalido) {
            e.preventDefault(); revelarCampo(invalido); invalido.focus(); invalido.reportValidity(); return;
        }
        if (e.submitter?.name === 'finalizar' && !confirm('Finalizar o planejamento? Após esta ação, o registro ficará somente para leitura.')) { e.preventDefault(); return; }
        document.querySelectorAll('[data-colecao]').forEach(reindexar);
        alterado = false;
    });
    window.addEventListener('beforeunload', e => { if (alterado) { e.preventDefault(); e.returnValue = ''; } });
    let request = 0;
    document.getElementById('buscar-alvo').addEventListener('click', async e => {
        const output = document.getElementById('resultado-alvos');
        const termo = document.getElementById('busca-alvo').value.trim();
        const current = ++request;
        output.replaceChildren();
        if (termo.length < 2) { output.textContent = 'Digite pelo menos 2 caracteres.'; return; }
        output.textContent = 'Consultando…';
        try {
            const url = new URL(e.currentTarget.dataset.url, window.location.origin); url.searchParams.set('termo', termo);
            const response = await fetch(url, { headers: { Accept: 'application/json' } });
            if (!response.ok || response.redirected) throw new Error('consulta');
            const alvos = await response.json();
            if (current !== request) return;
            output.replaceChildren();
            if (!alvos.length) output.textContent = 'Nenhum alvo encontrado. Você pode cadastrar um novo abaixo.';
            for (const alvo of alvos) {
                const button = document.createElement('button'); button.type = 'button'; button.className = 'list-group-item list-group-item-action';
                button.textContent = `${alvo.nome} · CPF: ${alvo.cpf || 'Não informado'} · ${alvo.quantidadePlanejamentos} planejamento(s) — Vincular`;
                button.addEventListener('click', () => {
                    if ([...document.querySelectorAll('#alvos [data-campo="AlvoID"]')].some(x => x.value === String(alvo.id))) { alert('Este alvo já está na lista.'); return; }
                    const row = adicionar('alvos', 'modelo-alvo');
                    row.querySelector('.campos-novo').remove();
                    row.querySelector('[data-campo="AlvoID"]').value = alvo.id;
                    row.querySelector('.nome-alvo').textContent = alvo.nome;
                    row.dataset.existente = 'true';
                    button.disabled = true; button.textContent = `${alvo.nome} — vinculado`;
                }); output.append(button);
            }
        } catch { if (current === request) output.textContent = 'Não foi possível consultar. Verifique sua sessão e tente novamente.'; }
    });
})();
