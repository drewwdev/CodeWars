problem: https://www.codewars.com/kata/526dbd6c8c0eb53254000110/train/csharp

using System;
using System.Linq;

public class Kata
{
public static bool Alphanumeric(string str)
{
if (String.IsNullOrEmpty(str)){
return false;
}
else{
if (str.All(char.IsLetterOrDigit)){
return true;
}
else {
return false;
}
}
}
}
