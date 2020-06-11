var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

class ItemPedido {
    constructor(codigo, quantidade, valorUnitario) {
        this.codigo = codigo
        this.quantidade = quantidade
        this.valorUnitario = valorUnitario
    }

    get valorTotal() {
        return this.quantidade * this.valorUnitario
    }
}

let itens = []
for (let i = 0; i < 2; i++) {
    let input = lines.shift().split(' ')
    // let input = prompt('Entre com as informações:').split(' ')
    itens.push(new ItemPedido(input[0], input[1], input[2]))
}

let totalPagar = 0;
for (let i = 0; i < 2; i++) {
    totalPagar += itens[i].va
}

const resultado = `VALOR A PAGAR: R$ ${totalPagar.toFixed(2)}`
// alert(resultado)
console.log(resultado);