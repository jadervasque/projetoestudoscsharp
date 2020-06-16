var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

class Ponto {
    constructor(x, y) {
        this.x = x
        this.y = y
    }
}

let pontos = []
for (let i = 0; i < 2; i++) {
    const entrada = lines.shift().split(' ')
    // const entrada = prompt().split(' ')
    const x = parseFloat(entrada[0])
    const y = parseFloat(entrada[1])
    pontos.push(new Ponto(x, y))
}

let distancia = Math.pow(pontos[1].x - pontos[0].x, 2)
distancia += Math.pow(pontos[1].y - pontos[0].y, 2)
distancia = Math.sqrt(distancia)
// alert(distancia.toFixed(4))
console.log(distancia.toFixed(4))