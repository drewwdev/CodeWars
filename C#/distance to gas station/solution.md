problem: https://www.codewars.com/kata/5861d28f124b35723e00005e/train/csharp

using System;

public static class Kata
{
public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
{
if (distanceToPump <= mpg \* fuelLeft){
return true;
}
return false;
}
}
