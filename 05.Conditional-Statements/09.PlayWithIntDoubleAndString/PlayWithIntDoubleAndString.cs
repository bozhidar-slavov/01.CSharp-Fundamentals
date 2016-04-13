using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "integer":
                int firstChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(firstChoice + 1);
                break;
            case "real":
                double secondChoice = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", secondChoice + 1);
                break;
            case "text":
                string thirdChoice = Console.ReadLine();
                Console.WriteLine(thirdChoice + '*');
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}