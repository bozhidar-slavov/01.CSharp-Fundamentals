using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Null integer value: " + a);
        Console.WriteLine("Null double value: " + b);

        a += 5;
        b += 10.5;
        Console.WriteLine("Added some value to null integer: " + a);
        Console.WriteLine("Added some value to null double: " + b);
        Console.WriteLine("The result of every math operation with null is null!");
    }
}