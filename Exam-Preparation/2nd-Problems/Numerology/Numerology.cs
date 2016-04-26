using System;

class Numerology
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('.', ' ');
        string name = input[3];
        int day = int.Parse(input[0]);
        int month = int.Parse(input[1]);
        int year = int.Parse(input[2]);
        long dateOfBirthProduct = day * month * year;

        if (month % 2 != 0)
        {
            dateOfBirthProduct *= dateOfBirthProduct;
        }

        long sum = 0;
        foreach (var symbol in input[3])
        {
            if (Char.IsLower(symbol))
            {
                sum += symbol - 'a' + 1;
            }
            else if (Char.IsUpper(symbol))
            {
                sum += (symbol - 'A' + 1) * 2;
            }
            else
            {
                sum += symbol - 48;   // taking digit from string
            }
        }

        long totalSum = dateOfBirthProduct + sum;

        while (totalSum > 13)
        {
            long digitSum = 0;
            while (totalSum > 0)
            {
                digitSum += totalSum % 10;
                totalSum /= 10;
            }

            totalSum = digitSum;
        }

        Console.WriteLine(totalSum);
    }
}