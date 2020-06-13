
//desctructuring simples
const [a] = [10]

//destructuring composto
const [n1, , n3, , n5, n6 = 0] = [10, 7, 9, 8]
console.log(n1, n3, n5, n6); // 10 9 undefined 0

//destructuring aninhado
const [, [, nota]] = [[, 8, 8], [9, 6, 8]]
console.log(nota);
