using System;

class MinMaxSumAndAverageOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal min = decimal.MaxValue;
        decimal max = decimal.MinValue;
        decimal sum = 0;

        for (int i = 1; i <= n ; i++)
        {
            decimal currentElement = decimal.Parse(Console.ReadLine());
            sum += currentElement;

            if (min > currentElement)
            {
                min = currentElement;
            }

            if (max < currentElement)
            {
                max = currentElement;
            }
        }

        decimal average = sum / n;

        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", average);
    }
}