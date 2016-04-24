using System;
using System.Linq;

class GreatestCommonDivisor
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(z => int.Parse(z)).ToArray();
        int x = input[0];
        int y = input[1];

        int remainder = 1;

        while (y != 0)
        {
            remainder = x % y;
            x = y;
            y = remainder;
        }

        Console.WriteLine(Math.Abs(x));
    }
}