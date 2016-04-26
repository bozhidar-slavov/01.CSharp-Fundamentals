using System;

class TwoFourEight
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long result = 0;

        if (b == 2)
        {
            result = a % c;
        }
        else if (b == 4)
        {
            result = a + c;
        }
        else // if (b == 8)
        {
            result = a * c;
        }

        if (result % 4 == 0)
        {
            Console.WriteLine(result / 4);
        }
        else // if (result % 4 != 0)
        {
            Console.WriteLine(result % 4);
        }

        Console.WriteLine(result);
    }
}