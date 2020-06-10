var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const n = 3.14159

// const raio = parseFloat(prompt('Digite o valor do raio:'))
const raio = parseFloat(lines.shift())

const area = n * raio * raio
let resultado = String('A=' + area.toFixed(4))

// alert(resultado)

console.log(resultado)