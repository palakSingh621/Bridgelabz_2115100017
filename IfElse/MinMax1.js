let numbers = [];
let min=999;
let max=0;
for (let i = 0; i < 5; i++) {
  let num = Math.floor(Math.random() * 900) + 100;
  numbers.push(num);
  min=Math.min(min, num);
  max=Math.max(max,num);
}
console.log("Random 3-digit numbers:", numbers.join(", "));
console.log("Minimum value:", min);
console.log("Maximum value:", max);