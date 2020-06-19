
/**
 * 
 * @param {String} word 
 */
function lastLetters(word) {
    const letterA = word[word.length - 2]
    const letterB = word[word.length - 1]
    return `${letterB} ${letterA}`
}


console.log(lastLetters('APPLE'))
console.log(lastLetters('BAT'))