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
    document.addEventListener('click', e => {
        const add = e.target.closest('[data-adicionar]');
        if (add) adicionar(add.dataset.adicionar, add.dataset.template);
        const remover = e.target.closest('[data-remover]');
        if (remover) { const row = remover.closest('.registro'); const container = row.parentElement; row.remove(); reindexar(container); alterado = true; }
    });
    form.addEventListener('input', () => alterado = true);
    form.addEventListener('submit', e => {
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
