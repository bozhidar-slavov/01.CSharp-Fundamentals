using System;

class CalculateSumOfNXN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        int nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            sum += nFactorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}