/* Componente reutilizável: não conhece entidades, rotas ou filtros de Planejamento. */
(function (root) {
    'use strict';
    let carregamento;
    function carregar(apiKey) {
        if (root.google?.maps?.importLibrary) return Promise.resolve();
        if (carregamento) return carregamento;
        carregamento = new Promise((resolve, reject) => {
            if (!apiKey) { reject(new Error('O mapa ainda não foi configurado.')); return; }
            const script = document.createElement('script');
            const timeout = setTimeout(() => reject(new Error('O Google Maps demorou para responder. Recarregue a página.')), 20000);
            root.svgGoogleMapsPronto = () => { clearTimeout(timeout); resolve(); };
            root.gm_authFailure = () => { clearTimeout(timeout); reject(new Error('Google Maps indisponível. Verifique a chave e a configuração do projeto.')); root.dispatchEvent(new Event('svg:mapa-erro')); };
            script.async = true;
            script.src = 'https://maps.googleapis.com/maps/api/js?' + new URLSearchParams({ key: apiKey, callback: 'svgGoogleMapsPronto', loading: 'async', v: 'quarterly', language: 'pt-BR', region: 'BR' });
            script.onerror = () => { clearTimeout(timeout); reject(new Error('Não foi possível carregar o Google Maps. Verifique a conexão.')); };
            document.head.append(script);
        });
        return carregamento;
    }
    function distanciaMetros(a, b) {
        const rad = n => n * Math.PI / 180;
        const h = Math.sin(rad(b.lat - a.lat) / 2) ** 2 + Math.cos(rad(a.lat)) * Math.cos(rad(b.lat)) * Math.sin(rad(b.lng - a.lng) / 2) ** 2;
        return 6378137 * 2 * Math.asin(Math.sqrt(Math.min(1, Math.max(0, h))));
    }
    async function criar(elemento, { apiKey, mapId, aoClicar }) {
        await carregar(apiKey);
        const { Map, Circle, InfoWindow } = await google.maps.importLibrary('maps');
        const { AdvancedMarkerElement, PinElement } = await google.maps.importLibrary('marker');
        const mapa = new Map(elemento, { center: { lat: -15.78, lng: -47.93 }, zoom: 5, mapId: mapId || 'DEMO_MAP_ID', streetViewControl: false, mapTypeControl: false });
        const janela = new InfoWindow();
        const circulo = new Circle({ strokeColor: '#1565c0', strokeWeight: 2, fillColor: '#1565c0', fillOpacity: 0.12, clickable: false });
        let marcadores = [];
        const clique = mapa.addListener('click', e => { if (e.latLng) aoClicar?.(e.latLng.toJSON()); });
        return {
            definirPontos(pontos, ajustar = false) {
                janela.close();
                marcadores.forEach(m => m.map = null);
                marcadores = pontos.map(ponto => {
                    const pin = new PinElement({ background: '#d32f2f', borderColor: '#8e0000', glyphColor: '#ffffff' });
                    const marker = new AdvancedMarkerElement({ map: mapa, position: ponto.posicao, title: ponto.titulo, content: pin.element });
                    marker.addListener('click', () => { janela.setContent(ponto.conteudo()); janela.open({ map: mapa, anchor: marker }); });
                    return marker;
                });
                if (ajustar && pontos.length) {
                    const bounds = new google.maps.LatLngBounds();
                    pontos.forEach(p => bounds.extend(p.posicao));
                    if (pontos.length === 1) { mapa.setCenter(pontos[0].posicao); mapa.setZoom(16); }
                    else { mapa.fitBounds(bounds, 50); google.maps.event.addListenerOnce(mapa, 'idle', () => { if (mapa.getZoom() > 17) mapa.setZoom(17); }); }
                }
            },
            definirRaio(centro, metros) {
                if (!centro || !metros) { circulo.setMap(null); return; }
                circulo.setOptions({ map: mapa, center: centro, radius: metros });
            },
            destruir() { clique.remove(); marcadores.forEach(m => m.map = null); janela.close(); circulo.setMap(null); }
        };
    }
    root.SvgMapas = { criar, distanciaMetros };
    if (typeof module !== 'undefined') module.exports = { distanciaMetros };
})(typeof window !== 'undefined' ? window : globalThis);
