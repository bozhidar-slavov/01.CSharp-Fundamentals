using System;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] c = new int[11];
        for (int i = 1; i <= n; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            c[vote]++;
        }

        int bestCat = 0;
        int bestCatVotes = 0;
        for (int i = 1; i <= 10; i++)
        {
            if (c[i] >= bestCatVotes)
            {
                bestCat = i;
                bestCatVotes = c[i];
            }
        }

        Console.WriteLine(bestCat);
    }
}