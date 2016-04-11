using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);

        if (discriminant > 0)
        {
            Console.WriteLine("{0:F2}", (-b - Math.Sqrt(discriminant)) / (2 * a));
            Console.WriteLine("{0:F2}", (-b + Math.Sqrt(discriminant)) / (2 * a));
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        // discriminant = 0 -> x1,x2 = ...
        else 
        {
            Console.WriteLine("{0:F2}", (-b / (2 * a)));
        }
    }
}