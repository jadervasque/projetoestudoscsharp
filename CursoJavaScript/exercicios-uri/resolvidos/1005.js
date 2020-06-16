var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const a = parseFloat(lines.shift())
// const a = parseFloat(prompt('Digite A:'))
const b = parseFloat(lines.shift())
// const b = parseFloat(prompt('Digite B:'))
const pa = 3.5
const pb = 7.5
const r = `MEDIA = ${((a * pa + b * pb) / (pa + pb)).toFixed(5)}`
// alert(r)
console.log(r);
