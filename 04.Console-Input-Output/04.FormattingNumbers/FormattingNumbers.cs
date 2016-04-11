using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("{0:X} ", a);
        Console.Write("|{0}| ", Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("{0:F2}", b);
        Console.WriteLine("|{0:F3} |", c);
    }
}