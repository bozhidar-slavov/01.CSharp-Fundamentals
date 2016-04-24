using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] cardFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] cardSuits = { " of spades,", " of clubs,", " of hearts,", " of diamonds" };

        for (int i = 0; i <= Array.IndexOf(cardFaces, input); i++)
        {
            for (int j = 0; j < cardSuits.Length; j++)
            {
                Console.Write(j != cardSuits.Length - 1 ? cardFaces[i] + cardSuits[j] + " " : cardFaces[i] + cardSuits[j] + "\n");
            }
        }
    }
}