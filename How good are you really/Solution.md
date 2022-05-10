Problem: https://www.codewars.com/kata/5601409514fc93442500010b/train/javascript

function betterThanAverage(classPoints, yourPoints) {
// Your code here

let classCount = 0;
for (let i = 0; i < classPoints.length; i++){
classCount += classPoints[i];
}
const classAverage = classCount / classPoints.length;

return (classAverage > yourPoints ? false : true);
}
