using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:\n{0}\n{1}",a,b);

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After:\n{0}\n{1}",a,b);    
    }
}