var intToRoman = function(num) {
  const breakpoints = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
  const numerals = ['M', 'CM', 'D', 'CD', 'C', 'XC', 'L', 'XL', 'X', 'IX', 'V', 'IV', 'I'];
  let i = 0;
  let roman = '';
  while(num > 0) {
       if(num < breakpoints[i]) {
           i++;
       } else {
           num -= breakpoints[i];
           roman += numerals[i];
       }
  }
   return roman;
};