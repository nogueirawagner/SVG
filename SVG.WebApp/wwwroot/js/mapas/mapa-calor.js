(function (root) {
    'use strict';
    const raioTerra = 6378137;
    // Grade geográfica fixa, independente da ordem dos dados e do centro da tela.
    function agruparAreas(pontos, metros = 200) {
        if (!Number.isFinite(metros) || metros <= 0) throw new Error('Tamanho de área inválido.');
        const passoLat = metros / raioTerra * 180 / Math.PI;
        const grupos = new Map();
        pontos.forEach(p => {
            const { lat, lng } = p.posicao;
            if (!Number.isFinite(lat) || !Number.isFinite(lng) || Math.abs(lat) > 90 || Math.abs(lng) > 180) return;
            const peso = p.peso ?? 1;
            if (!Number.isFinite(peso) || peso <= 0) return;
            const linha = Math.floor((lat + 90) / passoLat);
            const sul = -90 + linha * passoLat, norte = Math.min(90, sul + passoLat);
            const meioLat = (sul + norte) / 2;
            const passoLng = Math.min(360, passoLat / Math.max(0.000001, Math.cos(meioLat * Math.PI / 180)));
            const longitude = lng === 180 ? -180 : lng;
            const coluna = Math.floor((longitude + 180) / passoLng);
            const oeste = -180 + coluna * passoLng, leste = Math.min(180, oeste + passoLng);
            const chave = `${linha}:${coluna}`;
            if (!grupos.has(chave)) grupos.set(chave, { sul, norte, oeste, leste, quantidade: 0 });
            grupos.get(chave).quantidade += peso;
        });
        return [...grupos.values()];
    }
    function tamanhoArea(zoom) {
        // Pelo menos 72 pixels por área, arredondando para múltiplos de 200 m.
        const alvo = 156543.03392 / 2 ** zoom * 72;
        return 200 * 2 ** Math.max(0, Math.ceil(Math.log2(alvo / 200)));
    }
    function criar(google, mapa, aoAtualizar) {
        class CamadaCalor extends google.maps.OverlayView {
            constructor() { super(); this.pontos = []; this.ativo = false; }
            onAdd() {
                this.container = document.createElement('div');
                this.container.style.cssText = 'position:absolute;pointer-events:none';
                this.getPanes().overlayLayer.append(this.container);
            }
            draw() {
                if (!this.container) return;
                this.container.replaceChildren();
                const metros = tamanhoArea(mapa.getZoom() ?? 5);
                const areas = agruparAreas(this.pontos, metros);
                const maximo = Math.max(1, ...areas.map(a => a.quantidade));
                const projecao = this.getProjection();
                areas.forEach(area => {
                    const nw = projecao.fromLatLngToDivPixel(new google.maps.LatLng(area.norte, area.oeste));
                    const se = projecao.fromLatLngToDivPixel(new google.maps.LatLng(area.sul, area.leste));
                    if (!nw || !se) return;
                    const largura = Math.max(1, se.x - nw.x), altura = Math.max(1, se.y - nw.y);
                    const intensidade = area.quantidade / maximo;
                    const matiz = Math.round(55 * (1 - intensidade));
                    const bloco = document.createElement('div');
                    bloco.style.cssText = `position:absolute;left:${nw.x}px;top:${nw.y}px;width:${largura}px;height:${altura}px;display:flex;align-items:center;justify-content:center;border:1px solid hsla(${matiz},100%,40%,.35);background:radial-gradient(ellipse,hsla(${matiz},100%,48%,.8) 0%,hsla(${matiz},100%,50%,.45) 55%,hsla(${matiz},100%,55%,.08) 100%)`;
                    const numero = document.createElement('span');
                    numero.textContent = String(area.quantidade);
                    numero.style.cssText = 'background:rgba(255,255,255,.95);color:#202020;border:1px solid #803000;border-radius:20px;padding:3px 8px;font:bold 14px system-ui;box-shadow:0 1px 4px #5558';
                    numero.setAttribute('aria-label', `${area.quantidade} planejamento(s) nesta área`);
                    bloco.append(numero); this.container.append(bloco);
                });
                aoAtualizar?.({ metros, maximo, areas: areas.length });
            }
            onRemove() { this.container?.remove(); this.container = null; }
            atualizar(pontos, ativo) {
                this.pontos = pontos;
                if (this.ativo !== ativo) { this.ativo = ativo; this.setMap(ativo ? mapa : null); }
                if (ativo) this.draw();
            }
        }
        return new CamadaCalor();
    }
    root.SvgMapaCalor = { criar, agruparAreas, tamanhoArea };
    if (typeof module !== 'undefined') module.exports = { agruparAreas, tamanhoArea };
})(typeof window !== 'undefined' ? window : globalThis);
