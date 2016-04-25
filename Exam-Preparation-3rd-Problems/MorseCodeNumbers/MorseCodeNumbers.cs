using System;
using System.Collections.Generic;

class MorseCodeNumbers
{
    static void Main()
    {
        Dictionary<int, string> morseEncoding = new Dictionary<int, string>
        {
            {1, ".----"},
            {2, "..---"},
            {3, "...--"},
            {4, "....-"},
            {5, "....."}
        };
        int n = int.Parse(Console.ReadLine());
        int nSum = 0;
        bool hasAnswer = false;

        while (n != 0)
        {
            // Getting the last digit
            int remainder = n % 10;
            // Summing up the digits
            nSum += remainder;
            // Removing the last digit
            n /= 10;
        }

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 1; k <= 5; k++)
                {
                    for (int l = 1; l <= 5; l++)
                    {
                        for (int m = 1; m <= 5; m++)
                        {
                            for (int o = 1; o <= 5; o++)
                            {
                                int product = i * j * k * l * m * o;
                                if (product == nSum)
                                {
                                    Console.WriteLine(morseEncoding[i] + '|' + 
                                                    morseEncoding[j] + '|' +
                                                    morseEncoding[k] + '|' +
                                                    morseEncoding[l] + '|' +
                                                    morseEncoding[m] + '|' +
                                                    morseEncoding[o] + '|');
                                    hasAnswer = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!hasAnswer)
        {
            Console.WriteLine("No");
        }
    }
}