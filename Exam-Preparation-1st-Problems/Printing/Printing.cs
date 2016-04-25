using System;

class Printing
{
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        int numberOfPaperSheets = int.Parse(Console.ReadLine());
        double priceOfRealm = double.Parse(Console.ReadLine());

        int oneRealm = 500;
        double sheetsOfPaper = students * numberOfPaperSheets;
        double reams = sheetsOfPaper / oneRealm;
        double totalPrice = reams * priceOfRealm;

        Console.WriteLine("{0:F2}", totalPrice);
    }
}