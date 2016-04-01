using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double r = 2;

        double xSquarePlusYSquare = (x * x) + (y * y);
        bool isInCircle = xSquarePlusYSquare <= (r * r);
        if (isInCircle)
        {
            Console.WriteLine("yes {0:F2}", Math.Sqrt(xSquarePlusYSquare));
        }
        else
        {
            Console.WriteLine("no {0:F2}", Math.Sqrt(xSquarePlusYSquare));
        }
    }
}