problem: https://www.codewars.com/kata/57eae65a4321032ce000002d/train/csharp

using System;

public class Kata
{
public static string FakeBin(string x)
{
x = x.Replace("1", "0").Replace("2", "0").Replace("3", "0").Replace("4", "0").Replace("5", "1").Replace("6", "1").Replace("7", "1").Replace("8", "1").Replace("9", "1");
return x;
}
}
