using System;
// using System.Text;

class SpyHard
{
    static void Main()
    {
        int numeralSystem = int.Parse(Console.ReadLine());
        string message = Console.ReadLine().ToLower();

        int messageLength = message.Length;
        int sum = 0;
        string convertedSum = string.Empty;
        foreach (var symbol in message)
        {
            if (Char.IsLetter(symbol))
            {
                sum += symbol - 'a' + 1; // == 96 
            }
            else
            {
                sum += symbol;
            }
        }

        while (sum != 0)
        {
            int remainder = (int)sum % numeralSystem;
            sum /= numeralSystem;
            convertedSum = remainder + convertedSum;
        }
        
        string output = numeralSystem.ToString() + messageLength.ToString() + convertedSum;
        Console.WriteLine(output);

        // var convertedSum = new StringBuilder();
        // 
        // while (sum > 0)
        // {
        //     convertedSum.Insert(0, sum % numeralSystem);
        //     sum /= numeralSystem;
        // }
        // convertedSum.Insert(0, messageLength);
        // convertedSum.Insert(0, numeralSystem);
        // Console.WriteLine(convertedSum);        
    }
}