const divDiceRoll = document.getElementById("divDiceRoll");
divDiceRoll.innerHTML = "";
let timerID = null;

function rollDice(){
    let x = Math.floor((Math.random() * 6) + 1);
    divDiceRoll.textContent = x;
}
function startDiceRoll(){
    if (timerID === null) {
        timerID = setInterval(rollDice, 100)
    }
}

function stopDiceRoll(){
clearInterval(timerID); 
timerID = null;
}