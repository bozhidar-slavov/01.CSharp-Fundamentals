using System;

class KingOfThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbolType = char.Parse(Console.ReadLine());

        int dashes = n / 2;
        int symbolTypeCount = 1;

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string(symbolType, symbolTypeCount), new string('-', dashes));
            dashes--;
            symbolTypeCount += 2;
        }

        symbolTypeCount = n - 2;
        dashes = 1;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string(symbolType, symbolTypeCount), new string('-', dashes));
            dashes ++;
            symbolTypeCount -= 2;
        }
    }
}