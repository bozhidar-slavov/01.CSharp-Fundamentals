using System;
using System.Linq;

class BabaTincheAirlines
{
    static void Main()
    {
        int[] firstClass = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
        int[] businessClass = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
        int[] economyClass = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

        int firstClassPrice = 7000;
        int businessClassPrice = 3500;
        int economyClassPrice = 1000;
        decimal maxProfit = ((firstClassPrice * 12) + (businessClassPrice * 28) + (economyClassPrice * 50)) * 1.005M;

        decimal firstClassProfit = (firstClass[0] - firstClass[1]) * firstClassPrice + (firstClass[1] * firstClassPrice * 0.3M) + (firstClass[2] * firstClassPrice * 0.005M);
        decimal businessClassProfit = (businessClass[0] - businessClass[1]) * businessClassPrice + (businessClass[1] * businessClassPrice * 0.3M) + (businessClass[2] * businessClassPrice * 0.005M);
        decimal economyClassProfit = (economyClass[0] - economyClass[1]) * economyClassPrice + (economyClass[1] * economyClassPrice * 0.3M) + (economyClass[2] * economyClassPrice * 0.005M);

        decimal profit = (firstClassProfit + businessClassProfit + economyClassProfit);

        Console.WriteLine("{0:F0}", Math.Floor(profit));
        Console.WriteLine("{0:F0}", maxProfit - profit);
    }
}