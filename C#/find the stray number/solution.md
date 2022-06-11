problem: https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
public static int Stray(int[] numbers)
{
Array.Sort(numbers);
if (numbers[0] == numbers[1]){
return numbers.Last();
}  
 return numbers[0];
}
}
