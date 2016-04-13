using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string cardSign = Console.ReadLine();

        switch (cardSign)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.WriteLine("yes " + cardSign);
                break;
            default:
                Console.WriteLine("no " + cardSign);
                break;
        }
    }
}