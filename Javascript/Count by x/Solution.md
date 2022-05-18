problem: https://www.codewars.com/kata/5513795bd3fafb56c200049e/train/javascript

function countBy(x, n) {
let z = [];
let count = x;
z.push(x);
while (z.length < n)
{
count += x;
z.push(count);
console.log(z)
};
return z;
}
