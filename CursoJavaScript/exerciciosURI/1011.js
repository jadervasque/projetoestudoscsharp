var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const raio = parseInt(lines.shift())
// const raio = parseInt(prompt('Raio:'))
const pi = 3.14159
const volume = 4 / 3 * pi * Math.pow(raio, 3)
const resultado = `VOLUME = ${volume.toFixed(3)}`
// alert(resultado)
console.log(resultado)