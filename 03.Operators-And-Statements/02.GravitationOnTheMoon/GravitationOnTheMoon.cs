using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double weightOnTheMoon = weight * 0.17;

        Console.WriteLine("{0:F3}", weightOnTheMoon);
    }
}