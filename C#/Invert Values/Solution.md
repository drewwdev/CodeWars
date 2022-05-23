Problem: https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad/train/csharp

using System.Linq;
namespace Solution
{
public static class ArraysInversion
{
public static int[] InvertValues(int[] input)
{
int[] inverseInput = input.Select(i => i \* -1).ToArray();
return inverseInput;
}
}
}
