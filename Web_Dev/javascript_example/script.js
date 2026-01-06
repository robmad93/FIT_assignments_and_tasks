// function myMessage(){
//     alert("Yeet");
// }
// myMessage();
function formMessage(){
const firstName = document.getElementsByName("firstName")[0].value;
const secondName = document.getElementsByName("secondName")[0].value;
const personAge = document.getElementsByName("personAge")[0].value;
const personEmail = document.getElementsByName("personEmail")[0].value;

alert(`Thank you ${firstName} ${secondName} for your application. In 10 years time, you will be ${parseInt(personAge) + 10} years old.`)
return true;
}

function calculateTwoNumbers(operator){
const firstNumber = parseFloat(document.getElementsByName("firstNumber")[0].value);
const secondNumber = parseFloat(document.getElementsByName("secondNumber")[0].value);
const twoNumberOutput = document.getElementById("twonumberoutput");
let result = "";
if (operator === "add"){
result = `${firstNumber} + ${secondNumber} = ${firstNumber + secondNumber}`
}
else if (operator === "subtract"){
result = `${firstNumber} - ${secondNumber} = ${firstNumber - secondNumber}` 
}
else if (operator === "multiply"){
result = `${firstNumber} * ${secondNumber} = ${firstNumber * secondNumber}`
}
else if (operator === "divide") {
result = `${firstNumber} / ${secondNumber} = ${firstNumber / secondNumber}`
}
twoNumberOutput.innerHTML = `<h3>${result}</h3>`;
}

function rollDice(){
    let x = Math.floor((Math.random() * 6) + 1);
    return x;
}

function diceRollDistributionGenerator(generate){
    const diceRolls = {one: 0, two: 0, three: 0, four: 0, five: 0, six: 0}
    const numberOfRolls = parseInt(document.getElementsByName("numberOfRolls")[0].value);
    const diceRollOutcomes = document.getElementById("dicerolloutcomes");
    let result = "";
    for (let i = 0; i < numberOfRolls; i++) {
    let diceRoll = rollDice();

    if (diceRoll === 1) diceRolls.one++;
    else if (diceRoll === 2) diceRolls.two++;
    else if (diceRoll === 3) diceRolls.three++;
    else if (diceRoll === 4) diceRolls.four++;
    else if (diceRoll === 5) diceRolls.five++;
    else diceRolls.six++;
}
    result = `Number of ones: ${diceRolls.one}<br>Number of twos: ${diceRolls.two}<br>Number of threes: ${diceRolls.three}<br>Number of fours: ${diceRolls.four}<br>Number of fives: ${diceRolls.five}<br>Number of sixes: ${diceRolls.six}`
    dicerolloutcomes.innerHTML = `<h3>${result}</h3>`;
    }

