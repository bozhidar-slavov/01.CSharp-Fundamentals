using System;

class BookOrders
{
    static void Main()
    {
        int numberOfOrders = int.Parse(Console.ReadLine());
        
        int currentSumOfBooks = 0;
        int sumOfBooks = 0;
        decimal currentBooksPrice = 0;
        decimal totalBooksPrice = 0;
        decimal discount = 0;
        
        for (int i = 0; i < numberOfOrders; i++)
        {
            int numberOfPackets = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            decimal bookPrice = decimal.Parse(Console.ReadLine());

            currentSumOfBooks = numberOfPackets * booksPerPacket;
            sumOfBooks += currentSumOfBooks;

            if (numberOfPackets < 10)
            {
                discount = bookPrice * 1.00M;
            }
            else if (numberOfPackets >= 10 && numberOfPackets <= 19)
            {
                discount = bookPrice * 0.95M;
            }
            else if (numberOfPackets >= 20 && numberOfPackets <= 29)
            {
                discount = bookPrice * 0.94M;
            }
            else if (numberOfPackets >= 30 && numberOfPackets <= 39)
            {
                discount = bookPrice * 0.93M;
            }
            else if (numberOfPackets >= 40 && numberOfPackets <= 49)
            {
                discount = bookPrice * 0.92M;
            }
            else if (numberOfPackets >= 50 && numberOfPackets <= 59)
            {
                discount = bookPrice * 0.91M;
            }
            else if (numberOfPackets >= 60 && numberOfPackets <= 69)
            {
                discount = bookPrice * 0.90M;
            }
            else if (numberOfPackets >= 70 && numberOfPackets <= 79)
            {
                discount = bookPrice * 0.89M;
            }
            else if (numberOfPackets >= 80 && numberOfPackets <= 89)
            {
                discount = bookPrice * 0.88M;
            }
            else if (numberOfPackets >= 90 && numberOfPackets <= 99)
            {
                discount = bookPrice * 0.87M;
            }
            else if (numberOfPackets >= 100 && numberOfPackets <= 109)
            {
                discount = bookPrice * 0.86M;
            }
            else if (numberOfPackets >= 110)
            {
                discount = bookPrice * 0.85M;
            }

            currentBooksPrice = currentSumOfBooks * discount;
            totalBooksPrice += currentBooksPrice;
        }

        Console.WriteLine(sumOfBooks);
        Console.WriteLine("{0:F2}", totalBooksPrice);
    }
}