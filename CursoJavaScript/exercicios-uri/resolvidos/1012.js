function URI() {
    var input = require('fs').readFileSync('/dev/stdin', 'utf8');
    var lines = input.split('\n');

    let vet = lines.shift().split(' ');
    // let vet = prompt().split(' ');
    const a = parseFloat(vet[0]);
    const b = parseFloat(vet[1]);
    const c = parseFloat(vet[2]);

    let areatri = a * c / 2;
    let saidatri = `TRIANGULO: ${areatri.toFixed(3)}`;

    let areacir = 3.14159 * c * c;
    let saidacir = `CIRCULO: ${areacir.toFixed(3)}`;

    let areatra = (a + b) / 2 * c;
    let saidatra = `TRAPEZIO: ${areatra.toFixed(3)}`;

    let areaqua = b * b;
    let saidaqua = `QUADRADO: ${areaqua.toFixed(3)}`;

    let arearet = a * b;
    let saidaret = `RETANGULO: ${arearet.toFixed(3)}`;

    console.log(saidatri);
    console.log(saidacir);
    console.log(saidatra);
    console.log(saidaqua);
    console.log(saidaret);
}

/**
 * 
 * DESAFIO URI 1012
 * 
 */

/**
 * Passo 1:
 * Ler uma entrada do usuário e armazenar num vetor;
 * Adicionar os valores desse vetor nas propriedades de um objeto constante com nome 'valores';
 * Dica: utilizar o parseFloat quando for adicionar os valores nas propriedades;
 */
{
    let vet = prompt().split(' ');
    const valores = {
        a: parseFloat(vet[0]),
        b: parseFloat(vet[1]),
        c: parseFloat(vet[2])
    }
}

/**
 * Passo 2:
 * Criar uma constante na qual os nomes das propriedades e os seus respectivos valores
 *   possuem os nomes das geometrias que serão calculadas as área;
 * Dica: esta constante terá 5 propriedades, equivalentes às 5 geometrias da saída do programa;
 * Este passo cria o que chamamos de ENUM;
 */
{
    const Geometria = {
        TRIANGULO: 'TRIANGULO',
        CIRCULO: 'CIRCULO',
        TRAPEZIO: 'TRAPEZIO',
        QUADRADO: 'QUADRADO',
        RETANGULO: 'RETANGULO'
    }
}

/**
 * Passo 3:
 * Nome:  'CalcularArea'
 * Saída: valor da área no tipo float
 * Criar uma função que receba como parâmetros:
 *   (a) uma variável do tipo da constante criada no Passo 1: valores;
 *   (b) uma variável do tipo String;
 * Desestruturar o objeto (a) 'valores' nas variáveis a, b, c;
 * Criar um switch que recebe como valor o parâmetro (b) String informando o cálculo que será
 *   executado. Por exemplo, se o parâmetro (b) vier com o valor 'TRIANGULO', o switch levará
 *   para o bloco que faz o cálculo do triângulo e finaliza retornando o resultado;
 */
{
    /**
     * 
     * @param {typeof valores} valores 
     * @param {String} tipoGeometria 
     */
    function CalcularArea(valores, tipoGeometria) {
        let { a, b, c } = valores
        switch (tipoGeometria) {
            case Geometria.TRIANGULO:
                return a * c / 2
            case Geometria.CIRCULO:
                return 3.14159 * c * c
            case Geometria.TRAPEZIO:
                return (a + b) / 2 * c
            case Geometria.QUADRADO:
                return b * b
            case Geometria.RETANGULO:
                return a * b
        }
    }
}


/**
 * Passo 4:
 * Nome: 'CalcularEImprimirArea'
 * Criar uma função que receba como parâmetros:
 *   (a) uma variável do tipo da constante criada no Passo 1: valores;
 *   (b) uma variável do tipo String;
 * Esta função irá calcular o valor da área da geometria informada no parâmetro (b) e
 *   imprimir o resultdado no formado: 'NOME_DA_GEOMETRIA: 0.000'
 * Dica: a função criada no Passo 3 será utilizada nesta função;
 */
{
    /**
     * 
     * @param {typeof valores} valores 
     * @param {String} tipoGeometria 
     */
    function ImprimirArea(valores, tipoGeometria) {
        console.log(`${tipoGeometria}: ${CalcularArea(valores, tipoGeometria).toFixed(3)}`)
    }
}

/**
 * Passo 5:
 * Chamar a função criada no Passo 4 informando como parâmetros:
 *   (a) o objeto criado no Passo 1: valores;
 *   (b) a propriedade da geometria desejada para cálculo da área e impressão: Geometrias;
 * O parâmetro (b) deve ser uma das propriedadas do objeto criado no Passo 2;
 * Dica: este passo terá 5 linhas;
 */
{
    ImprimirArea(valores, Geometria.TRIANGULO)
    ImprimirArea(valores, Geometria.CIRCULO)
    ImprimirArea(valores, Geometria.TRAPEZIO)
    ImprimirArea(valores, Geometria.QUADRADO)
    ImprimirArea(valores, Geometria.RETANGULO)
}