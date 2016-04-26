using System;

class TravellerBob
{
    static void Main()
    {
        string typeOfYear = Console.ReadLine();
        double contractMonths = double.Parse(Console.ReadLine());
        double familyMonths = double.Parse(Console.ReadLine());

        double contractMonthsTravels = (4 * 3) * contractMonths;
        double familyMonthsTravels = (2 * 2) * familyMonths;
        double normalMonthsTravels = ((12 - (contractMonths + familyMonths)) * 12) * 0.6d;
        double total = contractMonthsTravels + familyMonthsTravels + normalMonthsTravels;
        double totalLeap = total * 1.05;

        if (typeOfYear == "leap")
        {
            Console.WriteLine((int)Math.Floor(totalLeap));
        }
        else
        {
            Console.WriteLine((int)Math.Floor(total));
        }
    }
}