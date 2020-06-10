var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let a = parseInt(lines.shift())
// let a = parseInt(prompt('Digite A:'))
let b = parseInt(lines.shift())
// let b = parseInt(prompt('Digite B:'))
let resultado = `SOMA = ${a + b}`
// alert(resultado)
console.log(resultado)
