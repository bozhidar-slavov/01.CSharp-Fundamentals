using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.Remove(input.Length - 1, 1);

        long evenDigitSum = 0;
        BigInteger product = 1;
        int transformations = 1;
        
        while (input.Length > 0)
        {
            for (int i = 0; i < input.Length; i += 2)
            {
                evenDigitSum += input[i] - 48;
            }

            product *= evenDigitSum;
            evenDigitSum = 0;

            input = input.Remove(input.Length - 1, 1);
            if (product > 9 && input.Length == 0)
            {
                transformations++;
                input = product.ToString();
                product = 1;
                input = input.Remove(input.Length - 1, 1);
            }
            else if (transformations == 10)
            {
                break;
            }
        }

        if (transformations < 10)
        {
            Console.WriteLine(transformations);
            Console.WriteLine(product);
        }
        else
        {
            Console.WriteLine(input);
        }
    }
}

/*
using System;
using System.Numerics;

class MagicSadiKopar
{
    static void Main()
    {
        string text = Console.ReadLine();

        int transformations = 0;
        bool transformed = true;
        while (text.Length > 1)
        {
            int sum = 0;
            BigInteger product = 1;
            int position = 0;
            foreach (var symbol in text)
            {
                if (position % 2 == 0)
                {
                    int number = symbol - '0';
                    sum += number;
                }

                product *= sum;
                position++;
            }

            product /= sum;
            transformations++;

            text = product.ToString();

            if (transformations == 10)
            {
                transformed = false;
                break;
            }
        }

        if (transformed)
        {
            Console.WriteLine(transformations);
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine(text);
        }
    }
}
*/