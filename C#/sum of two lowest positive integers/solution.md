problem: https://www.codewars.com/kata/558fc85d8fd1938afb000014/train/csharp

using System;
using System.Collections;

public static class Kata
{
public static int sumTwoSmallestNumbers(int[] numbers)
{
Array.Sort(numbers);
int total = numbers[0] + numbers[1];
return total;
}
}
