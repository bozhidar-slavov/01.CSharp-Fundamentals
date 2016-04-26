using System;

class TorrentPirate
{
    static void Main()
    {
        double megabytesToDownload = double.Parse(Console.ReadLine());
        double cinemaMoney = double.Parse(Console.ReadLine());
        double wifeMoneySpending = double.Parse(Console.ReadLine());

        double downloadTime = (megabytesToDownload) / 2 / 60 / 60;
        double priceForDownload = downloadTime * wifeMoneySpending;
        double numbersOfMovies = (megabytesToDownload) / 1500;
        double cinemaPrice = numbersOfMovies * cinemaMoney;

        if (cinemaPrice < priceForDownload)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:F2}lv", priceForDownload);
        }
    }
}