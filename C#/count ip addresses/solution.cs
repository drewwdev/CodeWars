// problem: https://www.codewars.com/kata/526989a41034285187000de4/train/csharp

using System;
public class CountIPAddresses
{
    public static long IpsBetween(string start, string end)
    {
        string[] startParts = start.Split('.');
        string[] endParts = end.Split('.');

        long result = 0;

        for (int i = 0; i < 4; i++)
        {
            long startPart = long.Parse(startParts[i]);
            long endPart = long.Parse(endParts[i]);

            result += (endPart - startPart) * (long)Math.Pow(256, 3 - i);
        }

        return result;
    }
}