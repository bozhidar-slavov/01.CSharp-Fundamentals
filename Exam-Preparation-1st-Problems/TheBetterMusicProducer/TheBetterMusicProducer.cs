using System;

class TheBetterMusicProducer
{
    static void Main()
    {
        int europeSoldAlbums = int.Parse(Console.ReadLine());
        decimal eurosPrice = decimal.Parse(Console.ReadLine());
        int northAmericaSoldAlbums = int.Parse(Console.ReadLine());
        decimal dollarsPrice = decimal.Parse(Console.ReadLine());
        int southAmericaSoldAlbums = int.Parse(Console.ReadLine());
        decimal pesosPrice = decimal.Parse(Console.ReadLine());
        int numberOfConcerts = int.Parse(Console.ReadLine());
        decimal concertProfitInEuro = decimal.Parse(Console.ReadLine());

        decimal europeProfit = europeSoldAlbums * eurosPrice * 1.94M;
        decimal northAmericaProfit = northAmericaSoldAlbums * dollarsPrice * 1.72M;
        decimal southAmericaProfit = southAmericaSoldAlbums * pesosPrice / 332.74M;

        decimal allAlbumsPrice = ((europeProfit + northAmericaProfit + southAmericaProfit) * 0.65M) * 0.80M;
        decimal concertProfit = numberOfConcerts * concertProfitInEuro * 1.94M;

        if (concertProfit > 100000)
        {
            concertProfit *= 0.85M;
        }

        if (allAlbumsPrice > concertProfit)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", allAlbumsPrice);
        }
        if (concertProfit >= allAlbumsPrice)
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertProfit);
        }
    }
}