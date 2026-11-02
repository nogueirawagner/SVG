(() => {
    const limite = 2800;
    function aplicarCor(elemento, restante) {
        if (!elemento) return;
        if (restante === null || !Number.isFinite(restante) || restante > limite) {
            elemento.style.removeProperty('--revisao-fundo');
            elemento.style.removeProperty('--revisao-texto');
            elemento.classList.remove('revisao-gradual');
            return;
        }
        const proximidade = Math.min(1, Math.max(0, 1 - restante / limite));
        // Laranja claro até vermelho: mesma escala para grade, etiquetas e alertas.
        const inicio = [255, 237, 213];
        const fim = [185, 28, 28];
        const rgb = inicio.map((cor, i) => Math.round(cor + (fim[i] - cor) * proximidade));
        const linear = rgb.map(cor => {
            const c = cor / 255;
            return c <= 0.04045 ? c / 12.92 : Math.pow((c + 0.055) / 1.055, 2.4);
        });
        const luminancia = 0.2126 * linear[0] + 0.7152 * linear[1] + 0.0722 * linear[2];
        elemento.style.setProperty('--revisao-fundo', `rgb(${rgb.join(',')})`);
        elemento.style.setProperty('--revisao-texto', luminancia > 0.179 ? '#000' : '#fff');
        elemento.classList.add('revisao-gradual');
    }
    window.viaturaRevisao = { aplicarCor, limite };
    document.querySelectorAll('[data-km-revisao]').forEach(elemento => {
        const valor = elemento.dataset.kmRevisao;
        aplicarCor(elemento, valor === '' ? null : Number(valor));
    });
})();
