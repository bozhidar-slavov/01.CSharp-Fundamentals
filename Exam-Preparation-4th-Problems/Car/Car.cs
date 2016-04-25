using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int asterisk = n;
        int outerDots = n;
        int middleDots = n;

        Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('*', asterisk), new string('.', outerDots));

        outerDots = n - 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', middleDots), new string('.', outerDots));
            outerDots--;
            middleDots += 2;
        }

        asterisk = n / 2 + 1;
        middleDots = n * 2 - 2;

        Console.WriteLine("{0}{1}{0}", new string('*', asterisk), new string('.', middleDots), new string('*', asterisk));

        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', n * 3 - 2));
        }

        Console.WriteLine(new string('*', n * 3));

        outerDots = n / 2;
        middleDots = n / 2 - 1;
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', outerDots), new string('.', middleDots), new string('.', n - 2), new string('.', middleDots), new string('.', outerDots));
        }

        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outerDots), new string('*', asterisk), new string('.', n - 2), new string('*', asterisk), new string('.', outerDots));
    }
}