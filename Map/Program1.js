let dieMap = new Map();

for (let i = 1; i <= 6; i++) {
  dieMap.set(i, 0);
}

let rollCount = 0;
let done = false;
while (!done) {
  let roll = Math.floor(Math.random() * 6) + 1;
  dieMap.set(roll, dieMap.get(roll) + 1);
  rollCount++;

  if (dieMap.get(roll) === 10) {
    done = true;
  }
}

console.log("Die Roll Frequencies:");
console.log(Object.fromEntries(dieMap));

let maxNum = 1, minNum = 1;
let maxFreq = dieMap.get(1), minFreq = dieMap.get(1);

for (let [key, value] of dieMap.entries()) {
  if (value > maxFreq) {
    maxFreq = value;
    maxNum = key;
  }
  if (value < minFreq) {
    minFreq = value;
    minNum = key;
  }
}

console.log(`Number with Max Occurrences: ${maxNum} (${maxFreq} times)`);
console.log(`Number with Min Occurrences: ${minNum} (${minFreq} times)`);