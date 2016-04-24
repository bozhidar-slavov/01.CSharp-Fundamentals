using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = k + 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}