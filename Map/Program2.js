let birthMonthMap = new Map();

for (let i = 1; i <= 50; i++) {
  let month = Math.floor(Math.random() * 12) + 1;
  
  let year = Math.random() < 0.5 ? 1992 : 1993;
  if (!birthMonthMap.has(month)) {
    birthMonthMap.set(month, []);
  }
  birthMonthMap.get(month).push(`Person${i} (Born in ${month}/${year})`);
}

for (let [month, people] of birthMonthMap.entries()) {
  console.log(`\nMonth ${month} has ${people.length} birthday(s):`);
  console.log(people.join(", "));
}