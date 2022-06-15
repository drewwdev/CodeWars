problem: https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
public static string PigIt(string str)
{
List<string> newWords = new List<string>();
foreach (string word in str.Split(' ')){
string firstLetter = word.Substring(0, 1);
if (firstLetter.Any(x => !char.IsLetter(x))){
return string.Join(" ", newWords) + " " + word;
}
string restOfWord = word.Substring(1, word.Length - 1);
int currentLetter = word.IndexOf(firstLetter);
newWords.Add(restOfWord + firstLetter + "ay");
}
return string.Join(" ", newWords);
}
}
