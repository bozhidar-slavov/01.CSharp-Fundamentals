using System;

class CompoundInterest
{
    static void Main()
    {
        double priceOfTv = double.Parse(Console.ReadLine());
        int numberOfYears = int.Parse(Console.ReadLine());
        double bankInterest = double.Parse(Console.ReadLine());
        double friendInterest = double.Parse(Console.ReadLine());

        double bankFormula = 1 + bankInterest;
        double bankLoan = priceOfTv * Math.Pow(bankFormula, numberOfYears);
        double friendLoan = priceOfTv * (1 + friendInterest);

        if (bankLoan < friendLoan)
        {
            Console.WriteLine("{0:F2} Bank", bankLoan);
        }
        else
        {
            Console.WriteLine("{0:F2} Friend", friendLoan);
        }
    }
}