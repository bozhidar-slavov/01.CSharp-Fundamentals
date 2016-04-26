using System;

class BasketBattle
{
    static void Main()
    {
        string firstPlayerName = Console.ReadLine();
        int rounds = int.Parse(Console.ReadLine());

        string secondPlayerName = firstPlayerName == "Nakov" ? "Simeon" : "Nakov";
        int firstPlayerPoints = 0;
        int secondPlayerPoints = 0;
        int winningRound = 0;
        string winner = string.Empty;
        int looserPoints = 0;
        int lessPoints = 0;
        bool isReaching500 = false;

        for (int i = 0; i < rounds; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                int points = int.Parse(Console.ReadLine());
                string attemptResult = Console.ReadLine().Trim();

                if (attemptResult == "success" && j == 0 && i % 2 == 0)
                {
                    if (firstPlayerPoints + points <= 500)
                    {
                        firstPlayerPoints += points;
                    }
                   
                }
                else if (attemptResult == "success" && j == 1 && i % 2 != 0)
                {
                    if (firstPlayerPoints + points <= 500)
                    {
                        firstPlayerPoints += points;
                    }
                   
                }
                else if (attemptResult == "success" && j == 0 && i % 2 != 0)
                {
                    if (secondPlayerPoints + points <= 500)
                    {
                        secondPlayerPoints += points;
                    }
                    
                }
                else if (attemptResult == "success" && j == 1 && i % 2 == 0)
                {
                    if (secondPlayerPoints + points <= 500)
                    {
                        secondPlayerPoints += points;
                    }
                }
            }

            winningRound++;
            
            if (firstPlayerPoints == 500 || secondPlayerPoints == 500)
            {
                isReaching500 = true;
                break;
            }
        }

        winner = firstPlayerPoints > secondPlayerPoints ? firstPlayerName : secondPlayerName;
        looserPoints = Math.Abs(firstPlayerPoints - secondPlayerPoints);
        lessPoints = Math.Min(firstPlayerPoints, secondPlayerPoints);
        if (firstPlayerPoints != secondPlayerPoints && isReaching500)
        {
            Console.WriteLine(winner);
            Console.WriteLine(winningRound);
            Console.WriteLine(lessPoints);
        }
        else if (firstPlayerPoints != secondPlayerPoints && !isReaching500)
        {
            Console.WriteLine(winner);
            Console.WriteLine(looserPoints);
        }
        else if (firstPlayerPoints == secondPlayerPoints)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(firstPlayerPoints);
        }
    }
}