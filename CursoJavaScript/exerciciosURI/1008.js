var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const numFuncionario = parseInt(lines.shift())
// const numFuncionario = parseInt(prompt('Número do funcionário:'))
const qtdHorasTrabalhadas = parseInt(lines.shift())
// const qtdHorasTrabalhadas = parseInt(prompt('Número de horas trabalhadas:'))
const valorPorHora = parseFloat(lines.shift())
// const valorPorHora = parseFloat(prompt('Valor por hora:'))

const r1 = `NUMBER = ${numFuncionario}`
const r2 = `SALARY = U$ ${(qtdHorasTrabalhadas*valorPorHora).toFixed(2)}`
// alert(r1)
// alert(r2)
console.log(r1)
console.log(r2)

