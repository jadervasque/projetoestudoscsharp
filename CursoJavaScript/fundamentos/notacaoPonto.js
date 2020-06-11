const log = t => console.log(t)

log(Math.ceil(6.1))

const obj1 = {}
obj1.nome = 'Bola'
log(obj1)
obj1['nome'] = 'Bola2'
log(obj1)

function Obj(nome) {
    this.nome = nome
    this.exec = function() {
        log('Exec...')
    }
}

let obj2 = new Obj('Cadeira')
let obj3 = new Obj('Mesa')
log(obj2)
log(obj3)

obj3.exec()