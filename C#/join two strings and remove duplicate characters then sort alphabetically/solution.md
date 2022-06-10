problem: https://www.codewars.com/kata/5656b6906de340bd1b0000ac/train/csharp

using System;
using System.Collections.Generic;
using System.Linq;

public class TwoToOne
{

    public static string Longest (string s1, string s2)

{
string s3 = s1 + s2;
string newString = string.Join("", s3.ToCharArray().Distinct().OrderBy(c => c));
return newString;
}
}
