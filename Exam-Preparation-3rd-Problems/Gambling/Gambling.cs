using System;

class Gambling
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string[] houseHand = Console.ReadLine().Split();

        int housesStrenght = 0;

        foreach (var card in houseHand)
        {
            switch (card)
            {
                case "2": housesStrenght += 2; break;
                case "3": housesStrenght += 3; break;
                case "4": housesStrenght += 4; break;
                case "5": housesStrenght += 5; break;
                case "6": housesStrenght += 6; break;
                case "7": housesStrenght += 7; break;
                case "8": housesStrenght += 8; break;
                case "9": housesStrenght += 9; break;
                case "10": housesStrenght += 10; break;
                case "J": housesStrenght += 11; break;
                case "Q": housesStrenght += 12; break;
                case "K": housesStrenght += 13; break;
                case "A": housesStrenght += 14; break;
            }
        }

        int countWinning = 0;
        int totalHands = 0;

        for (int card1 = 2; card1 <= 14; card1++)
        {
            for (int card2 = 2; card2 <= 14; card2++)
            {
                for (int card3 = 2; card3 <= 14; card3++)
                {
                    for (int card4 = 2; card4 <= 14; card4++)
                    {
                        int cardStrenght = card1 + card2 + card3 + card4;

                        if (cardStrenght > housesStrenght)
                        {
                            countWinning++;
                        }
                        totalHands++;
                    }
                }
            }
        }

        decimal probability = (decimal)countWinning / totalHands;

        if (probability < 0.5M)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }

        decimal expectedWinnings = probability * 2 * cash;

        Console.WriteLine("{0:F2}", expectedWinnings);
    }
}