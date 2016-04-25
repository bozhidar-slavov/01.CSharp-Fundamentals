using System;

class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        decimal totalPrice = 0;

        for (int i = 0; i < 3; i++)
        {
            decimal quantity = decimal.Parse(Console.ReadLine());
            string product = Console.ReadLine();

            decimal productPrice = 0;
            bool isFruit = false;
            switch (product)
            {
                case "banana": productPrice = 1.80m; isFruit = true; break;
                case "cucumber": productPrice = 2.75m; break;
                case "tomato": productPrice = 3.20m; break;
                case "orange": productPrice = 1.60m; isFruit = true; break;
                case "apple": productPrice = 0.86m; isFruit = true; break;
            }

            switch (dayOfWeek)
            {
                case "Monday": totalPrice += quantity * productPrice; break;
                case "Tuesday": totalPrice += quantity * productPrice * (isFruit ? 0.8m : 1); break;
                case "Wednesday": totalPrice += quantity * productPrice * (!isFruit ? 0.9m : 1); break;
                case "Thursday": totalPrice += quantity * productPrice * (product == "banana" ? 0.7m : 1); break;
                case "Friday": totalPrice += quantity * productPrice * 0.9m; break;
                case "Saturday": totalPrice += quantity * productPrice; break;
                case "Sunday": totalPrice += quantity * productPrice * 0.95m; break;
            }
        }

        Console.WriteLine("{0:F2}", totalPrice);
    }
}