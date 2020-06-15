
const Operation = {
    SOMA: '+',
    SUBTRACAO: '-',
    MULTIPLICACAO: '*',
    DIVISAO: '/',
    POTENCIA: 'p',
    RAIZ: 'r',
    FATORIAL: '!'
}

const expressao = SolicitarExpressao()
const resultado = CalcularBloco(expressao)
alert(resultado)

function SolicitarExpressao() {
    let entrada = '10 - 20 + 3'
    // let entrada = prompt('Digite a expressão desejada:')
    if (entrada === null) {
        return null
    }
    return TratarExpressao(entrada)
}

/**
 *
 *
 * @param {String} expressao
 */
function TratarExpressao(expressao) {
    let texto = expressao
    while (texto.includes(' ')) {
        texto = texto.replace(' ', '')
    }
    return texto
}

/**
 * 
 * @param {String} char 
 */
function IsOperator(char) {
    if (char == null)
        return true
    const code = char.charCodeAt(0)
    if (code == 42 || code == 43 || code == 45 || code == 47)
        return true
    else
        return false
}

/**
 * 
 * @param {String} expressao
 */
function IsOneOperationAndType(expressao) {
    let operators = ''
    for (let i = 0; i < expressao.length; i++) {
        if (IsOperator(expressao[i])) {
            operators += expressao[i]
        }
    }
    if (operators.length == 1) {
        return operators
    } else if (operators.length == 2 && expressao[0] == Operation.SUBTRACAO) {
        return operators[1]
    }
    return false
}

/**
 * 
 * @param {Number} a 
 * @param {Number} b 
 * @param {String} operation 
 */
function RealizarCalculo(a, b, operation) {
    switch (operation) {
        case Operation.SOMA:
            return a + b
        case Operation.SUBTRACAO:
            return a - b
        case Operation.MULTIPLICACAO:
            return a * b
        case Operation.DIVISAO:
            return a / b
    }
}

/**
 * 
 * @param {String} opA enum Operation
 * @param {String} opB enum Operation
 * @param {String} bloco
 */
function BuscarPrimeiraOperacao(opA, opB, bloco) {
    if (bloco[0] == Operation.SUBTRACAO) {
        bloco = bloco.substring(1, bloco.length - 1)
    }
    const hasA = bloco.includes(opA)
    const hasB = bloco.includes(opB)
    if (hasA && hasB) {
        const idA = bloco.indexOf(opA)
        const idB = bloco.indexOf(opB)
        return idA < idB ? opA : opB
    }
    return hasA ? opA : opB
}

/**
 * 
 * @param {String} bloco
 * @param {Number} idOperador
 */
function FabricarExpressao(bloco, idOperador) {
    let idInicial = idOperador - 1
    let idFinal = idOperador + 1
    while (idInicial == 1 || !IsOperator(bloco[idInicial - 1])) { --idInicial }
    while (!IsOperator(bloco[idFinal + 1])) { ++idFinal }
    return bloco.substring(idInicial, ++idFinal)
}

/**
 * 
 * @param {String} bloco 
 */
function CalcularBloco(bloco) {
    const operation1 = IsOneOperationAndType(bloco)
    if (!!operation1) {
        const numbers = bloco.split(operation1)
        const a = parseFloat(numbers[0])
        const b = parseFloat(numbers[1])
        return RealizarCalculo(a, b, operation1)
    } else {
        while (bloco.includes(Operation.MULTIPLICACAO) || bloco.includes(Operation.DIVISAO)) {
            const operation2 = BuscarPrimeiraOperacao(Operation.MULTIPLICACAO, Operation.DIVISAO, bloco)
            const expressao = FabricarExpressao(bloco, bloco.indexOf(operation2))
            bloco = bloco.replace(expressao, CalcularBloco(expressao))
        }
        while (bloco.includes(Operation.SOMA) || bloco.includes(Operation.SUBTRACAO)) {
            debugger
            if (IsOneOperationAndType(bloco) == Operation.SUBTRACAO) {

            }
            const operation3 = BuscarPrimeiraOperacao(Operation.SOMA, Operation.SUBTRACAO, bloco)
            const expressao = FabricarExpressao(bloco, bloco.indexOf(operation3))
            bloco = bloco.replace(expressao, CalcularBloco(expressao))
        }
    }
    return bloco
}