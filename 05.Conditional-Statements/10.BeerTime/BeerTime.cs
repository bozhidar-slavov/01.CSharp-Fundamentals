using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time hh:mm AM/PM: ");
        DateTime beerTime = DateTime.Parse(Console.ReadLine());

        if (beerTime.Hour < 13 && beerTime.Hour >= 3)
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("beer time");
        }
    }
}