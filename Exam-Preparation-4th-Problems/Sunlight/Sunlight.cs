using System;

class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int asterisk = n;
        int uniqueLineDots = (n * 3 - 1) / 2;

        Console.WriteLine("{0}*{0}", new string('.', uniqueLineDots), new string('.', uniqueLineDots));

        int outerDots = 1;
        int innerDots = (n * 3 - 4) / 2;

        for (int i = 0; i < (n * 3 - 1) / 3; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerDots), new string('.', innerDots), new string('.', innerDots), new string('.', outerDots));
            outerDots++;
            innerDots--;
        }
       
        outerDots = n;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('*', asterisk), new string('.', outerDots));
        }
        asterisk = n * 3;
        Console.WriteLine("{0}", new string('*', asterisk));

        asterisk = n;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('*', asterisk), new string('.', outerDots));
        }

        outerDots = n - 1;
        innerDots = n / 2;

        for (int i = 0; i < (n * 3 - 1) / 3; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerDots), new string('.', innerDots), new string('.', innerDots), new string('.', outerDots));
            outerDots--;
            innerDots++;
        }

       Console.WriteLine("{0}*{0}", new string('.', uniqueLineDots), new string('.', uniqueLineDots));
    }
}