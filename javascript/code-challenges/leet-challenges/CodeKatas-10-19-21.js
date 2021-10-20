//Code challenges completed as part of Code Katas with seattle JS

//Warmup: https://www.codewars.com/kata/5a54e796b3bfa8932c0000ed/train/javascript
function jumpingNumber(n){
  let numString = n.toString();
  if(numString.length == 1) {
    return 'Jumping!!';
  }
  for(let i = 0; i < numString.length; i++) {
    if(i-1 >= 0 && (Math.abs(parseInt(numString[i]) - parseInt(numString[i-1]))) != 1) {
      return 'Not!!';
    }
  }
  return 'Jumping!!';
}

// Challenge Yourself #1: Strong Numbers https://www.codewars.com/kata/5a54e796b3bfa8932c0000ed/train/javascript

function strong(n) {
  let digits = n.toString().split('').map(digit=>parseInt(digit));
  let sum = 0;
  digits.forEach(digit=>{sum += factorial(digit)});
  return sum === n ? "STRONG!!!!" : "Not Strong !!" ;
}

const factorial = n => n <= 1 ? 1 : n * factorial(n - 1);

//Challenge Yourself #2: Multiples of 3 & 5: https://www.codewars.com/kata/514b92a657cdc65150000006/train/javascript

function solution(number){
  let sum = 0;
  if(number > 0) {
    for(let i = 3; i<number; i++) {
      if(i % 3 === 0 || i % 5 === 0) {sum += i}
    }
  }
  return sum;
}