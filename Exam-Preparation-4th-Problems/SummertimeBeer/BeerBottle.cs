using System;

class BeerBottle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int asterisk = n + 1;
        int whitespaces = n / 2;
        int innerWhitespaces = n - 1;
        int innerDots = n * 2 - 2;
        int emailSign = n * 2 - 2;

        Console.WriteLine("{0}{1}", new string(' ', whitespaces), new string('*', asterisk), new string(' ', whitespaces));

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*", new string(' ', whitespaces), new string(' ', innerWhitespaces));
        }

        whitespaces = n / 2 - 1;
        innerWhitespaces = n + 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*", new string(' ', whitespaces), new string(' ', innerWhitespaces));
            innerWhitespaces += 2;
            whitespaces--;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('.', innerDots));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('@', emailSign));
        }

        asterisk = 2 * n;
        Console.WriteLine("{0}", new string('*', asterisk));

    }
}