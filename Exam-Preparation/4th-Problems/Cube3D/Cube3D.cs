using System;

class Cube3D
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string(':', n));

        int lines = 0;
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(":{0}:{1}:", new string(' ', n - 2), new string('|', lines));
            lines++;
        }

        Console.WriteLine("{0}{1}:", new string (':', n), new string('|', n - 2));

        int whitespace = 1;
        lines = n - 3;
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}:{1}:{2}:", new string(' ', whitespace), new string('-', n - 2), new string('|', lines));
            lines--;
            whitespace++;
        }

        Console.WriteLine("{0}{1}", new string(' ', n - 1), new string(':', n));
    }
}