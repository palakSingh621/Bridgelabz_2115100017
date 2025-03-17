let money = 100;
let goal = 200;
let bets = 0;
let wins = 0;

while (money > 0 && money < goal) {
  bets++;
  let betResult = Math.floor(Math.random() * 2);

  if (betResult === 1) {
    money++;
    wins++;
  } else {
    money--;
  }
}

console.log(`Total bets made: ${bets}`);
console.log(`Number of wins: ${wins}`);
console.log(`Final amount: Rs ${money}`);