const readline = require("readline-sync");

let low = 1;
let high = 100;

console.log("Think of a number between 1 to 100.");
console.log("I will try to guess it. Please respond with:");
console.log("  <  if your number is LESS than my guess");
console.log("  >  if your number is GREATER than my guess");
console.log("  =  if my guess is CORRECT");

while (low <= high) {
  let mid = Math.floor((low + high) / 2);
  let response = readline.question(`Is your number <, > or = to ${mid}? `);

  if (response === "<") {
    high = mid - 1;
  } else if (response === ">") {
    low = mid + 1;
  } else if (response === "=") {
    console.log(`Yay! Your magic number is ${mid}.`);
    break;
  } else {
    console.log("Invalid input. Please enter only <, > or =");
  }
}