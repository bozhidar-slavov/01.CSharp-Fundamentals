using System;

class Dumbbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n / 2;
        int innerDots = n;
        int ampersands = n / 2 + 1;

        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.',outerDots), new string('&',ampersands), new string('.', innerDots), new string('&',ampersands), new string('.', outerDots));
        int stars = n / 2;
        outerDots = n / 2 - 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', outerDots), new string('*', stars), new string('.', innerDots), new string('*', stars), new string('.', outerDots));
            outerDots--;
            stars++;
        }
        stars = n - 2;
        Console.WriteLine("&{0}&{1}&{0}&", new string('*',stars), new string('=',n), new string('*', stars));

        outerDots = 1;
        stars = n - 3;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', outerDots), new string('*', stars), new string('.', innerDots), new string('*', stars), new string('.', outerDots));
            outerDots++;
            stars--;
        }
        outerDots = n / 2;
        Console.WriteLine("{0}{1}{2}{1}{0}", new string ('.', outerDots), new string('&',ampersands), new string('.', innerDots), new string('&', ampersands), new string('.', outerDots));
    }
}