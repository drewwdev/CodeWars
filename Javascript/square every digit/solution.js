// problem: https://www.codewars.com/kata/546e2562b03326a88e000020/train/javascript

function squareDigits(num) {
  let numString = String(num);
  let numArray = numString.split("");
  let squared = "";
  for (const digit of numArray) {
    const squaredNum = digit * digit;
    squared += squaredNum;
  }
  return parseInt(squared);
}
