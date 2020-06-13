
//compara valor, ignora o tipo
console.log('01)', '1' == 1); // true, os valores são iguais?
console.log('03)', '3' != 3) // false, os valores são diferentes?

//compara valor e tipo
console.log('02)', '1' === 1) // false, os valores e os tipos são iguais?
console.log('04)', '3' !== 3) // true, os valores e os tipos são diferentes?

console.log('05)', 3 < 2);
console.log('06)', 3 > 2);
console.log('07)', 3 <= 2);
console.log('08)', 3 >= 2);

const d1 = new Date(0)
const d2 = new Date(0)
console.log('09)', d1 === d2);
console.log('10)', d1 == d2);
console.log('11)', d1.getTime() === d2.getTime())
console.log('12)', undefined == null);
console.log('13)', undefined === null);

