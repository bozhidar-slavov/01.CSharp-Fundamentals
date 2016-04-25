using System;

class WinningNumbers
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int letterSum = 0;
        bool isWinning = false;

        foreach (char symbol in input)
        {
            letterSum += symbol - 'a' + 1;
        }

        for (int digit1 = 1; digit1 <= 9; digit1++)
        {
            for (int digit2 = 1; digit2 <= 9; digit2++)
            {
                for (int digit3 = 1; digit3 <= 9; digit3++)
                {
                    int digitProduct = digit1 * digit2 * digit3;
                    if (digitProduct == letterSum)
                    {
                        for (int digit4 = 1; digit4 <= 9 ; digit4++)
                        {
                            for (int digit5 = 1; digit5 <= 9 ; digit5++)
                            {
                                for (int digit6 = 1; digit6 <= 9 ; digit6++)
                                {
                                    int secondDigitProduct = digit4 * digit5 * digit6;
                                    if (secondDigitProduct == letterSum)
                                    {
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}", digit1, digit2, digit3, digit4, digit5, digit6);
                                        isWinning = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!isWinning)
        {
            Console.WriteLine("No");
        }
    }
}