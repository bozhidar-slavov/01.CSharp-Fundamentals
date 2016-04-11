using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine(sum);
    }
}