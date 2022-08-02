// problem: https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a/train/javascript

function past(h, m, s) {
  let hoursAsMS = h * 3600000;
  let minutesAsMS = m * 60000;
  let secondsAsMS = s * 1000;

  return hoursAsMS + minutesAsMS + secondsAsMS;
}
