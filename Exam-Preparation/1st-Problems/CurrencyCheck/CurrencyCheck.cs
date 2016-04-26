using System;

class CurrencyCheck
{
    static void Main()
    {
        decimal rubles = decimal.Parse(Console.ReadLine());
        decimal dollars = decimal.Parse(Console.ReadLine());
        decimal euros = decimal.Parse(Console.ReadLine());
        decimal bLeva = decimal.Parse(Console.ReadLine());
        decimal mLeva = decimal.Parse(Console.ReadLine());

        decimal rublesConvert = (rubles / 100M) * 3.5M;
        decimal dollarsConvert = dollars * 1.5M;
        decimal eurosConvert = euros * 1.95M;
        decimal levaForTwoGames = bLeva / 2M;

        if (rublesConvert < dollarsConvert && rublesConvert < eurosConvert && rublesConvert < levaForTwoGames && rublesConvert < mLeva)
        {
            Console.WriteLine("{0:F2}", rublesConvert);
        }
        else if (dollarsConvert < rublesConvert && dollarsConvert < eurosConvert && dollarsConvert < levaForTwoGames && dollarsConvert < mLeva)
        {
            Console.WriteLine("{0:F2}", dollarsConvert);
        }
        else if (eurosConvert < rublesConvert && eurosConvert < dollarsConvert && eurosConvert < levaForTwoGames && eurosConvert < mLeva)
        {
            Console.WriteLine("{0:F2}", eurosConvert);
        }
        else if (levaForTwoGames < rublesConvert && levaForTwoGames < dollarsConvert && levaForTwoGames < eurosConvert && levaForTwoGames < mLeva)
        {
            Console.WriteLine("{0:F2}", levaForTwoGames);
        }
        else
        {
            Console.WriteLine("{0:F2}", mLeva);
        }
    }
}