using System;

class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        int index = y * 3 + x + 1;
        int trueValue = value + index - 1;

        Console.WriteLine((long)Math.Pow(trueValue, index));
    }
}