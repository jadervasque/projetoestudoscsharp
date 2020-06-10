var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const a = parseInt(lines.shift())
// const a = parseInt(prompt('Digite A:'))
const b = parseInt(lines.shift())
// const b = parseInt(prompt('Digite b:'))
const r = `PROD = ${a*b}`
// alert(r)
console.log(r);