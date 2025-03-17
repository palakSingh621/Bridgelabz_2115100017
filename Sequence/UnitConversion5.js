// a. 1 ft = 12 inches (inches to feet)
let inches = 42;
let feet = inches / 12;
console.log(`a. 42 inches = ${feet} feet`);

// b. Convert rectangular plot dimensions from feet to meters
// 1 foot = 0.3048 meters
let length_ft = 60;
let width_ft = 40;
let length_m = length_ft * 0.3048;
let width_m = width_ft * 0.3048;
console.log(`b. Plot size in meters: ${length_m.toFixed(2)} m x ${width_m.toFixed(2)} m`);

// c. Area of 25 such plots in acres
// Area of one plot in square meters
let area_one_plot_m2 = length_m * width_m;

// Total area of 25 plots
let total_area_m2 = area_one_plot_m2 * 25;

// 1 acre = 4046.86 square meters
let total_area_acres = total_area_m2 / 4046.86;
console.log(`c. Total area of 25 plots = ${total_area_acres.toFixed(4)} acres`);