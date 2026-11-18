const assert = require('node:assert/strict');
const { distanciaMetros } = require('../SVG.WebApp/wwwroot/js/mapas/google-maps.js');
const { filtrar } = require('../SVG.WebApp/wwwroot/js/planejamento-mapa.js');
const centro = { lat: 0, lng: 0 };
const ponto = metros => ({ lat: 0, lng: metros / 6378137 * 180 / Math.PI });
assert.equal(distanciaMetros(centro, centro), 0);
assert.ok(Math.abs(distanciaMetros(centro, ponto(400)) - 400) < 0.00001);
const dados = [
 { ID: 1, Ano: 2026, Mes: 11, SecaoID: 2, Latitude: 0, Longitude: ponto(99).lng },
 { ID: 2, Ano: 2026, Mes: 10, SecaoID: 3, Latitude: 0, Longitude: ponto(399).lng },
 { ID: 3, Ano: 2025, Mes: 11, SecaoID: 2, Latitude: 0, Longitude: ponto(499).lng },
 { ID: 4, Ano: null, Mes: null, SecaoID: 3, Latitude: 0, Longitude: ponto(501).lng }
];
const ids = f => filtrar(dados, f, distanciaMetros).map(p => p.ID);
assert.deepEqual(ids({}), [1,2,3,4]);
assert.deepEqual(ids({ ano: '2026', mes: '11', secao: '2' }), [1]);
assert.deepEqual(ids({ raio: 100, centro }), [1]);
assert.deepEqual(ids({ raio: 400, centro }), [1,2]);
assert.deepEqual(ids({ raio: 500, centro }), [1,2,3]);
assert.deepEqual(ids({ raio: 500 }), [1,2,3,4]);
assert.deepEqual(ids({ ano: '2025', raio: 400, centro }), []);
assert.deepEqual(ids({ raio: 0, centro }), [1,2,3,4]);
assert.deepEqual(ids({ raio: 100, centro: ponto(499) }), [2,3,4]);
assert.equal(dados.length, 4);
console.log('Mapa: filtros combinados, centro, raios e distância verificados sem rede.');
