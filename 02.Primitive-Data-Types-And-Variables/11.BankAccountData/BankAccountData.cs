using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Georgi";
        string middleName = "Georgiev";
        string lastName = "Georgiev";
        decimal balance = 1654000.50M;
        string bankName = "Fibank";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        ulong firstCardNumber = 372151897379856;
        ulong secondCardNumber = 372151897379857;
        ulong thirdCardNumber = 372151897379858;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", firstName, middleName, lastName, balance, bankName, iban, firstCardNumber, secondCardNumber, thirdCardNumber);
    }
}