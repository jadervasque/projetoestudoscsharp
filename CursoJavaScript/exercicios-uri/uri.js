const at = (t) => {
    return `${t}\n`
}

var input = ''
input += at('-736 -539')

// var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

const info = lines.shift().split(' ')
const a = parseInt(info[0])
const b = parseInt(info[1])

let quociente, resto;
if (a >= 0) {
    quociente = a / b;
    resto = a % b;
} else {
    let x = 0, y = 0;

    if (b < 0) {
        x = b * -1
    }
    else {
        x = b
    }

    for (resto = 0; resto < x; resto++) {
        y = a - resto;
        if (y % b == 0) {
            break
        }
    }
    quociente = y / b;
}

// let q = Math.trunc(a / b)
// let r = a - b * q

console.log(`${quociente} ${resto}`)


// b * q + r = a