using System;

class EncryptTheMessages
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        while (input.ToLower() != "start")
        {
            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        int messagesCounter = 0;
        string encryptedMessage = string.Empty;
        while (input.ToLower() != "end")
        {
            if (input != string.Empty)
            {
                for (int symbol = input.Length - 1; symbol >= 0; symbol--) // use reversed for to escape reversing the string
                {
                    if (Char.IsLetter(input[symbol]))
                    {
                        if (input[symbol] >= 'A' && input[symbol] <= 'M' ||
                            input[symbol] >= 'a' && input[symbol] <= 'm')
                        {
                            encryptedMessage += (char)(input[symbol] + 13); // convert characters A -> N , B -> O ... 
                        }
                        else
                        {
                            encryptedMessage += (char)(input[symbol] - 13);
                        }
                    }
                    else
                    {
                        switch (input[symbol])
                        {
                            case ' ': encryptedMessage += '+'; break;
                            case ',': encryptedMessage += '%'; break;
                            case '.': encryptedMessage += '&'; break;
                            case '?': encryptedMessage += '#'; break;
                            case '!': encryptedMessage += '$'; break;
                            default: encryptedMessage += input[symbol]; break;  // taking digit without convertion
                        }
                    }
                }
                encryptedMessage += "\n"; // Environment.NewLine
                messagesCounter++;
            }

            input = Console.ReadLine();
        }

        if (messagesCounter == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", messagesCounter);

            Console.Write(encryptedMessage);
        }
    }
}