using System;

class ChessboardGame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        long blackTeamSum = 0;
        long whiteTeamSum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i >= n * n)
            {
                break;
            }

            if (i % 2 == 0)
            {
                if (Char.IsLower(input[i]) || Char.IsDigit(input[i]))
                {
                    blackTeamSum += input[i];
                }
                else if (Char.IsUpper(input[i]))
                {
                    whiteTeamSum += input[i];
                }
            }
            else
            {
                if (Char.IsLower(input[i]) || Char.IsDigit(input[i]))
                {
                    whiteTeamSum += input[i];
                }
                else if (Char.IsUpper(input[i]))
                {
                    blackTeamSum += input[i];
                }
            }
            
        }

        if (blackTeamSum == whiteTeamSum)
        {
            Console.WriteLine("Equal result: " + blackTeamSum);
        }
        else if (blackTeamSum > whiteTeamSum)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackTeamSum - whiteTeamSum);
        }
        else
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteTeamSum - blackTeamSum);
        }
    }
}