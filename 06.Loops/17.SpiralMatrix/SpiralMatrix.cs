using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        int value = 1;
        while (value <= n * n)
        {
            while (col < matrix.GetLength(0) && matrix[col, row] == 0)
            {
                matrix[row, col++] = value;
                value++;
            }

            col--;
            row++;

            while (row < matrix.GetLength(1) && matrix[row, col] == 0)
            {
                matrix[row++, col] = value;
                value++;
            }

            row--;
            col--;

            while (col >= 0 && matrix[row, col] == 0)
            {
                matrix[row, col--] = value;
                value++;
            }

            col++;
            row--;

            while (row >= 0 && matrix[row, col] == 0)
            {
                matrix[row--, col] = value;
                value++;
            }

            col++;
            row++;
        }


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}