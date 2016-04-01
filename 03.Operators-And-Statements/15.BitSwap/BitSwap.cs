using System;

class BitSwap
{
    static void Main()
    {
        uint number;
        bool checkUInteger = uint.TryParse(Console.ReadLine(), out number);

        if (checkUInteger == false)
        {
            Console.WriteLine("Out of unsigned integer range!");
        }
        else
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int lenght = Math.Min(p, q) + k;

            if (Math.Min(p, q) + k >= Math.Max(p, q))
            {
                Console.WriteLine("Overlapping!");
            }
            else if (p < 0 || q < 0 || p + k > 32 || q + k > 32)
            {
                Console.WriteLine("Out of range!");
            }
            else
            {
                for (; Math.Min(p, q) < lenght; p++, q++)
                {
                    uint mask1 = (uint)(number & 1 << p);
                    uint mask2 = (uint)(number & 1 << q);

                    if (mask1 != 0)
                    {
                        number = number | (uint)(1 << q);
                    }
                    else
                    {
                        number = number & (uint)(~(1 << q));
                    }

                    if (mask2 != 0)
                    {
                        number = number | (uint)(1 << p);
                    }
                    else
                    {
                        number = number & (uint)(~(1 << p));
                    }
                }

                Console.WriteLine(number);
            }
        }
    }
}