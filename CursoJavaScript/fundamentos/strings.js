const escola = "Cod3r"

//busca um caractere pelo índice: "r"
console.log(escola.charAt(4))

//não retorna nada, pois o índice está fora da palavra : ""
console.log(escola.charAt(5))

//retorna o valor do caractere na tabela ASCII : 51
console.log(escola.charCodeAt(3))

//retorna a posição index do caractere fornecido : 3
console.log(escola.indexOf('3'))

//retorna a string a partir do index fornecido : "oder"
console.log(escola.substring(1))

//retorna a string a partir o index fornecido até a quantidade oferecida : Cod
console.log(escola.substring(0, 3))

//concatena strings em cadeia infinita : "Escola Cod3r!"
console.log('Escola '.concat(escola).concat("!"))
console.log('Escola ' + escola + '!')

//substitui o index 3 pela letra 'e' : "Coder"
console.log(escola.replace(3, 'e'))

//converte a string em array
console.log('Ana,Maria,Pedro'.split(','))