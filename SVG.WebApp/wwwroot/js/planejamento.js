(() => {
    'use strict';
    document.querySelectorAll('.preservar-linhas').forEach(p => p.style.whiteSpace = 'pre-wrap');
    document.querySelectorAll('.alvo-foto').forEach(img => {
        const ausente = () => { img.hidden = true; const aviso = img.nextElementSibling; if (aviso?.classList.contains('foto-ausente')) aviso.hidden = false; };
        img.addEventListener('error', ausente);
        if (img.complete && img.naturalWidth === 0) ausente();
    });
    const modalMidia = document.getElementById('planejamento-midia-modal');
    if (modalMidia && window.bootstrap?.Modal) {
        const conteudo = document.getElementById('planejamento-midia-conteudo');
        let origem;
        document.querySelectorAll('[data-visualizar-midia]').forEach(link => link.addEventListener('click', e => {
            e.preventDefault();
            origem = link;
            const video = link.dataset.visualizarMidia === 'video';
            const midia = document.createElement(video ? 'video' : 'img');
            midia.src = link.href;
            midia.style.cssText = 'width:100%;height:100%;max-height:calc(100dvh - 100px);object-fit:contain';
            if (video) { midia.controls = true; midia.preload = 'metadata'; midia.setAttribute('playsinline', ''); }
            else midia.alt = 'Imagem do planejamento ampliada';
            midia.addEventListener('error', () => {
                const aviso = document.createElement('p');
                aviso.className = 'text-white';
                aviso.textContent = 'Não foi possível visualizar este arquivo. Utilize o link Baixar.';
                conteudo.replaceChildren(aviso);
            });
            conteudo.replaceChildren(midia);
            document.getElementById('planejamento-midia-titulo').textContent = video ? 'Vídeo do planejamento' : 'Imagem do planejamento';
            document.getElementById('planejamento-midia-download').href = link.dataset.download;
            bootstrap.Modal.getOrCreateInstance(modalMidia).show();
        }));
        modalMidia.addEventListener('hide.bs.modal', () => conteudo.querySelector('video')?.pause());
        modalMidia.addEventListener('hidden.bs.modal', () => { conteudo.replaceChildren(); origem?.focus(); });
    }
    const form = document.getElementById('planejamento-form');
    if (!form) return;
    let alterado = false;
    const previews = new Map();
    const limparPreview = input => {
        const anterior = previews.get(input);
        if (!anterior) return;
        anterior.urls.forEach(url => URL.revokeObjectURL(url));
        anterior.container.remove();
        previews.delete(input);
    };
    const validarArquivos = () => {
        const inputs = [...form.querySelectorAll('input[type="file"]')];
        const arquivos = inputs.flatMap(input => [...input.files].map(file => ({ input, file })));
        const total = arquivos.reduce((soma, item) => soma + item.file.size, 0);
        const quantidadePlano = arquivos.filter(item => item.input.name.startsWith('AnexosPlanejamento_')).length;
        const quantidadeAlvos = arquivos.length - quantidadePlano;
        inputs.forEach(input => {
            const principal = input.hasAttribute('data-foto');
            const tipos = principal ? ['image/jpeg', 'image/png'] : ['image/jpeg', 'image/png', 'video/mp4', 'video/webm'];
            const limite = (principal ? 5 : 50) * 1024 * 1024;
            let erro = '';
            for (const file of input.files) {
                if (!tipos.includes(file.type) || file.size === 0) { erro = 'Selecione um arquivo válido: ' + (principal ? 'JPEG ou PNG.' : 'JPEG, PNG, MP4 ou WebM.'); break; }
                if (file.size > limite) { erro = `Cada arquivo pode ter até ${principal ? 5 : 50} MB.`; break; }
            }
            if (input.files.length && !erro) {
                if (total > 100 * 1024 * 1024) erro = 'Os arquivos selecionados ultrapassam 100 MB no total.';
                else if (input.name.startsWith('AnexosPlanejamento_') && quantidadePlano > 20) erro = 'Selecione até 20 anexos de planejamento no total.';
                else if (!input.name.startsWith('AnexosPlanejamento_') && quantidadeAlvos > 50) erro = 'Selecione até 50 anexos de alvos no total.';
            }
            input.setCustomValidity(erro);
            const preview = previews.get(input);
            if (preview) preview.aviso.textContent = erro;
        });
    };
    form.addEventListener('change', e => {
        const input = e.target;
        if (!input.matches('input[type="file"]')) return;
        limparPreview(input);
        const container = document.createElement('div');
        container.className = 'mt-2 mb-3';
        const aviso = document.createElement('p');
        aviso.className = 'text-danger small mb-2';
        aviso.setAttribute('role', 'alert');
        const galeria = document.createElement('div');
        galeria.className = 'd-flex flex-wrap gap-3';
        container.append(aviso, galeria);
        (input.closest('label') || input).insertAdjacentElement('afterend', container);
        const urls = [];
        previews.set(input, { container, aviso, urls });
        validarArquivos();
        [...input.files].forEach(file => {
            const figure = document.createElement('figure');
            figure.className = 'm-0';
            figure.style.width = '160px';
            const caption = document.createElement('figcaption');
            caption.className = 'small text-break';
            caption.textContent = file.name;
            const imagem = ['image/jpeg', 'image/png'].includes(file.type);
            const video = ['video/mp4', 'video/webm'].includes(file.type);
            if ((imagem || video) && file.size <= (input.hasAttribute('data-foto') ? 5 : 50) * 1024 * 1024) {
                const midia = document.createElement(imagem ? 'img' : 'video');
                const url = URL.createObjectURL(file);
                urls.push(url);
                midia.src = url;
                midia.style.cssText = 'width:160px;height:120px;object-fit:contain;background:#f3f4f6;border-radius:6px';
                if (imagem) midia.alt = `Prévia de ${file.name}`;
                else { midia.controls = true; midia.preload = 'metadata'; midia.muted = true; }
                midia.addEventListener('error', () => { midia.hidden = true; caption.textContent = `${file.name} — não foi possível visualizar este arquivo.`; });
                figure.append(midia);
            }
            figure.append(caption);
            galeria.append(figure);
        });
        alterado = true;
    });
    window.addEventListener('pagehide', e => {
        if (e.persisted) return;
        previews.forEach(preview => preview.urls.forEach(url => URL.revokeObjectURL(url)));
    });
    const validarCampos = escopo => {
        validarArquivos();
        form.querySelectorAll('input[required]:not([type]), input[type="text"][required], textarea[required]').forEach(input => input.setCustomValidity(input.value.trim() ? '' : 'Preencha este campo.'));
        const cpfs = new Set();
        form.querySelectorAll('[data-campo="CPF"]').forEach(input => {
            const cpf = input.value.replace(/[.\-]/g, '').trim();
            let valido = /^\d{11}$/.test(cpf) && !/^(\d)\1{10}$/.test(cpf);
            for (let tamanho = 9; valido && tamanho <= 10; tamanho++) {
                let soma = 0;
                for (let i = 0; i < tamanho; i++) soma += Number(cpf[i]) * (tamanho + 1 - i);
                const digito = (soma * 10) % 11;
                valido = Number(cpf[tamanho]) === (digito === 10 ? 0 : digito);
            }
            input.setCustomValidity(!cpf ? '' : !valido ? 'CPF inválido. Corrija ou deixe em branco quando desconhecido.' : cpfs.has(cpf) ? 'Este CPF já está no planejamento.' : '');
            if (cpf) cpfs.add(cpf);
        });
        const hoje = new Date();
        const dataHoje = `${hoje.getFullYear()}-${String(hoje.getMonth() + 1).padStart(2, '0')}-${String(hoje.getDate()).padStart(2, '0')}`;
        form.querySelectorAll('[data-campo="DataNascimento"]').forEach(input => input.setCustomValidity(input.value > dataHoje ? 'Data de nascimento não pode ser futura.' : ''));
        form.querySelectorAll('input[type="url"]').forEach(input => {
            if (input.id === 'Link_Endereco_Alvo') return;
            let erro = '';
            if (input.value.trim()) {
                try { const url = new URL(input.value); if (url.protocol !== 'https:' || url.username || url.password) erro = 'Informe um link HTTPS válido.'; }
                catch { erro = 'Informe um link HTTPS válido.'; }
            }
            input.setCustomValidity(erro);
        });
        return [...escopo.querySelectorAll('input, select, textarea')].find(campo => campo.willValidate && !campo.validity.valid);
    };
    // Mantém os controles no DOM: recolher nunca descarta valores ou arquivos selecionados.
    const grupos = [];
    const abrirGrupo = grupo => grupos.forEach(item => {
        const aberto = item === grupo;
        item.corpo.hidden = !aberto;
        if (aberto) { item.visitado = true; item.validado = false; }
        const concluido = !aberto && item.validado;
        item.section.classList.toggle('bg-success-subtle', Boolean(concluido));
        item.section.classList.toggle('border-success-subtle', Boolean(concluido));
        item.botao.title = concluido ? 'Agrupamento validado' : '';
        item.botao.setAttribute('aria-expanded', String(aberto));
        item.icone.textContent = aberto ? '−' : concluido ? '✓' : '+';
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
        const grupo = { corpo, botao, icone, section, visitado: false, validado: false };
        grupos.push(grupo);
        botao.addEventListener('click', () => {
            // Antes de avançar, valida também os grupos anteriores ainda não abertos.
            const atual = grupos.find(item => !item.corpo.hidden);
            const verificar = new Set([...(atual ? [atual] : []), ...grupos.slice(0, grupos.indexOf(grupo))]);
            for (const item of verificar) {
                const invalido = validarCampos(item.corpo);
                item.validado = !invalido && item.visitado;
                if (invalido) { abrirGrupo(item); invalido.focus(); invalido.reportValidity(); return; }
            }
            abrirGrupo(corpo.hidden ? grupo : null);
        });
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
                mapsLink.setCustomValidity('');
                latitude.value = result.latitude;
                longitude.value = result.longitude;
                status.textContent = `Latitude: ${result.latitude} · Longitude: ${result.longitude}`;
                status.className = 'form-text text-success';
            } catch (error) {
                if (current !== version || error.name === 'AbortError') return;
                status.textContent = error instanceof SyntaxError ? 'Não foi possível consultar o link. Verifique sua sessão e tente novamente.' : error.message;
                status.className = 'form-text text-danger';
                mapsLink.setCustomValidity(status.textContent);
            }
        };
        mapsLink.addEventListener('input', () => {
            clearTimeout(timer); pending?.abort();
            const current = ++version;
            const resumo = document.getElementById('link-alvo-resumo');
            if (resumo) resumo.value = mapsLink.value.trim();
            latitude.value = ''; longitude.value = '';
            status.className = 'form-text';
            mapsLink.setCustomValidity('');
            if (!mapsLink.value.trim()) { status.textContent = 'Cole o link de compartilhar do ponto no Google Maps.'; return; }
            mapsLink.setCustomValidity('Aguarde a consulta das coordenadas antes de continuar.');
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
        if (remover) { const row = remover.closest('.registro'); const container = row.parentElement; row.querySelectorAll('input[type="file"]').forEach(limparPreview); row.remove(); reindexar(container); alterado = true; atualizarBotoesOperadores(); }
    });
    document.getElementById('integrantes')?.addEventListener('change', atualizarBotoesOperadores);
    form.addEventListener('input', () => alterado = true);
    form.addEventListener('submit', e => {
        const data = document.getElementById('DataPrevista');
        const endereco = document.getElementById('Endereco');
        const buscaAlvo = document.getElementById('busca-alvo');
        [data, endereco, buscaAlvo].forEach(input => input?.setCustomValidity(''));
        if (e.submitter?.name === 'finalizar') {
            if (data && !data.value) data.setCustomValidity('Informe a data do apoio para finalizar.');
            if (endereco && !endereco.value.trim()) endereco.setCustomValidity('Informe o endereço para finalizar.');
            if (!document.querySelector('#alvos > .registro')) buscaAlvo.setCustomValidity('Adicione pelo menos um alvo para finalizar.');
        }
        const invalido = validarCampos(form);
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
