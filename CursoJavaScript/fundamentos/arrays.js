
const valores = [7.7, 8.9, 6.3, 9.2]
console.log(valores)
console.log(valores[0], valores[3])
console.log(valores[4])

valores[4] = 10
console.log(valores[4])

//adiciona um valor na posição 10
//e acrescenta valores vazios caso não existam posições
valores[10] = 150
console.log(valores)

//retorna o tamanho do array
console.log(valores.length)

//adiciona um valor ao array
valores.push({id: 3}, false, null, 'teste')
console.log(valores)

//remove o último valor do array
console.log(valores.pop())

//remove um index específico do array
delete valores[0]
console.log(valores)

//array é do tipo objeto
console.log(typeof valores)