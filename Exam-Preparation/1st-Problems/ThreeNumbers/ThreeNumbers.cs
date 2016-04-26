using System;

class ThreeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double biggestNumber = 0;

        if (a >= b && a > c)
        {
            biggestNumber = a;
        }
        else if (b > a && b > c)
        {
            biggestNumber = b;
        }
        else
        {
            biggestNumber = c;
        }

        double smallestNumber = 0;

        if (a <= b && a < c)
        {
            smallestNumber = a;
        }
        else if (b < a && b < c)
        {
            smallestNumber = b;
        }
        else
        {
            smallestNumber = c;
        }

        double arithmeticMean = (a + b + c) / 3;

        Console.WriteLine(biggestNumber);
        Console.WriteLine(smallestNumber);
        Console.WriteLine("{0:F2}", arithmeticMean);
    }
}