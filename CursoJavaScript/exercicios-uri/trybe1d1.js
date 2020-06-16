
/**
 * 
 * @param {String} rating 
 */
function tipPercentage(rating) {
    switch (rating) {
        case 'Terrible':
        case 'Poor':
            return 3
        case 'Good':
        case 'Great':
            return 10
        case 'Excellent':
            return 20
        default:
            return 0
    }
}


tipPercentage('Terrible')
tipPercentage('Poor')
tipPercentage('Good')
tipPercentage('Great')
tipPercentage('Excellent')
tipPercentage('Don\'t Liked')