// problem: https://www.codewars.com/kata/52223df9e8f98c7aa7000062/train/csharp

using System;

public class Kata
{

    public static char RotateChar(char c)
    {
        if (c >= 'a' && c <= 'z')
        {
            return (char)(((c - 'a' + 13) % 26) + 'a');
        }
        else if (c >= 'A' && c <= 'Z')
        {
            return (char)(((c - 'A' + 13) % 26) + 'A');
        }
        else
        {
            return c;
        }
    }

    static string RotateString(string stringToRotate)
    {
        char[] characters = stringToRotate.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            characters[i] = RotateChar(characters[i]);
        }

        return new string(characters);
    }

    public static string Rot13(string input)
    {

        return RotateString(input);

    }
}