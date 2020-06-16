const at = (t) => {
    return `${t}\n`
}

// var input = ''
// input += at('4 1')
// input += at('2')
// input += at('3')
// input += at('5')
// input += at('1')
// input += at('5')
// input += at('5 2')
// input += at('1')
// input += at('3')
// input += at('3')
// input += at('3')
// input += at('1')
// input += at('2')
// input += at('3')
// input += at('0 0')

var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

let entrada = lines.shift()
let count = 1
while (entrada != '0 0') {
    // while ((entrada = prompt('Entre com Q e N:')) != '0 0') {
    entrada = entrada.split(' ')
    const n = parseInt(entrada[0]) // número de testes
    const q = parseInt(entrada[1]) // número de consultas
    console.log(`CASE# ${count}`)
    // console.log(`CASE# ${count}`)
    let marbles = []
    for (let i = 1; i <= n; i++) {
        marbles.push(parseInt(lines.shift()))
    }
    marbles = marbles.sort()
    for (let i = 0; i < q; i++) {
        const p = parseInt(lines.shift())
        if (p > 10000) {
            break
        }
        let a = marbles.findIndex(t => t == p)
        if (a > 0) {
            console.log(`${p} found at ${++a}`)
        } else {
            console.log(`${p} not found`)
        }
    }
    count++
    entrada = lines.shift()
}