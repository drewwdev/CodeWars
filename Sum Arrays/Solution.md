Problem: https://www.codewars.com/kata/53dc54212259ed3d4f00071c/train/javascript

// Sum Numbers
function sum (numbers) {
"use strict";

let count = 0;
for (let i = 0; i < numbers.length; i++)
{
count += numbers[i];
}
return count;
};
