using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double biggestNum = double.MinValue;
        for (int i = 0; i < 5; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number > biggestNum)
            {
                biggestNum = number;
            }
        }

        Console.WriteLine(biggestNum);
    }
}