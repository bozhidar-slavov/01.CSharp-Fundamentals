using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int middleDots = 1;
        int outerDots = n - 1;
        int asterisk = n / 2 + 1;
        int innerDots = 1;

        Console.WriteLine("{0}*{0}", new string('.', n), new string('.', n));

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', middleDots), new string('.', outerDots));
            middleDots += 2;
            outerDots--;
        }

        outerDots = n - 1;
        Console.WriteLine("{0}{1}{0}", new string('*', asterisk), new string('.', middleDots), new string('*', asterisk));

        outerDots = 1;
        middleDots = (2 * n + 1) - 4;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', middleDots), new string('.', outerDots));
            outerDots++;
            middleDots -= 2;
        }
        outerDots = n / 2;
        middleDots = n / 2 - 1;
        Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerDots), new string('.', middleDots), new string('.', middleDots), new string('.', outerDots));

        outerDots = n / 2 - 1;
        middleDots = n / 2 - 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', outerDots), new string('.', middleDots), new string('.', innerDots), new string('.', middleDots), new string('.', outerDots));
            outerDots--;
            innerDots += 2;
        }

        middleDots = n - 1;
        Console.WriteLine("{0}{1}{0}", new string('*', asterisk), new string('.', middleDots), new string('*', asterisk));
    }
}