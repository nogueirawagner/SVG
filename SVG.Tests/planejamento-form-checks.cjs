const fs = require('node:fs');
const vm = require('node:vm');
const assert = require('node:assert/strict');
const path = require('node:path');
const source = fs.readFileSync(path.join(__dirname, '../SVG.WebApp/wwwroot/js/planejamento.js'), 'utf8').replace(/\r\n/g, '\n');
// Executa as rotinas reais de validação com controles simulados, sem servidor ou banco.
const extract = (start, end) => source.slice(source.indexOf(start), source.indexOf(end, source.indexOf(start)));
let inputs = [];
const form = { querySelectorAll(selector) {
    if (selector === 'input[type="file"]') return inputs.filter(x => x.files);
    if (selector.includes('[data-campo="CPF"]')) return inputs.filter(x => x.campo === 'CPF');
    if (selector.includes('[data-campo="DataNascimento"]')) return inputs.filter(x => x.campo === 'DataNascimento');
    if (selector === 'input[type="url"]') return inputs.filter(x => x.type === 'url');
    if (selector.includes('[required]')) return inputs.filter(x => x.required);
    return inputs;
} };
const context = vm.createContext({ form, previews: new Map(), URL, Date });
vm.runInContext(extract('    const validarArquivos =', "    form.addEventListener('change',") + extract('    const validarCampos =', '    // Mantém os controles') + '\nthis.validate = validarCampos;', context);
const field = props => ({ value: '', willValidate: true, error: '', setCustomValidity(value) { this.error = value; }, get validity() { return { valid: !this.error }; }, hasAttribute(name) { return name === 'data-foto' && this.principal; }, ...props });
const validate = () => context.validate(form);
inputs = [field({ campo: 'CPF', value: '529.982.247-25' })];
assert.equal(validate(), undefined);
inputs.push(field({ campo: 'CPF', value: '52998224725' }));
assert.equal(validate(), inputs[1]);
inputs = [field({ campo: 'CPF', value: '111.111.111-11' })];
assert.equal(validate(), inputs[0]);
inputs[0].value = '';
assert.equal(validate(), undefined);
inputs = [field({ campo: 'DataNascimento', value: '2999-01-01' })];
assert.equal(validate(), inputs[0]);
inputs = [field({ required: true, value: '   ' })];
assert.equal(validate(), inputs[0]);
inputs = [field({ type: 'url', value: 'http://example.com' })];
assert.equal(validate(), inputs[0]);
inputs[0].value = 'https://example.com';
assert.equal(validate(), undefined);
const file = (size, type = 'image/png') => ({ size, type });
inputs = [field({ name: 'Foto_0', principal: true, files: [file(6 * 1024 * 1024)] })];
assert.equal(validate(), inputs[0]);
inputs[0].files = [file(1024)];
assert.equal(validate(), undefined);
inputs = [field({ name: 'AnexosPlanejamento_1', files: Array.from({ length: 21 }, () => file(10)) })];
assert.equal(validate(), inputs[0]);
inputs = [field({ name: 'AnexosPlanejamento_1', files: Array.from({ length: 3 }, () => file(40 * 1024 * 1024, 'video/mp4')) })];
assert.equal(validate(), inputs[0]);
inputs[0].files = [];
assert.equal(validate(), undefined);
// A navegação deve manter aberto o primeiro grupo inválido e só avançar após correção.
const grupos = [0, 1, 2].map(index => ({ corpo: { hidden: index !== 0, index } }));
let invalid = true, focused = false, reported = false;
const navigation = vm.createContext({ grupos, grupo: grupos[2], corpo: grupos[2].corpo,
    validarCampos: corpo => invalid && corpo.index === 1 ? { focus() { focused = true; }, reportValidity() { reported = true; } } : null,
    abrirGrupo: grupo => grupos.forEach(item => item.corpo.hidden = item !== grupo)
});
const body = extract('            const atual = grupos.find', '        });\n    });\n    abrirGrupo(null);');
vm.runInContext('this.navigate = () => {' + body + '};', navigation);
navigation.navigate();
assert.equal(grupos[1].corpo.hidden, false);
assert.ok(focused && reported);
invalid = false;
navigation.navigate();
assert.equal(grupos[2].corpo.hidden, false);
console.log('Validações de campos/anexos e bloqueio de navegação: verificações passaram.');
