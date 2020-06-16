var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

let nsegundos = parseFloat(lines.shift())
// let nsegundos = parseFloat(prompt("Segundos: "))

let nminutos = Math.floor(nsegundos / 60)
nsegundos = nsegundos - nminutos * 60;
let nhoras = Math.floor(nminutos / 60)
nminutos = nminutos - nhoras * 60

const time = `${nhoras}:${nminutos}:${nsegundos}`
// alert(time)
console.log(time)