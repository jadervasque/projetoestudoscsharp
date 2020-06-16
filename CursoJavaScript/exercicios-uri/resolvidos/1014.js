var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const x = parseInt(lines.shift())
// const x = parseInt(prompt('Distância: '))
const y = parseFloat(lines.shift())
// const y = parseFloat(prompt('Combustível Gasto: '))
const media = x / y
const resultado = `${media.toFixed(3)} km/l`
// alert(resultado)
console.log(resultado);
