using System;

class Headphones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outerDashes = n / 2;
        int stars = n + 2;
        int innerDashes = n;

        Console.WriteLine("{0}{1}{0}", new string('-',outerDashes), new string('*',stars), new string('-', outerDashes));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', innerDashes), new string('-', outerDashes));
        }
        innerDashes = n - 2;
        outerDashes = n / 2 - 1;
        stars = 3;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-',outerDashes), new string('*', stars), new string('-', innerDashes), new string('*', stars), new string('-', outerDashes));
            outerDashes--;
            stars += 2;
            innerDashes -= 2;
        }
        outerDashes = 1;
        stars = n - 2;
        innerDashes = 3;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outerDashes), new string('*', stars), new string('-', innerDashes), new string('*', stars), new string('-', outerDashes));
            outerDashes++;
            stars -= 2;
            innerDashes += 2;
        }
    }
}