using System;

class Budget
{
    static void Main()
    {
        int amountOfMoney = int.Parse(Console.ReadLine());
        int weekdaysGoingOut = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());

        int hometownDays = hometownWeekends * 2;
        int normalWeekendDays = 2 * (4 - hometownWeekends);
        int goingOutDays = (30 - hometownDays - normalWeekendDays);
        int normalDays = (goingOutDays - weekdaysGoingOut);

        double weekDaysPrice = weekdaysGoingOut * Math.Floor(((amountOfMoney * 0.03d) + 10));
        double total = weekDaysPrice + (normalWeekendDays * 20) + (normalDays * 10) + 150;

        if (total < amountOfMoney)
        {
            Console.WriteLine("Yes, leftover {0}.",(amountOfMoney - total));
        }
        else if (total > amountOfMoney)
        {
            Console.WriteLine("No, not enough {0}.",(total - amountOfMoney));
        }
        else
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}