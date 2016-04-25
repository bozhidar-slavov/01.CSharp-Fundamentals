using System;

class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = n + 1;
        int middleDots = n + 1;
        int asterisk = n - 1;

        Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', asterisk), new string('.', dots));

        dots = n - 1;

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', middleDots), new string('.', dots));
            dots -= 2;
            middleDots += 4;
        }

        middleDots = n * 3 - 3;

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(".*{0}*.", new string('.', middleDots));
        }

        for (int i = 0; i < 1; i++)
        {
            Console.Write(".*");
            for (int j = 1; j <= n * 3 - 3; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("@");
                }
            }
            Console.WriteLine("*.");
        }

        for (int i = 0; i < 1; i++)
        {
            Console.Write(".*");
            for (int j = 1; j <= n * 3 - 3; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine("*.");
        }

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine(".*{0}*.", new string('.', middleDots));
        }

        dots = 3;
        middleDots = n * 3 - 7;

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', middleDots), new string('.', dots));
            dots += 2;
            middleDots -= 4;
        }

        dots = n + 1;

        Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', asterisk), new string('.', dots));
    }
}