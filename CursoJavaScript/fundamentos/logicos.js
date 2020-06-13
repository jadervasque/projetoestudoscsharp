
//se os dois trabalhos derem certo = TV 50' + sorvete
//se um dos dois der certo = TV 32' + sorvete
//se nenhum der certo = ficar em casa

function compras(trabalho1, trabalho2) {
    var comprarSorvete = trabalho1 || trabalho2
    const comprarTv50 = trabalho1 && trabalho2
    // const comprarTv32 = !!(trabalho1 ^ trabalho2)
    const comprarTv32 = trabalho1 != trabalho2
    const manterSaudavel = !comprarSorvete
    return { comprarSorvete, comprarTv50, comprarTv32, manterSaudavel }
}

console.log(compras(true, true));
console.log('\n')
console.log(compras(false, true));
console.log('\n')
console.log(compras(true, false));
console.log('\n')
console.log(compras(false, false));