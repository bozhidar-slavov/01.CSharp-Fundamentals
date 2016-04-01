using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        int foundBit = number >> position;
        int bit = foundBit & 1;
        
        Console.WriteLine(bit);
    }
}