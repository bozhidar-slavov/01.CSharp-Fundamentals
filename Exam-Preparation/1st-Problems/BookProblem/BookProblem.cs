using System;

class BookProblem
{
    static void Main()
    {
        int pages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int readenPages = int.Parse(Console.ReadLine());

        if (campingDays == 30 || readenPages == 0)
        {
            Console.WriteLine("never");
            return;
        }

        int readenPagesForADay = (30 - campingDays) * readenPages;
        int requiredMonths = (int)Math.Ceiling((double)pages / readenPagesForADay);

        int years = requiredMonths / 12;
        int months = requiredMonths % 12;

        Console.WriteLine("{0} years {1} months", years, months);
    }
}