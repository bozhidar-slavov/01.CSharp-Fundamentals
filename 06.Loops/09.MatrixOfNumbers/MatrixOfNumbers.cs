using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0, num = 1; col < n; col++, num++)
            {
                Console.Write(col != n - 1 ? row + num + " " : row + num + "\n");
            }
        }
    }
}