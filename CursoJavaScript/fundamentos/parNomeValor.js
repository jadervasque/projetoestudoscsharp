const log = t => console.log(t)

//par nome/valor
const saudacao = 'Opa' //Contexto léxico 1

/**
 * Contexto é local o qual a variável está fisicamente
 * ligada com o código em que local a variável está armazenada
 */

 function exec() {
     const saudacao = 'Falaaaa' // contexto léxico 2
     return saudacao
 }

 // Objetos são grupos aninhados de pares nome/valor
 const cliente = {
     nome: 'Pedro',
     idade: 32,
     peso: 90,
     enderedo: {
         logradouro: 'Rua Muito Legal',
         numero: 123
     }
 }

 log(saudacao)
 log(exec())
 log(cliente)

