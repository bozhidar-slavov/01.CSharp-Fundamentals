using System;
using System.Numerics;

class CalculateCombinations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        BigInteger denumerator = 1;

        for (int i = k + 1; i <= n; i++)
        {
            numerator *= i;
        }

        for (int i = 1; i <= n - k; i++)
        {
            denumerator *= i;
        }
        
        BigInteger result = (numerator / denumerator);
        Console.WriteLine(result);
    }
}