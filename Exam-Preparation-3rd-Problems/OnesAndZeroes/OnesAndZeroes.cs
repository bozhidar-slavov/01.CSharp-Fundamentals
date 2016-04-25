using System;

class OnesAndZeroes
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2).PadLeft(32, '0');

        string[] zero = {"###",
                         "#.#",
                         "#.#",
                         "#.#",
                         "###" };

        string[] one = { ".#.",
                         "##.",
                         ".#.",
                         ".#.",
                         "###" };

        for (int row = 0; row < 5; row++)
        {
            for (int i = 16; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    Console.Write(one[row]);
                }
                else
                {
                    Console.Write(zero[row]);
                }

                if (i != binary.Length - 1)
                {
                    Console.Write('.');
                }
            }

            Console.WriteLine();
        }
    }
}