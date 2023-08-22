// problem: https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp

public class Kata
{
    public static int[] MoveZeroes(int[] numbers)
    {
        int nonZeroIndex = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != 0)
            {
                int temp = numbers[i];
                numbers[i] = numbers[nonZeroIndex];
                numbers[nonZeroIndex] = temp;

                nonZeroIndex++;
            }
        }
        return numbers;
    }
}