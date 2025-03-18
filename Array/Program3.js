function getPrimeFactors(n) {
    let factors = [];
    for (let i = 2; i <= n; i++) {
      while (n % i === 0) {
        factors.push(i);
        n = n / i;
      }
    }
    return factors;
  }
  
  let number = 120;
  let primeFactors = getPrimeFactors(number);
  console.log(`Prime factors of ${number} are:`, primeFactors);