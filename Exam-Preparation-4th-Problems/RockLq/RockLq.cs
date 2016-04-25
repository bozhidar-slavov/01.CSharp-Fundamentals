using System;

class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outerDots = n;
        int asterisk = n;
        int middleDots = n + 2;
        int innerDots = 1;

        Console.Write(new string('.', outerDots));
        Console.Write(new string('*', asterisk));
        Console.WriteLine(new string('.', outerDots));

        outerDots = n - 2;
        
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write("*");
            Console.Write(new string('.', middleDots));
            Console.Write("*");
            Console.WriteLine(new string('.', outerDots));

            middleDots += 4;
            outerDots -= 2;
        }

        middleDots = n;
        outerDots = n - 2;

        Console.Write('*');
        Console.Write(new string('.', outerDots));
        Console.Write('*');
        Console.Write(new string('.', middleDots));
        Console.Write('*');
        Console.Write(new string('.', outerDots));
        Console.WriteLine('*');

        
        for (int i = 0; i < n / 2 - 1; i++)
        {
            outerDots -= 2;
            Console.Write('*');
            Console.Write(new string('.', outerDots));
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.Write(new string('.', middleDots));
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.Write(new string('.', outerDots));
            Console.WriteLine('*');

            innerDots += 2;
        }

        outerDots = n - 1;
        middleDots = n;
        for (int i = 0; i < n - 1; i++)
        {
            
            Console.Write(new string('.', outerDots));
            Console.Write('*');
            Console.Write(new string('.', middleDots));
            Console.Write('*');
            Console.WriteLine(new string('.', outerDots));
            outerDots--;
            middleDots += 2;
        }

        Console.WriteLine(new string('*', 3 * n));
    }
}