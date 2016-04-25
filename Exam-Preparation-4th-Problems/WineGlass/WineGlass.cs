using System;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int asterisk = n - 2;
        int outerDots = 1;

        Console.WriteLine("\\{0}/", new string('*', asterisk));

        asterisk = n - 4;

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('.', outerDots), new string('*', asterisk), new string('.', outerDots));
            outerDots++;
            asterisk -= 2;
        }

        outerDots = n / 2 - 1;

        if (n < 12)
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}||{1}", new string('.', outerDots), new string('.', outerDots));
            }
        }

        if (n >= 12)
        {
            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.WriteLine("{0}||{1}", new string('.', outerDots), new string('.', outerDots));
            }
        }

        if (n < 12)
        {
            Console.WriteLine("{0}", new string('-', n));
        }
        if (n >= 12)
        {
            Console.WriteLine("{0}", new string('-', n));
            Console.WriteLine("{0}", new string('-', n));
        }
    }
}