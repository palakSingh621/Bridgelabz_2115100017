let day = parseInt(process.argv[2]);
let month = parseInt(process.argv[3]);

if(day){
    console.log("Enter the day ");
}
if(month){
    console.log("Enter the month ");
}
console.log(day);
console.log(month);
let isSpring = false;
if ((month === 3 && day >= 20 && day <= 31) ||         // March 20–31
    (month === 4 && day >= 1 && day <= 30) ||          // April
    (month === 5 && day >= 1 && day <= 31) ||          // May
    (month === 6 && day >= 1 && day <= 20)) {          // June 1–20
  isSpring = true;
}
console.log(isSpring);