using System;

class PlaidTowel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char backGroundSymbol = char.Parse(Console.ReadLine());
        char rhombusSymbol = char.Parse(Console.ReadLine());

        int outerSymbols = backGroundSymbol;
        int innerSymbols = rhombusSymbol;
        int middleSymbols = backGroundSymbol;

        Console.Write(new string(backGroundSymbol, n));
        Console.Write(new string(rhombusSymbol, 1));
        Console.Write(new string(backGroundSymbol, n * 2 - 1));
        Console.Write(new string(rhombusSymbol, 1));
        Console.WriteLine(new string(backGroundSymbol, n));

        outerSymbols = n - 1;
        innerSymbols = 1;
        middleSymbols = n * 2 - 3;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(backGroundSymbol, outerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, innerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, middleSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, innerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.WriteLine(new string(backGroundSymbol, outerSymbols));

            outerSymbols--;
            innerSymbols += 2;
            middleSymbols -= 2;
        }
        middleSymbols = n * 2 - 1;

        Console.Write(new string(rhombusSymbol, 1));
        Console.Write(new string(backGroundSymbol, middleSymbols));
        Console.Write(new string(rhombusSymbol, 1));
        Console.Write(new string(backGroundSymbol, middleSymbols));
        Console.WriteLine(new string(rhombusSymbol, 1));

        outerSymbols = 1;
        middleSymbols = n * 2 - 3;
        innerSymbols = 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(backGroundSymbol, outerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, middleSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, innerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, middleSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.WriteLine(new string(backGroundSymbol, outerSymbols));
            outerSymbols++;
            middleSymbols -= 2;
            innerSymbols += 2;
        }

        outerSymbols = n;
        middleSymbols = n * 2 - 1;

        Console.Write(new string(backGroundSymbol, outerSymbols));
        Console.Write(new string(rhombusSymbol, 1));
        Console.Write(new string(backGroundSymbol, middleSymbols));
        Console.Write(new string(rhombusSymbol, 1));
        Console.WriteLine(new string(backGroundSymbol, outerSymbols));

        outerSymbols = n - 1;
        innerSymbols = 1;
        middleSymbols = n * 2 - 3;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(backGroundSymbol, outerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, innerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, middleSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, innerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.WriteLine(new string(backGroundSymbol, outerSymbols));

            outerSymbols--;
            innerSymbols += 2;
            middleSymbols -= 2;
        }
        middleSymbols = n * 2 - 1;

        Console.Write(new string(rhombusSymbol, 1));
        Console.Write(new string(backGroundSymbol, middleSymbols));
        Console.Write(new string(rhombusSymbol, 1));
        Console.Write(new string(backGroundSymbol, middleSymbols));
        Console.WriteLine(new string(rhombusSymbol, 1));

        outerSymbols = 1;
        middleSymbols = n * 2 - 3;
        innerSymbols = 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(backGroundSymbol, outerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, middleSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, innerSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.Write(new string(backGroundSymbol, middleSymbols));
            Console.Write(new string(rhombusSymbol, 1));
            Console.WriteLine(new string(backGroundSymbol, outerSymbols));
            outerSymbols++;
            middleSymbols -= 2;
            innerSymbols += 2;
        }

        outerSymbols = n;
        middleSymbols = n * 2 - 1;

        Console.Write(new string(backGroundSymbol, outerSymbols));
        Console.Write(new string(rhombusSymbol, 1));
        Console.Write(new string(backGroundSymbol, middleSymbols));
        Console.Write(new string(rhombusSymbol, 1));
        Console.WriteLine(new string(backGroundSymbol, outerSymbols));
    }
}