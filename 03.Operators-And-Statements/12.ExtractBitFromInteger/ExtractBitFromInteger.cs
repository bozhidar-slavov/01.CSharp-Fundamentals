using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        long foundBit = number >> position;
        long bit = foundBit & 1;
        
        Console.WriteLine(bit);
    }
}