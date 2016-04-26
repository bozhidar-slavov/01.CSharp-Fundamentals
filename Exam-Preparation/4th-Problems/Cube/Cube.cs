using System;

class Cube
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int whitespaces = n - 1;
        int colon = n;
        int slashes = n - 2;
        int xLetter = 0;

        Console.WriteLine("{0}{1}", new string(' ', whitespaces), new string(':', colon));

        whitespaces = n - 2;

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}:{1}:{2}:", new string(' ', whitespaces), new string('/', slashes), new string('X', xLetter));
            whitespaces--;
            xLetter++;
        }

        xLetter = n - 2;

        Console.WriteLine("{0}{1}:", new string(':', colon), new string('X', xLetter));

        xLetter = n - 3;
        whitespaces = n - 2;

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(":{0}:{1}:", new string(' ', whitespaces), new string('X', xLetter));
            xLetter--;
        }

        colon = n;

        Console.WriteLine("{0}", new string(':', colon));
    }
}
