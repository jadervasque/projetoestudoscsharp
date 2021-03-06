
// ponto inteiro
// o ponto não impacta no formado
// o fato do número estar inteiro é o que define
const peso1 = 1.0

const peso2 = Number('2.0')
const peso3 = Number('3.5')
console.log(peso1, peso2)
console.log(Number.isInteger(peso1))
console.log(Number.isInteger(peso3))

const avaliacao1 = 9.871
const avaliacao2  = 6.871

const total = avaliacao1 * peso1 + avaliacao2 * peso2
const media = total / (peso1 + peso2)
console.log(media)

// arredondar casas decimais
console.log(media.toFixed(2))

// converter valor numérico em string
console.log(media.toString())

// converter valor em binário
console.log(media.toString(2))
console.log(typeof media)
console.log(typeof Number)

var valor1 = prompt('Digite o valor 1: ')
var valor2 = prompt('Digite o valor 2: ')
