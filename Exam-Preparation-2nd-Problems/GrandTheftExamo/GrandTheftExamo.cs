using System;

class GrandTheftExamo
{
    static void Main()
    {
        long escapeAtempts = long.Parse(Console.ReadLine());

        long slappedThieves = 0;
        long escapedThieves = 0;
        long sumOfBeers = 0;
        long packOfBeers = 0;
        long remainingBeers = 0;

        for (int i = 0; i < escapeAtempts; i++)
        {
            long numberOfThieves = long.Parse(Console.ReadLine());
            long drunkedBeers = long.Parse(Console.ReadLine());

            if (numberOfThieves <= 5)
            {
                slappedThieves += numberOfThieves;
            }
            else if (numberOfThieves > 5)
            {
                slappedThieves += 5;
                escapedThieves += numberOfThieves - 5;
            }

            sumOfBeers += drunkedBeers;
        }

        if (sumOfBeers > 6)
        {
            packOfBeers = sumOfBeers / 6;
            remainingBeers = sumOfBeers % 6;
        }

        Console.WriteLine("{0} thieves slapped.", slappedThieves);
        Console.WriteLine("{0} thieves escaped.", escapedThieves);

        if (sumOfBeers > 6)
        {
            Console.WriteLine("{0} packs, {1} bottles.", packOfBeers, remainingBeers);
        }
        else if (sumOfBeers < 6)
        {
            Console.WriteLine("0 packs, {0} bottles.", sumOfBeers);
        }
        else if (sumOfBeers == 6)
        {
            Console.WriteLine("1 packs, 0 bottles.");
        }
    }
}