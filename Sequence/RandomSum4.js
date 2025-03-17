let sum = 0;
let numbers=[];
for (let i = 0; i < 5; i++) {
  let num = Math.floor(Math.random() * 90) + 10;
  numbers.push(num);
  sum += num;
}
let average = sum / numbers.length;
console.log("Random 2-digit numbers:", numbers.join(", "));
console.log("Sum:", sum);
console.log("Average:", average.toFixed(2));