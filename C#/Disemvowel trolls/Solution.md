Problem: https://www.codewars.com/kata/52fba66badcd10859f00097e/train/csharp

using System;

public static class Kata
{
public static string Disemvowel(string str)
{
var vowels = new string[] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U"};
foreach (var x in vowels){
str = str.Replace(x, string.Empty);
}

        return str;
    }

}
