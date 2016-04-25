using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dashes = n / 2;
        int asterisk = 1;

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', asterisk), new string('-', dashes));
            asterisk += 2;
            dashes--;
        }

        asterisk = n - 2;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|{0}|", new string('*', asterisk));
        }
    }
}