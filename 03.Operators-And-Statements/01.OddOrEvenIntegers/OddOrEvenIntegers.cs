using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("even " + n);
        }
        else
        {
            Console.WriteLine("odd " + n);
        }
    }
}