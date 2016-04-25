using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int asterisk = n * 2;
        int whitespaces = n;
        int slashes = n * 2 - 2;
        int middleSymbols = n;

        Console.WriteLine("{0}{1}{0}", new string('*', asterisk), new string(' ', whitespaces), new string('*', asterisk));

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', slashes), new string(' ', whitespaces), new string('/', slashes));
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('/', slashes), new string('|', middleSymbols), new string('/', slashes));

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', slashes), new string(' ', whitespaces), new string('/', slashes));
        }

        Console.WriteLine("{0}{1}{0}", new string('*', asterisk), new string(' ', whitespaces), new string('*', asterisk));
    }
}