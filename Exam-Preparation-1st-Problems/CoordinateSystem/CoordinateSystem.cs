﻿using System;

class CoordinateSystem
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine(1);
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine(2);
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine(3);
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine(4);
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine(5);
        }
        else if (y == 0 && x != 0)
        {
            Console.WriteLine(6);
        }
        else // if (x == 0 && y == 0)
        {
            Console.WriteLine(0);
        }
    }
}