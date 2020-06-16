
/**
 * These are the types of operations that can be performed
 */
const Operation = {
    SUM: '+',
    SUBTRACTION: '-',
    MULTIPLICATION: '*',
    DIVISION: '/',
    POW: '^',
    SQRT: 'r',
    FACTORIAL: '!',
}

/**
 * These are the types of punctuations that were used
 */
const Punctuation = {
    OPEN: '(',
    CLOSE: ')',
    COMMA: ',',
    SPACE: ' ',
    EMPTY: '',
}

const OperatorAscii = {
    SUM: 43,
    SUBTRACTION: 45,
    MULTIPLICATION: 42,
    DIVISION: 47,
    POW: 94,
    FACTORIAL: 33,
}

/**
 * The program starts here
 */
const expression = RequestExpression()
const result = CalculateExpression(expression)
alert(result)

function RequestExpression() {
    let input = prompt('Enter the expression:')
    if (input === null) {
        return null
    }
    return ClearExpression(input)
}

/**
 *
 *
 * @param {String} expression
 */
function ClearExpression(expression) {
    let text = expression
    while (text.includes(Punctuation.SPACE)) {
        text = text.replace(Punctuation.SPACE, Punctuation.EMPTY)
    }
    return text
}

/**
 * 
 * @param {String} char 
 */
function IsOperator(char) {
    if (char == null)
        return true
    const code = char.charCodeAt(0)
    if (code == OperatorAscii.SUM ||
        code == OperatorAscii.SUBTRACTION ||
        code == OperatorAscii.MULTIPLICATION ||
        code == OperatorAscii.DIVISION ||
        code == OperatorAscii.POW)
        return true
    else
        return false
}

/**
 * 
 * @param {String} expression
 */
function IsOneOperationAndType(expression) {
    let operators = Punctuation.EMPTY
    for (let i = 0; i < expression.length; i++) {
        if (IsOperator(expression[i])) {
            operators += expression[i]
        }
    }
    const flag1 = operators.length <= 2 && expression[0] == Operation.SUBTRACTION
    const flag2 = operators == `${Operation.MULTIPLICATION}${Operation.SUBTRACTION}` && expression[expression.indexOf(Operation.MULTIPLICATION) + 1] == Operation.SUBTRACTION
    const flag3 = operators == `${Operation.SUBTRACTION}${Operation.SUBTRACTION}` && expression[expression.indexOf(Operation.SUBTRACTION) + 1] == Operation.SUBTRACTION
    if (flag1 || flag2 || flag3) {
        operators = operators.replace(Operation.SUBTRACTION, Punctuation.EMPTY)
    }
    return operators
}

/**
 * 
 * @param {Number} a 
 * @param {Number} b 
 * @param {String} operation 
 */
function DoCalculation(a, b, operation) {
    switch (operation) {
        case Operation.SUM:
            return a + b
        case Operation.SUBTRACTION:
            return a - b
        case Operation.MULTIPLICATION:
            return a * b
        case Operation.DIVISION:
            return a / b
        case Operation.POW:
            return Math.pow(a, b)
        case Operation.FACTORIAL:
            let result = a
            for (let i = --a; i > 1; i--) {
                result *= i                 
            }
            return result
    }
}

/**
 * 
 * @param {String} opA
 * @param {String} opB
 * @param {String} expression
 */
function FindFirstOperation(opA, opB, expression) {
    if (expression[0] == Operation.SUBTRACTION) {
        expression = expression.substring(1, expression.length - 1)
    }
    const hasA = expression.includes(opA)
    const hasB = expression.includes(opB)
    if (hasA && hasB) {
        const idA = expression.indexOf(opA)
        const idB = expression.indexOf(opB)
        return idA < idB ? opA : opB
    }
    return hasA ? opA : opB
}

/**
 * 
 * @param {String} expression
 * @param {Number} idOperator
 */
function MakeExpression(expression, idOperator) {
    let idStart = idOperator - 1
    let idEnd = idOperator + 1
    while (idStart == 1 || !IsOperator(expression[idStart - 1])) { --idStart }
    while (!IsOperator(expression[idEnd + 1])) { ++idEnd }
    return expression.substring(idStart, ++idEnd)
}

/**
 * 
 * @param {String} expression 
 */
function GetExpressionWithinParentheses(expression) {
    let count = 0
    let idStart = expression.indexOf(Punctuation.OPEN)
    let idEnd;
    for (let i = ++idStart; i < expression.length; i++) {
        if (expression[i] == Punctuation.CLOSE) {
            if (count == 0) {
                idEnd = i
                break
            } else {
                count--
            }
        }
        else if (expression[i] == Punctuation.OPEN) {
            count++
        }
    }
    return expression.substring(idStart, idEnd)
}

/**
 * 
 * @param {String} expression 
 */
function GetExpressionWithinRoot(expression) {
    let count = 0
    let idStart = expression.indexOf(Operation.SQRT) + 2
    let idEnd;
    for (let i = idStart; i < expression.length; i++) {
        if (expression[i] == Punctuation.CLOSE) {
            if (count == 0) {
                idEnd = i
                break
            } else {
                count--
            }
        }
        else if (expression[i] == Punctuation.OPEN) {
            count++
        }
    }
    return expression.substring(idStart, idEnd)
}

/**
 * 
 * @param {String} expression 
 */
function GetFactorial(expression) {
    let idStart = expression.indexOf(Operation.FACTORIAL) - 1
    let idEnd = idStart
    while (!IsOperator(expression[idStart - 1])) { --idStart }
    return expression.substring(idStart, ++idEnd)
}

/**
 * 
 * @param {String} expression 
 */
function CalculateExpression(expression) {
    //Calculate roots
    while (expression.includes(Operation.SQRT)) {
        let subExpression = GetExpressionWithinRoot(expression)
        let newExpression = CalculateExpression(subExpression)
        expression = expression.replace(`${Operation.SQRT}${Punctuation.OPEN}${subExpression}${Punctuation.CLOSE}`, newExpression)
    }
    //Calculate parentheses
    while (expression.includes(Punctuation.OPEN)) {
        let subExpression = GetExpressionWithinParentheses(expression)
        let newExpression = CalculateExpression(subExpression)
        expression = expression.replace(`${Punctuation.OPEN}${subExpression}${Punctuation.CLOSE}`, newExpression)
    }
    //Calculate factorials
    while (expression.includes(Operation.FACTORIAL)) {
        let subExpression = GetFactorial(expression)
        let newExpression = DoCalculation(subExpression, 1, Operation.FACTORIAL)
        expression = expression.replace(`${subExpression}${Operation.FACTORIAL}`, newExpression)
    }
    //Calculate root radicand with index
    if (expression.includes(Punctuation.COMMA)) {
        let vet = expression.split(Punctuation.COMMA)
        let radicand = CalculateExpression(vet[0])
        let index = CalculateExpression(vet[1])
        return Math.pow(radicand, 1 / index)
    }
    //Calculate single oeprations
    const operator = IsOneOperationAndType(expression)
    if (operator.length == 1) {
        const numbers = expression.split(operator)
        let a = parseFloat(numbers[0])
        let b = parseFloat(numbers[1])
        if (numbers.length == 3) {
            if (expression[0] == Operation.SUBTRACTION) {
                a = parseFloat(numbers[1]) * (-1)
                b = parseFloat(numbers[2])
            } else {
                b = parseFloat(numbers[2]) * (-1)
            }
        }
        return DoCalculation(a, b, operator)
    } else {
        //Calculate powers
        while (expression.includes(Operation.POW)) {
            const operation = Operation.POW
            const newExpression = MakeExpression(expression, expression.indexOf(operation))
            expression = expression.replace(newExpression, CalculateExpression(newExpression))
        }
        //Calculate multiplications and divisions
        while (expression.includes(Operation.MULTIPLICATION) || expression.includes(Operation.DIVISION)) {
            const operation = FindFirstOperation(Operation.MULTIPLICATION, Operation.DIVISION, expression)
            const newExpression = MakeExpression(expression, expression.indexOf(operation))
            expression = expression.replace(newExpression, CalculateExpression(newExpression))
        }
        //Calculate sums and subtrations
        while (expression.includes(Operation.SUM) || expression.includes(Operation.SUBTRACTION)) {
            if (IsOneOperationAndType(expression).length == 0) {
                break;
            }
            const operation = FindFirstOperation(Operation.SUM, Operation.SUBTRACTION, expression)
            const newExpression = MakeExpression(expression, expression.indexOf(operation))
            expression = expression.replace(newExpression, CalculateExpression(newExpression))
        }
    }
    return expression
}