Problem: https://www.codewars.com/kata/56541980fa08ab47a0000040/train/csharp

using System;
using System.Linq;

public class Printer
{
public static string PrinterError(String s)
{
string errorLetters = "nopqrstuvwxyz";
int errorLettersCount = s.Count(x => errorLetters.Contains(x));
s.ToCharArray();
int count = s.Length;
return errorLettersCount + "/" + count;
}
}
