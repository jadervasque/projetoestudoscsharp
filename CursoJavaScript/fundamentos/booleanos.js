let isAtivo = false
console.log(isAtivo)

isAtivo = true
console.log(isAtivo)

//não reconhece isAtivo como boolen
isAtivo = 1
console.log(isAtivo)

//para inteiros, uma ! nega a variável, e !! retorna o valor dela
console.log(!!isAtivo)
console.log(!!true)
console.log(!!false)

//resolvem para verdadeiro
console.log('\n>>>>> resolvem verdadiro')
console.log(!!3)
console.log(!!-1)
console.log(!!' ')
console.log(!!'qualquer texto')
console.log(!![])
console.log(!!{})
console.log(!!Infinity)
console.log(!!(isAtivo = true))

//resolvem para falso
console.log('\n>>>>> resolvem falso')
console.log(!!0)
console.log(!!'')
console.log(!!null)
console.log(!!NaN)
console.log(!!undefined)
console.log(!!(isAtivo = false))

//resolve o lado direito se o esquerdo for falso

console.log('\n>>>>> e para finalizar...')
//retorna verdadeiro se algum dos valores for verdadeiro
console.log(!!('' || null || 0 || ' '))

//retorna o primeiro valor verdadeiro
console.log('' || null || 0 || 'epa' || 123)

let nome = 'Michael'
console.log(nome || 'Desconhecido')
nome = 'Lucas'
console.log(nome || 'Desconhecido')


