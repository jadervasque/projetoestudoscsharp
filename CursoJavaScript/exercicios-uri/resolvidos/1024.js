var input = require('fs').readFileSync('/dev/stdin', 'utf8')
var lines = input.split('\n')

class Criptografar {
    constructor(mensagem) {
        this.texto = mensagem
    }

    get Texto() {
        return this.texto;
    }

    get TextoCriptografado() {
        let value = this.texto;
        value = this.Encriptacao1(value)
        value = this.Encriptacao2(value)
        value = this.Encriptacao3(value)
        return value
    }

    /**
     * 
     * @param {String} texto 
     */
    Encriptacao1(texto) {
        let value = '';
        for (let i = 0; i < texto.length; i++) {
            let bchar = texto.charCodeAt(i)
            let flag1 = bchar >= 65  // >= A
            let flag2 = bchar <= 90  // <= Z
            let flag3 = bchar >= 97  // >= a
            let flag4 = bchar <= 122 // <= z
            if ((flag1 && flag2) || (flag3 && flag4)) {
                bchar += 3
            }
            value += String.fromCharCode(bchar)
        }
        return value
    }
    
    /**
     * 
     * @param {String} params 
     */
    Encriptacao2(texto) {
        let value = ''
        for (let i = texto.length - 1; i >= 0; i--) {
            value += texto[i]
        }
        return value
    }
    
    /**
     * 
     * @param {String} params 
     */
    Encriptacao3(texto) {
        let i = Math.trunc(texto.length / 2)
        let value = texto.substring(0, i)
        for (; i < texto.length; i++) {
            let bchar = texto.charCodeAt(i)
            const char = String.fromCharCode(bchar - 1)
            value += char
        }
        return value
    }

}

const nt = parseInt(lines.shift())
// const nt = parseInt(prompt('Casos de teste:'))
for (let t = 0; t < nt; t++) {
    const texto = lines.shift()
    // const texto = prompt('Entre com o texto:')
    const textoCriptografado = new Criptografar(texto)
    console.log(textoCriptografado.TextoCriptografado)
}