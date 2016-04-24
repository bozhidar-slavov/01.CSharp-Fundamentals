using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        string hexNumber = string.Empty;

        if (decNumber == 0)
        {
            hexNumber = "0";
        }
        else
        {
            while (decNumber > 0)
            {
                long remainder = decNumber % 16;
                decNumber /= 16;
                switch (remainder)
                {
                    case 10: hexNumber = "A" + hexNumber; break;
                    case 11: hexNumber = "B" + hexNumber; break;
                    case 12: hexNumber = "C" + hexNumber; break;
                    case 13: hexNumber = "D" + hexNumber; break;
                    case 14: hexNumber = "E" + hexNumber; break;
                    case 15: hexNumber = "F" + hexNumber; break;
                    default: hexNumber = remainder + hexNumber; break;
                }
            }
        }

        Console.WriteLine(hexNumber);
    }
}
