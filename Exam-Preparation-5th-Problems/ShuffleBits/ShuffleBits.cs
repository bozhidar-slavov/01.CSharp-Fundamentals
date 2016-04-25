using System;
using System.Text;

class ShuffleBits
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());

        string firstBinary = Convert.ToString(firstNumber, 2).PadLeft(32, '0');
        string secondBinary = Convert.ToString(secondNumber, 2).PadLeft(32, '0');

        var result = new StringBuilder();
        if (firstNumber >= secondNumber)
        {
            for (int i = 0; i < firstBinary.Length; i++)
            {
                result.Append(firstBinary[i]);
                result.Append(secondBinary[i]);
            }
        }
        else
        {
            for (int i = 0; i < firstBinary.Length; i+=2)
            {
                result.Append(firstBinary[i]);
                result.Append(firstBinary[i + 1]);
                result.Append(secondBinary[i]);
                result.Append(secondBinary[i + 1]);
            }
        }

        ulong printing = (ulong)Convert.ToInt64(result.ToString(), 2);

        Console.WriteLine(printing);
    }
}