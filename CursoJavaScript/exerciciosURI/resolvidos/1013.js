var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const info = lines.shift().split(' ')
// const info = prompt().split(' ')
let vet = []
for (let i = 0; i < info.length; i++) {
    vet.push(parseInt(info[i]))
}
let maior = 0
for (let i = 0; i < vet.length; i++) {
    maior = (maior + vet[i] + Math.abs(maior - vet[i])) / 2
}
const resultado = `${maior} eh o maior`
// alert(resultado)
console.log(resultado)