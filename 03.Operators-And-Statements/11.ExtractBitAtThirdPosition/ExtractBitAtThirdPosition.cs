using System;

class ExtractBitAtThirdPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = 1 << position;
        int result = number & mask;
        int bit = result >> position;
        
        Console.WriteLine(bit);
    }
}