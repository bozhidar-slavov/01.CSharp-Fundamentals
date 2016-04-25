using System;

class DreamItem
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        decimal hoursPerDay = decimal.Parse(input[2]);
        decimal itemPrice = decimal.Parse(input[3]);
        decimal salary = 0;
        int holidays = 10;
        int monthDays = 0;

        switch (month)
        {
            case "Feb": monthDays = 28; break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov": monthDays = 30; break;
            default: monthDays = 31; break;
        }

        salary = (monthDays - holidays) * moneyPerHour * hoursPerDay;
        
        if (salary > 700M)
        {
            salary *= 1.1M;
        }

        if (salary >= itemPrice)
        {
            Console.WriteLine("Money left = {0:F2} leva.", salary - itemPrice);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - salary);
        }
    }
}