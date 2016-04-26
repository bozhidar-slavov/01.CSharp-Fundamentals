using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outerDots = n - 1;
        int middleDots = 1;
        int asterisk = n - 3;

        Console.WriteLine("{0}*{1}", new string('.', outerDots), new string('.', outerDots));

        outerDots = n - 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}", new string('.', outerDots), new string('.', middleDots), new string('.', outerDots));
            outerDots--;
            middleDots += 2;
        }

        Console.WriteLine("{0}", new string('*', n * 2 - 1));

        middleDots = 2 * n - 3;

        for (int i = 0; i < (n + 1) / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', middleDots));
        }

        outerDots = n / 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("*{0}{1}{2}*", new string('.', outerDots), new string('*', asterisk), new string('.', outerDots));
        }

        middleDots = 2 * n - 3;

        for (int i = 0; i < (n + 1) / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', middleDots));
        }

        Console.WriteLine("{0}", new string('*', n * 2 - 1));
    }
}