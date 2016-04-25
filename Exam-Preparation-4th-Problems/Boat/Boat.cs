using System;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int asterisk = 1;
        int dots = n;
        int boatDots = n - 1;
        

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', boatDots), new string('*', asterisk), new string('.', dots));
            boatDots -= 2;
            asterisk += 2;
        }

        boatDots = 2;
        asterisk = n - 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', boatDots), new string('*', asterisk), new string('.', dots));
            boatDots += 2;
            asterisk -= 2;
        }

        Console.WriteLine("{0}", new string('*', n * 2));

        dots = 1;
        asterisk = n * 2 - 2;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', asterisk), new string('.', dots));
            dots++;
            asterisk -= 2;
        }
    }
}