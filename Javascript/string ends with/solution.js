// problem: https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/train/javascript

function solution(str, ending) {
  const endingLength = ending.length;
  const numberToTrim = str.length - endingLength;
  const trimmedString = str.substring(numberToTrim, 0);
  if (trimmedString.concat(ending) === str) {
    return true;
  } else {
    return false;
  }
}
