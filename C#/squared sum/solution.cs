// problem: https://www.codewars.com/kata/515e271a311df0350d00000f/train/csharp

public static class Kata
{
  public static int SquareSum(int[] numbers)
  {
    int total = 0;

        foreach (int number in numbers)
          {
            int squared = number * number;
            total += squared;
          }

        return total;

  }
}
