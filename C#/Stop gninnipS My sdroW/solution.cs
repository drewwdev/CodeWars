// problem: https://www.codewars.com/kata/5264d2b162488dc400000001/train/csharp

using System;
using System.Text;

public class Kata
{

    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string ProcessWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            if (word.Length >= 5)
            {
                string reversedWord = ReverseString(word);
                result.Append(reversedWord).Append(" ");
            }
            else
            {
                result.Append(word).Append(" ");
            }
        }

        return result.ToString().Trim();
    }


    public static string SpinWords(string sentence)
    {
        return ProcessWords(sentence);
    }
}