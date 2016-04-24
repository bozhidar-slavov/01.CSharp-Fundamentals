using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long decimalNumber = 0;
        int power = 1;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            int number = binaryNumber[i] - 48;
            decimalNumber += number * power;
            power *= 2;
        }

        Console.WriteLine(decimalNumber);
    }
}