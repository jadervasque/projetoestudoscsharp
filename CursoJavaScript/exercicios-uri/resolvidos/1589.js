const at = (t) => {
    return `${t}\n`
}

// var input = ''
// input += at('3')
// input += at('1 1')
// input += at('2 8')
// input += at('8 2')

var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

let casos = lines.shift()
for (let i = 0; i < casos; i++) {
    let info = lines.shift().split(' ')
    let r1 = parseInt(info[0])
    let r2 = parseInt(info[1])
    console.log(r1 + r2)
}