using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int i = 33; i <= 126; i++)
        {
            Console.Write((char)i);
        }
    }
}