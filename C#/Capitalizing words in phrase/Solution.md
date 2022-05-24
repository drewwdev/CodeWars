Problem: https://www.codewars.com/kata/5390bac347d09b7da40006f6/train/csharp

using System;
using System.Globalization;

public static class JadenCase
{
public static string ToJadenCase(this string phrase)
{
return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase.ToLower());
}
}
