using System;

class ModifyABit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        
        if (value == 1)
        {
            ulong setOne = (ulong)1 << position;
            ulong foundBitOne = number | setOne;
            Console.WriteLine(foundBitOne);
        }
        else
        {
            ulong setZero = (ulong)~(1 << position);
            ulong foundBitZero = number & setZero;
            Console.WriteLine(foundBitZero);
        }
    }
}