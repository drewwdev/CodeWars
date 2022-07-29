problem: https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
public static int[] ArrayDiff(int[] a, int[] b)
{
var aList = a.ToList();
var bList = b.ToList();
var newAList = aList.Where(elementInA => !bList.Contains(elementInA)).ToArray();
return newAList;
}
}
