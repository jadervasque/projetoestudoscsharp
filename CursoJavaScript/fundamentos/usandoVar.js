/**
 * Variáveis do tipo var podem ser vistas fora de blocos
 *   caso não estejam dentro de uma função específica
 *   por isso variáveis var podem ser redeclaradas.
 * As variáveis var são do tipo global, pois cria confusão.
 */
const log = t => console.log(t)
{
    {
        {
            {
                var sera = 'Será???'
            }
        }
    }
}
log(sera)

/**
 * variáveis var criadas dentro de uma função são do tipo local.
 */
function teste() {
    var local = 123
    log(local)
}
teste()
//log(local)