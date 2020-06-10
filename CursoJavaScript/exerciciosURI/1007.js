var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

let a = parseInt(lines.shift())
// let a = parseInt(prompt('Digite A: '))
let b = parseInt(lines.shift())
// let b = parseInt(prompt('Digite B: '))
let c = parseInt(lines.shift())
// let c = parseInt(prompt('Digite C: '))
let d = parseInt(lines.shift())
// let d = parseInt(prompt('Digite D: '))

const dif = a * b - c * d
const r = `DIFERENCA = ${dif}`
// alert(r)
console.log(r)