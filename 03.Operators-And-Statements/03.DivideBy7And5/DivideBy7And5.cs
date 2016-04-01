using System;

class DivideBy7And5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool isDivisible = (n % 7 == 0 && n % 5 == 0);
        if (isDivisible)
        {
            Console.WriteLine("true " + n);
        }
        else
        {
            Console.WriteLine("false " + n);
        }
    }
}