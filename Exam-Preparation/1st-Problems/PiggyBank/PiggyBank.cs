using System;

class PiggyBank
{
    static void Main()
    {
        int priceOfTank = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int monthSaving = (30 - partyDays) * 2;
        int monthSpending = partyDays * 5;
        int monthAverage = monthSaving - monthSpending;
        int requiredMonths = (int)Math.Ceiling((double)priceOfTank / monthAverage);

        int years = requiredMonths / 12;
        int months = requiredMonths % 12;

        if (monthSpending > monthSaving)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine("{0} years, {1} months", years, months);
        }
        
    }
}