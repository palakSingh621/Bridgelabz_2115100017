function isPrime(n) {
    if (n < 2) return false;
    for (let i = 2; i <= Math.sqrt(n); i++) {
      if (n % i === 0) return false;
    }
    return true;
  }
  
  function getPalindrome(num) {
    let reversed = parseInt(num.toString().split('').reverse().join(''));
    return reversed;
  }
  
  const readline = require("readline-sync");
  let number = parseInt(readline.question("Enter a number: "));
  
  if (isPrime(number)) {
    console.log(`${number} is a prime number.`);
  
    let palindrome = getPalindrome(number);
    console.log(`Palindrome of ${number} is ${palindrome}.`);
  
    if (isPrime(palindrome)) {
      console.log(`${palindrome} is also a prime number.`);
    } else {
      console.log(`${palindrome} is NOT a prime number.`);
    }
  } else {
    console.log(`${number} is NOT a prime number.`);
  }