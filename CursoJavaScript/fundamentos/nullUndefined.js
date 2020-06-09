//atribuição por referência

const a = { name: 'Teste' }
const b = a;
b.name = 'Opa'
console.log(a.name);

/* b recebeu apenas o endereço de a,P
 * por isso a.name foi alterado através de b
 */

let valor
console.log(valor) // = undefined = não foi instanciada/inicializada
// console.log(valor2) = is not defined = não foi declarada

//não está apontando para nenhum endereço de memória
//ou seja, ausência de valor
valor = null;
console.log(valor) // = undefined = não foi instanciada/inicializada

//cuidados
// console.log(valor.toString());

const produto = {}
console.log(produto.preco) // = undefined
// console.log(produto.preco.a)  = erro

produto.preco = 3.50
console.log(produto)

produto.preco = undefined // evitar utilizar
console.log(!!produto.preco);
console.log(produto);

protudo.preco = null // sem preço
console.log(produto);
