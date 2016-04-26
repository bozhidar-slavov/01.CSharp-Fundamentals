using System;
using System.Numerics;

class Maslan
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.Remove(input.Length - 1, 1);
        BigInteger product = 1;
        int transformations = 0;
        while (input.Length > 0)
        {
            int oddSum = 0;
            for (int i = 1; i < input.Length; i+=2)
            {
                oddSum += input[i] - 48;
            }

            if (oddSum > 0)
            {
                product *= oddSum;
            }

            input = input.Remove(input.Length - 1, 1);
            if (input.Length == 0)
            {
                input = product.ToString();
                transformations++;
                product = 1;
                if (input.Length == 1)
                {
                    break;
                }

                if (transformations == 10)
                {
                    break;
                }
                input = input.Remove(input.Length - 1, 1);
            }
        }

        if (transformations < 10)
        {
            Console.WriteLine(transformations);
            Console.WriteLine(input);
        }
        else
        {
            Console.WriteLine(input);
        }
    }
}