using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int hash = n - 2;
        int letter = 64;
        int dashes = n / 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('~', i));
            Console.Write((char)(letter = letter == 90 ? 65 : letter += 1));
            Console.Write(new string('#', hash));
            Console.Write((char)(letter = letter == 90 ? 65 : letter += 1));
            Console.WriteLine(new string('~', i));

            hash -= 2;
        }

        Console.Write(new string('-', dashes));
        Console.Write((char)(letter = letter == 90 ? 65 : letter += 1));
        Console.WriteLine(new string('-', dashes));

        int tilde = n / 2 - 1;
        hash = 1;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('~', tilde));
            Console.Write((char)(letter = letter == 90 ? 65 : letter += 1));
            Console.Write(new string('#', hash));
            Console.Write((char)(letter = letter == 90 ? 65 : letter += 1));
            Console.WriteLine(new string('~', tilde));

            tilde--;
            hash += 2;
        }
    }
}