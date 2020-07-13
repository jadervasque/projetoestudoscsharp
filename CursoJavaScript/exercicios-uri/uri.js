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



// let q = Math.trunc(a / b)
// let r = a - b * q

console.log(`${quociente} ${resto}`)


// b * q + r = a