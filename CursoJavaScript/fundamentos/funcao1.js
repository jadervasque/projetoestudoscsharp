
/**
 * bloco de código nomeado
 * recebe parâmetros de entrada
 * tem um algoritmo que executa um processo sempre igual
 * pode conter ou não dados de entrada e saída
 * é como uma receita de bolo
 * pode ser reutilizada e invocada quantas vezes for necessário
 * classes também são funções
 * pode chamar uma função com uma quantidade de parâmetros
 * diferente do contrutor da função
 */

/**
 * função sem retorno
 * não pe necessário declarar o tipo das variáveis,
 * se são const, let ou var
 */
function imprimirSoma(a, b) {
    console.log(a + b)
}

// chamando uma função
imprimirSoma(2, 3)
imprimirSoma(2) // NaN
imprimirSoma(2, 10, 4, 5, 6, 7, 8)
imprimirSoma() // NaN

// funcao com retorno
function soma(a, b = 1) {
    return a + b
}

console.log(soma(2, 3))
console.log(soma(5))
console.log(soma()) // NaN