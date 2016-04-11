using System;

class IsThirdDigit7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        number /= 100;
        number %= 10;

        bool isSeven = (number == 7);
        if (isSeven)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + number);
        }
    }
}