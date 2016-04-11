using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        int members = int.Parse(Console.ReadLine());
        BigInteger firstPrevious = -1;
        BigInteger secondPreviuos = 1;
        BigInteger sum = 0;

        for (int i = 0; i < members; i++)
        {
            sum = firstPrevious + secondPreviuos;
            if (i != members - 1)
            {
                Console.Write(sum + ", ");
            }
            else
            {
                Console.WriteLine(sum);
            }

            firstPrevious = secondPreviuos;
            secondPreviuos = sum;
        }
    }
}