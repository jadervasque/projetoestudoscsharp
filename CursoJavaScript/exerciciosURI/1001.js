var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

let A = parseInt(lines.shift())
// let A = parseInt(prompt('Insira o valor de A:'))
let B = parseInt(lines.shift())
// let B = parseInt(prompt('Insira o valor de B:'))

let resutlado = String("X = " + (A+B))
// alert(resutlado)

console.log(resutlado)