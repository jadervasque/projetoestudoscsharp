var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const func = {}
func.nome = lines.shift()
// func.nome = prompt('Nome do funcionário:')
func.salario = parseFloat(lines.shift())
// func.salario = parseFloat(prompt('Salário fixo:'))
func.tVendas = parseFloat(lines.shift())
// func.tVendas = parseFloat(prompt('Total de vendas:'))
func.tComissao = 0.15
func.vComissao = func.salario + func.tVendas * func.tComissao
const r = `TOTAL = R$ ${func.vComissao.toFixed(2)}`
// alert(r)
console.log(r);
