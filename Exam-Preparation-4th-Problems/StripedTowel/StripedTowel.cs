using System;

class StripedTowel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n;
        int height = n + n / 2;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if ((j + i) % 3 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}