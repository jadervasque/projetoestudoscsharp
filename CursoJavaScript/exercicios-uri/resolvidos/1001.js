// var input = require('fs').readFileSync('/dev/stdin', 'utf8')
// var lines = input.split('\n')

// let A = parseInt(lines.shift())
// let A = parseInt(prompt('Insira o valor de A:'))
// let B = parseInt(lines.shift())
// let B = parseInt(prompt('Insira o valor de B:'))

// let resutlado = String("X = " + (A+B))
// alert(resutlado)

// console.log(resutlado)

//--------------------------------------------

/**
 * 
 * @param {typeof valores} obj 
 */
function somar(obj) {
    return obj.a + obj.b
}

let valores = {}
valores.a = parseInt(prompt('A:'))
valores.b = parseInt(prompt('B:'))
const resultado = somar(valores)
alert(`X = ${resultado}`)