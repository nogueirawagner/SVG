const assert = require('node:assert/strict');
const { agruparAreas, tamanhoArea } = require('../SVG.WebApp/wwwroot/js/mapas/mapa-calor.js');
const pontos = [
    { posicao: { lat: -15.78, lng: -47.93 }, peso: 3 },
    { posicao: { lat: -15.78, lng: -47.93 }, peso: 2 },
    { posicao: { lat: -16.78, lng: -48.93 }, peso: 1 }
];
const areas = agruparAreas(pontos);
assert.equal(areas.length, 2);
assert.equal(areas.reduce((s, a) => s + a.quantidade, 0), 6);
assert.ok(areas.some(a => a.quantidade === 5));
for (const area of areas) { assert.ok(area.norte > area.sul); assert.ok(area.leste > area.oeste); }
const ordenar = itens => itens.sort((a,b) => a.sul - b.sul || a.oeste - b.oeste);
assert.deepEqual(ordenar(agruparAreas([...pontos].reverse())), ordenar(areas));
assert.deepEqual(agruparAreas([]), []);
assert.deepEqual(agruparAreas([{posicao:{lat:NaN,lng:0}}, {posicao:{lat:91,lng:0}}]), []);
assert.equal(agruparAreas([pontos[2]])[0].quantidade, 1);
assert.equal(tamanhoArea(22), 200);
assert.ok(tamanhoArea(5) > tamanhoArea(15));
for (const zoom of [5, 10, 15, 20]) assert.equal(agruparAreas(pontos, tamanhoArea(zoom)).reduce((s,a)=>s+a.quantidade,0), 6);
assert.throws(() => agruparAreas(pontos, 0));
console.log('Mapa de calor: contagens, pontos coincidentes, áreas, filtros vazios e escala verificados.');
