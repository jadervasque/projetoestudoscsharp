function URI() {
    // var input = require('fs').readFileSync('/dev/stdin', 'utf8')
    // var lines = input.split('\n')

    // const a = parseFloat(lines.shift())
    const a = parseFloat(prompt('Digite A:'))
    // const b = parseFloat(lines.shift())
    const b = parseFloat(prompt('Digite B:'))
    // const c = parseFloat(lines.shift())
    const c = parseFloat(prompt('Digite C:'))

    const pa = 2
    const pb = 3
    const pc = 5

    const media = (a * pa + b * pb + c * pc) / (pa + pb + pc)
    const r = `MEDIA = ${media.toFixed(1)}`
    alert(r)
    console.log(r);
}

/**
 * 
 * DESAFIO URI 1006
 * 
 */

/**
 * Passo 1:
 * Criar um objeto 'notas' contendo as três notas e o respectivo peso de cada nota;
 * Dúvidas, consultar a aula 'objetos.js'
 * Dica: somente as propriedades com as variáveis conhecidas serão criadas neste passo;
 */
{
    var notas = {
        notaA: {
            peso: 2
        },
        notaB: {
            peso: 3
        },
        notaC: {
            peso: 5
        }
    }
}

/**
 * Passo 2:
 * Inserir o valor de cada uma das notas nas respectivas
 *   propriedades da variável criada no passo anterior;
 */
{
    notas.notaA.valor = parseInt(prompt('Nota A:'))
    notas.notaB.valor = parseInt(prompt('Nota B:'))
    notas.notaC.valor = parseInt(prompt('Nota C:'))
}

/**
 * Passo 3:
 * Criar uma função que receba como parâmetro um objeto do tipo da variável criada no Passo 1;
 * Desestruturar esse objeto nas constantes a, pa, b, pb, c, pc;
 * As variáveis pa, pb e pc representam os pesos das respectivas notas;
 * Calcular a média e retorná-la como resultado;
 */
{
    /**
     * 
     * @param {typeof notas} obj 
     */
    function CaclularMediaPonderada(obj) {
        const { notaA: { valor: a, peso: pa }, notaB: { valor: b, peso: pb }, notaC: { valor: c, peso: pc } } = obj
        let media = a * pa + b * pb + c * pc
        media /= pa + pb + pc
        return media
    }
}

/**
 * Passo 4:
 * Calcular e imprimir o resultado;
 */
{
    alert(`MEDIA = ${CaclularMediaPonderada(notas)}`)
}