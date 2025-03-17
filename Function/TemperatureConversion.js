const readline = require("readline-sync");

function convertTemperature() {
  let choice = readline.question("Enter 'C' to convert Celsius to Fahrenheit or 'F' to convert Fahrenheit to Celsius: ").toUpperCase();

  switch (choice) {
    case 'C':
      let celsius = parseFloat(readline.question("Enter temperature in Celsius (0°C to 100°C): "));
      if (celsius >= 0 && celsius <= 100) {
        let fahrenheit = (celsius * 9 / 5) + 32;
        console.log(`${celsius}°C = ${fahrenheit.toFixed(2)}°F`);
      } else {
        console.log("Invalid Celsius value! It must be between 0°C and 100°C.");
      }
      break;

    case 'F':
      let fahrenheit = parseFloat(readline.question("Enter temperature in Fahrenheit (32°F to 212°F): "));
      if (fahrenheit >= 32 && fahrenheit <= 212) {
        let celsius = (fahrenheit - 32) * 5 / 9;
        console.log(`${fahrenheit}°F = ${celsius.toFixed(2)}°C`);
      } else {
        console.log("Invalid Fahrenheit value! It must be between 32°F and 212°F.");
      }
      break;

    default:
      console.log("Invalid choice! Please enter C or F.");
  }
}

convertTemperature();