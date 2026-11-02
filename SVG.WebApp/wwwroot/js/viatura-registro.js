(() => {
    const dataHora = document.getElementById('DataHora');
    const combustivel = document.getElementById('NivelCombustivel');
    const percentual = document.getElementById('percentualCombustivel');
    // Avança o limite usando o horário do servidor, independentemente do fuso do navegador.
    const inicio = performance.now();
    const referencia = Date.parse(dataHora.max + 'Z');
    function atualizarLimite() {
        dataHora.max = new Date(referencia + performance.now() - inicio).toISOString().slice(0, 19);
    }
    function atualizarCombustivel() {
        percentual.value = combustivel.value + '%';
        combustivel.setAttribute('aria-valuetext', combustivel.value + '%');
    }
    dataHora.addEventListener('focus', atualizarLimite);
    setInterval(atualizarLimite, 1000);
    combustivel.addEventListener('input', atualizarCombustivel);
    atualizarCombustivel();
})();
