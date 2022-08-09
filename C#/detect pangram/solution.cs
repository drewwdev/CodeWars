// problem: https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp

using System;
using System.Linq;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    return str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
  }
}