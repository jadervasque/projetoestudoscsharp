function URI() {
    // var input = require('fs').readFileSync('/dev/stdin', 'utf8')
    // var lines = input.split('\n')

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
    // let input = lines.shift().split(' ')
    let input = prompt('Entre com as informações:').split(' ')
    itens.push(new ItemPedido(input[0], input[1], input[2]))
    }

    let totalPagar = 0;
    for (let i = 0; i < 2; i++) {
    totalPagar += itens[i].va
    }

    const resultado = `VALOR A PAGAR: R$ ${totalPagar.toFixed(2)}`
    alert(resultado)
    console.log(resultado);
}

/**
 * 
 * DESAFIO URI 1010
 * 
 */

/**
 * Passo 1:
 * Criar 2 funções:
 *   Uma para ler um texto e retorná-lo como inteiro: int();
 *   Outra para ler um texto e retorná-lo como float: float();
 *   Utilizar a notação arrow no formato reduzido para cada função criada;
 *   Dúvidas, consultar a aula 'funcao2.js'
 */
{
    var int = (t) => parseInt(t)
    var float = (t) => parseFloat(t)
}

/**
 * Passo 2:
 * Criar uma função que leia os dados e retorne um objeto;
 * Esse objeto conterá as informações codigo, quantidade, valorUnitario;
 */
{
    function LerDados() {
        const info = prompt('Entre com as informações:').split(' ')
        const itemPedido = {}
        itemPedido.codigo = Number(int(info[0]))
        itemPedido.quantidade = Number(int(info[1]))
        itemPedido.valorUnitario = Number(float(info[2]))
        return itemPedido
    }
}

/**
 * Passo 3:
 * Ciar uma função que recebe o array dos itens e realize a soma
 *   do produto (multiplicação) da quantidade pelo valor unitário de cada item;
 * 
 * @param {Array} itens
 */
{
    function CalcularValorTotal(listaItens) {
        let soma = 0;
        for (let i = 0; i < listaItens.length; i++) {
            soma += listaItens[i].quantidade * listaItens[i].valorUnitario
        }
        return soma;
    }
}

/**
 * Passo 4:
 * Criar um laço que chame a função do Passo 2 e adicione o resultado num array;
 * Cada item desse array será um item contendo as informações de código,
 *   quantidade e valor unitário;
 */
{
    var itens = []
    for (let i = 0; i < 2; i++) {
        itens.push(LerDados())
    }
}

/**
 * Passo 5:
 * Calcular o valor total a pagar utilizando a função do Passo 3;
 * E então exibir uma mensagem com o resultado, com 2 casas decimais;
 * Testar o programa com os dados do URI 1010
 */
{
    const totalPagar = CalcularValorTotal(itens)
    const resultado = `VALOR A PAGAR: R$ ${totalPagar.toFixed(2)}`
    alert(resultado)
}