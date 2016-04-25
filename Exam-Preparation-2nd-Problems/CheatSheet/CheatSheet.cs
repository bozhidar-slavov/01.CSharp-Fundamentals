using System;

class CheatSheet
{
    static void Main()
    {
        long row = long.Parse(Console.ReadLine());
        long column = long.Parse(Console.ReadLine());
        long vertical = long.Parse(Console.ReadLine());
        long horizontal = long.Parse(Console.ReadLine());

        for (long i = vertical; i < vertical + row; i++)
        {
            for (long j = horizontal; j < horizontal + column; j++)
            {
                Console.Write(i * j + " ");
            }
            Console.WriteLine();
        }
    }
}