using System;

class LongSequence
{
    static void Main()
    {
        Console.BufferHeight = 1000;

        for (int i = 2; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }

            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}