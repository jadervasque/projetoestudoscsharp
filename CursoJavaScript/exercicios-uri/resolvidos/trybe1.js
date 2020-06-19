
/**
 * 
 * @param {Number} n 
 */
function fizzBuzz(n) {
    const strFizz = 'Fizz'
    const strBuzz = 'Buzz'
    for (let i = 1; i <= n; i++) {
        const flag3 = i % 3 == 0
        const flag5 = i % 5 == 0
        let output = '';
        if (flag3) output += strFizz;
        if (flag5) output += strBuzz;
        if (!flag3 && !flag5) output = i;
        console.log(output)
    }
}
fizzBuzz(15)

function fizzBuzz2(n) {
    const strFizz = 'Fizz'
    const strBuzz = 'Buzz'
    for (let i = 1; i <= n; i++) {
        const flag3 = i % 3 == 0
        const flag5 = i % 5 == 0
        if (flag3 && flag5) {
            console.log('FizzBuzz')
        } else if (flag3) {
            console.log('Fizz')
        } else if (flag5) {
            console.log('Buzz')
        } else {
            console.log(i)
        }
    }
}
fizzBuzz2(15)