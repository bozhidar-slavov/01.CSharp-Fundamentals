using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check a bit at position: ");
        int position = int.Parse(Console.ReadLine());

        int moveBit = number >> position;
        int foundBit = moveBit & 1;

        bool isOne = foundBit == 1;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("Bit of position {0} is '1' = {1}", position, isOne);
    }
}