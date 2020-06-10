var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const valor = parseFloat(lines.shift())
// const valor = parseFloat(prompt('Valor: '))

let n100 = Math.floor(valor / 100)
let r100 = valor % 100
let n50 = Math.floor(r100 / 50)
let r50 = r100 % 50
let n20 = Math.floor(r50 / 20)
let r20 = r50 % 20
let n10 = Math.floor(r20 / 10)
let r10 = r20 % 10
let n5 = Math.floor(r10 / 5)
let r5 = r10 % 5
let n2 = Math.floor(r5 / 2)
let r2 = r5 % 2
let n1 = r2

console.log(valor.toFixed(0))
let strNotas = '{0} nota(s) de R$ {1},00'
console.log(strNotas.replace('{0}', n100.toFixed(0)).replace('{1}', 100))
console.log(strNotas.replace('{0}', n50.toFixed(0)).replace('{1}', 50))
console.log(strNotas.replace('{0}', n20.toFixed(0)).replace('{1}', 20))
console.log(strNotas.replace('{0}', n10.toFixed(0)).replace('{1}', 10))
console.log(strNotas.replace('{0}', n5.toFixed(0)).replace('{1}', 5))
console.log(strNotas.replace('{0}', n2.toFixed(0)).replace('{1}', 2))
console.log(strNotas.replace('{0}', n1.toFixed(0)).replace('{1}', 1))