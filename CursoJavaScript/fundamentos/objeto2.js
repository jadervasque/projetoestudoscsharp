const log = t => console.log(t)

log(typeof Object)
log(typeof new Object)
log(typeof new Object())

const Cliente = function () { }
log(typeof Cliente)
log(typeof new Cliente)

// Internamente a classe trata-se de uma função
class Produto { }
log(typeof Produto)
log(typeof new Produto)
log(typeof new Produto())

