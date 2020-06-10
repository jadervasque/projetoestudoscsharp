var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const a = parseFloat(lines.shift())
// const a = parseFloat(prompt('Digite A:'))
const b = parseFloat(lines.shift())
// const b = parseFloat(prompt('Digite B:'))
const c = parseFloat(lines.shift())
// const c = parseFloat(prompt('Digite C:'))

const pa = 2
const pb = 3
const pc = 5

const media = (a * pa + b * pb + c * pc) / (pa + pb + pc)
const r = `MEDIA = ${media.toFixed(1)}`
// alert(r)
console.log(r);
