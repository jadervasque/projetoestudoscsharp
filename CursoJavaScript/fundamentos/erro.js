function tratarErroELancar() {
    throw new Error('Insira seus dados bancários juntamente com sua senha:')
}

function imprimirNomeGritado(obj) {
    try {
        console.log(obj.name.toUpperCase() + '!!!')
    } catch (e) {
        tratarErroELancar()
    } finally {
        console.log('taca o frango nos peito do programador que fez esta BOSTA!!!!!!!! COCÓÓÓÓÓÓÓÓ')
    }
}

const obj = { name: 'Roberto' }
imprimirNomeGritado(obj)
