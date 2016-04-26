using System;

class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outerDots = (3 * n + 2) / 2 ;
        int innerDots = 1;
        int asterisk = n;

        Console.WriteLine("{0}*{0}", new string('.', outerDots), new string('.', outerDots));

        outerDots -= 1;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots), new string('.', outerDots));
            outerDots--;
            innerDots += 2;
        }
        innerDots = n + 2;
        Console.WriteLine("{0}{1}{0}", new string('*', asterisk), new string('.', innerDots), new string('*', asterisk));

        outerDots = 1;
        innerDots = n * 3 - 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots), new string('.', outerDots));
            outerDots++;
            innerDots-= 2;
        }
        outerDots = n / 2 - 1;
        int secondOuter = n / 2;
        int innerDot = 0;
        innerDots = n;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', outerDots), new string('.', secondOuter), new string('.', innerDot),
                new string('.', innerDots), new string('.', innerDot), new string ('.', secondOuter), new string('.', outerDots));
            outerDots--;
            innerDot++;
        }
        asterisk = n / 2 + 1;
        secondOuter = n / 2;
        Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', asterisk), new string('.', secondOuter), new string('.', innerDots), new string('.', secondOuter), new string('*', asterisk));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string('.', innerDots), new string('.', innerDots), new string('.', innerDots));
        }
        int innerAsteriks = n;
        Console.WriteLine("{0}*{1}*{0}", new string('.', innerDots), new string('*', innerAsteriks), new string('.', innerDots));
    }
}