using System;

class TextToNumber
{
    static void Main()
    {
        int module = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int result = 0;

        foreach (char symbol in input)
        {
            if (symbol == '@')
            {
                break;
            }
            if (Char.IsUpper(symbol))
            {
                result += symbol - 65;
            }
            if (Char.IsLower(symbol))
            {
                result += symbol - 97;
            }
            if (Char.IsDigit(symbol))
            {
                result *= symbol - '0';
            }
            if (symbol >= 32 && symbol <= 47 ||
                symbol >= 58 && symbol <= 63 ||
                symbol >= 91 && symbol <= 96 ||
                symbol >= 123 && symbol <= 126)
            {
                result %= module;
            }
        }

        Console.WriteLine(result);
    }
}