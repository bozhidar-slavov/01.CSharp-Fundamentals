using System;
using System.Collections.Generic;

class DecryptTheMessages
{
    static void Main()
    {
        string input = string.Empty;

        List<string> messages = new List<string>();

        while (input.ToLower() != "start")
        {
            input = Console.ReadLine();
        }

        input = Console.ReadLine();
        while (input.ToLower() != "end")
        {
            if (input != string.Empty)
            {
                string decryptedMessage = string.Empty;
                for (int symbol = 0; symbol < input.Length; symbol++)
                {
                    if (Char.IsLetter(input[symbol]))
                    {
                        if (input[symbol] >= 'A' && input[symbol] <= 'M' ||
                            input[symbol] >= 'a' && input[symbol] <= 'm')
                        {
                            decryptedMessage += (char)(input[symbol] + 13);
                        }
                        else
                        {
                            decryptedMessage += (char)(input[symbol] - 13);
                        }
                    }
                    else
                    {
                        switch (input[symbol])
                        {
                            case '+' : decryptedMessage += ' '; break;
                            case '%': decryptedMessage += ','; break;
                            case '&': decryptedMessage += '.'; break;
                            case '#': decryptedMessage += '?'; break;
                            case '$': decryptedMessage += '!'; break;
                            default: decryptedMessage += input[symbol]; break;
                        }
                    }
                }

                char[] reversedArray = decryptedMessage.ToCharArray();
                Array.Reverse(reversedArray);
                decryptedMessage = new string(reversedArray);

                messages.Add(decryptedMessage);
            }

            input = Console.ReadLine();
        }

        if (messages.Count != 0)
        {
            Console.WriteLine("Total number of messages: {0}", messages.Count);
            foreach (var msg in messages)
            {
                Console.WriteLine(msg);
            }
        }
        else
        {
            Console.WriteLine("No message received.");
        }

    }
}