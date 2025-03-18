let repeatedDigits = [];

for (let i = 10; i <= 99; i++) {
  let str = i.toString();
  if (str[0] === str[1]) {
    repeatedDigits.push(i);
  }
}

console.log("Numbers with repeated digits:", repeatedDigits);