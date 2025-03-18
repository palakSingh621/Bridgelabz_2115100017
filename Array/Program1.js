let numbers = [];
for (let i = 0; i < 10; i++) {
  numbers.push(Math.floor(Math.random() * 900) + 100);
}
console.log("Random Numbers:", numbers);

let largest = 0, secondLargest = 0;
let smallest = 1000, secondSmallest = 1000;

for (let num of numbers) {
  if (num > largest) {
    secondLargest = largest;
    largest = num;
  } else if (num > secondLargest && num !== largest) {
    secondLargest = num;
  }

  if (num < smallest) {
    secondSmallest = smallest;
    smallest = num;
  } else if (num < secondSmallest && num !== smallest) {
    secondSmallest = num;
  }
}

console.log("2nd Largest:", secondLargest);
console.log("2nd Smallest:", secondSmallest);