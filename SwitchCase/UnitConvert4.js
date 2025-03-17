let choice = parseInt(process.argv[2]);
let value = parseFloat(process.argv[3]); 
console.log("Enter 1: Feet→Inch, 2: Feet→Meter, 3: Inch→Feet, 4: Meter→Feet");
switch (choice) {
  case 1:
    console.log(`${value} Feet = ${value * 12} Inches`);
    break;
  case 2:
    console.log(`${value} Feet = ${value * 0.3048} Meters`);
    break;
  case 3:
    console.log(`${value} Inches = ${value / 12} Feet`);
    break;
  case 4:
    console.log(`${value} Meters = ${value / 0.3048} Feet`);
    break;
  default:
    console.log("Invalid choice. Enter 1: Feet→Inch, 2: Feet→Meter, 3: Inch→Feet, 4: Meter→Feet");
}