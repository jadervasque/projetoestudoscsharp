var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let vet = lines.shift().split(' ');
// let vet = prompt().split(' ');
const a = parseFloat(vet[0]);
const b = parseFloat(vet[1]);
const c = parseFloat(vet[2]);

let areatri = a * c / 2;
let saidatri = `TRIANGULO: ${areatri.toFixed(3)}`;

let areacir = 3.14159 * c * c;
let saidacir = `CIRCULO: ${areacir.toFixed(3)}`;

let areatra = (a + b) / 2 * c;
let saidatra = `TRAPEZIO: ${areatra.toFixed(3)}`;

let areaqua = b * b;
let saidaqua = `QUADRADO: ${areaqua.toFixed(3)}`;

let arearet = a * b;
let saidaret = `RETANGULO: ${arearet.toFixed(3)}`;

console.log(saidatri);
console.log(saidacir);
console.log(saidatra);
console.log(saidaqua);
console.log(saidaret);