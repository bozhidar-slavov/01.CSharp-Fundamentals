using System;
using System.Numerics;

class Secrets
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        int specialSum = 0;
        BigInteger number = n;

        if (number < 0)
        {
            number *= -1;
        }
        int position = 1;

        while (number > 0)
        {
            int digit = (int)(number % 10);
            number /= 10;

            if (position % 2 == 0)
            {
                specialSum += digit * digit * position;
            }
            else
            {
                specialSum += digit * position * position;
            }
            ++position;
        }

        Console.WriteLine(specialSum);

        int sequenceLenght = specialSum % 10; ;
        if (sequenceLenght == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
        else
        {
            int start = specialSum % 26;
            for (int i = 0; i < sequenceLenght; i++)
            {
                Console.Write((char)('A' + (start + i) % 26));
            }
        }
        Console.WriteLine();
    }
}