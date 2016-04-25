using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int weight = int.Parse(Console.ReadLine());

        bool hasMagicDate = false;

        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);

        for (DateTime i = startDate;  i <= endDate; i = i.AddDays(1))
        {
            string number = "" + i.Day;
            number += i.Month;
            number += i.Year;
            int sum = 0;
            for (int j = 0; j < number.Length; j++)
            {
                int currentDigit = int.Parse(number[j].ToString());
                for (int k = j + 1; k < number.Length; k++)
                {
                    int digitToMultiply = int.Parse(number[k].ToString());
                    sum += currentDigit * digitToMultiply;
                }
            }
            if (sum == weight)
            {
                Console.WriteLine("{0:00}-{1:00}-{2}", i.Day, i.Month, i.Year);
                hasMagicDate = true;
            }
        }
        if (!hasMagicDate)
        {
            Console.WriteLine("No");
        }
    }
}