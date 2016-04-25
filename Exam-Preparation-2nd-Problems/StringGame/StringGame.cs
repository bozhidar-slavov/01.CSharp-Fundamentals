using System;
using System.Numerics;

class StringGame
{
    static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();
        BigInteger sum = 0;

        for (ulong i = startNumber; i < endNumber; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }
        string sumString = sum.ToString();
        string replacingDigit = string.Empty;
        if (sum % 2 != 0)
        {
            replacingDigit = sumString[sumString.Length - 1].ToString(); // taking last digit of string
        }
        else
        {
            replacingDigit = sumString[0].ToString();                   // taking first digit of string
        }
        sumString = sumString.Replace(replacingDigit, replacement);    
        Console.WriteLine(sumString);
    }
}