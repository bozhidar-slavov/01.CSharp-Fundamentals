using System;

class CalculateSumOfNXN
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        double nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            sum += nFactorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}