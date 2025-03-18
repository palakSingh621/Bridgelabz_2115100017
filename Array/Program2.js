let numbers = [];
for (let i = 0; i < 10; i++) {
  numbers.push(Math.floor(Math.random() * 900) + 100);
}
let sorted = numbers.sort((a, b) => a - b);
console.log("Sorted Array:", sorted);

console.log("2nd Smallest (Sorted):", sorted[1]);
console.log("2nd Largest (Sorted):", sorted[sorted.length - 2]);