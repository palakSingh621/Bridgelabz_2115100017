function isPalindrome(num) {
    let reversed = parseInt(num.toString().split("").reverse().join(""));
    return num === reversed;
  }
  
  let num1 = 121;
  let num2 = 123;
  
  console.log(`${num1} is palindrome? `, isPalindrome(num1));
  console.log(`${num2} is palindrome? `, isPalindrome(num2));