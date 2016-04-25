using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outerDots = n / 2;
        int hashes = n;
        int middleDots = n - 2;

        Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('#', hashes), new string('.', outerDots));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', outerDots), new string('.', middleDots), new string('.', outerDots));
        }

        hashes = n / 2 + 1;

        Console.WriteLine("{0}{1}{0}", new string('#', hashes), new string('.', middleDots), new string('#', hashes));

        if (n == 3)
        {
            outerDots = 1;
            middleDots = n - 2;
            Console.WriteLine("{0}#{1}#{0}", new string('.', outerDots), new string('.', middleDots), new string('.', outerDots));
        }
        else
        {
            outerDots = 1;
            middleDots = n * 2 - 5;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', outerDots), new string('.', middleDots), new string('.', outerDots));
                outerDots++;
                middleDots -= 2;
            }
        }

        outerDots = n - 1;

        Console.WriteLine("{0}#{0}", new string('.', outerDots), new string('.', outerDots));
    }
}