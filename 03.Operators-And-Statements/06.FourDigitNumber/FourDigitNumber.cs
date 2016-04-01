using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int fourthDigit = number % 10;
        int thirdDigit = (number / 10) % 10;
        int secondDigit = (number / 100) % 10;
        int firstDigit = (number / 1000) % 10;

        Console.WriteLine((fourthDigit + thirdDigit + secondDigit + firstDigit));
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}