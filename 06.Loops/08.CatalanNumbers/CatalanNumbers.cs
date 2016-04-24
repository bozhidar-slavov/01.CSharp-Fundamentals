using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        BigInteger denumerator = 1;
     
        for (int i = n + 2; i <= 2 * n; i++)
        {
            numerator *= i;
        }

        for (int i = 1; i <= n; i++)
        {
            denumerator *= i;
        }

        BigInteger sum = numerator / denumerator;
        Console.WriteLine(sum);
    }
}