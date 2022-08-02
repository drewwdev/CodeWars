problem: https://www.codewars.com/kata/5266876b8f4bf2da9b000362/train/csharp

using System;

public static class Kata
{
public static string Likes(string[] names)
{
int nameLength = names.Length;
int others = names.Length - 2;

    switch (nameLength)
      {
        case 0:
          return "no one likes this";
        case 1:
          return names[0] + " likes this";
        case 2:
          return names[0] + " and " + names[1] + " like this";
        case 3:
          return names[0] + ", " + names[1] + " and " + names[2] + " like this";
        case >= 4:
          return names[0] + ", " + names[1] + " and " + others + " others like this";
        default:
          return "no one likes this";
      }

}
}
