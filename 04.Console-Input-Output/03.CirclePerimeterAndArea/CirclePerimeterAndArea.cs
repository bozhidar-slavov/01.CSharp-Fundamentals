using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = Math.PI * 2 * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}