using System;

class DecimalToBinary
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        string binaryNumber = string.Empty;

        while (decimalNumber != 0)
        {
            int remainder = (int)decimalNumber % 2;
            decimalNumber /= 2;
            binaryNumber = remainder + binaryNumber;
        }

        Console.WriteLine(binaryNumber);
    }
}