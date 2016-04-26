using System;

class PersianRugs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int outerSymbols = 0;
        int whitespaces = 2 * n - 1;
        int dots = (2 * n + 1) - 4 - (2 * d);
        for (int i = 0; i < n; i++)
        {
            if (n - 2 >= d + i)
            {
                Console.WriteLine("{0}\\{1}\\{2}/{1}/{0}", new string('#', outerSymbols), new string(' ', d), new string('.', dots));
                dots -= 2;
            }
            else
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('#', outerSymbols), new string(' ', whitespaces));
            }

            whitespaces -= 2;
            outerSymbols++;
        }

        Console.WriteLine("{0}X{0}", new string('#', n));
        
        for (int i = n - 1; i >= 0; i--)
        {
            whitespaces += 2;
            outerSymbols--;
            if (n - 2 >= d + i)
            {
                dots += 2;
                Console.WriteLine("{0}/{1}/{2}\\{1}\\{0}", new string('#', outerSymbols), new string(' ', d), new string('.', dots));
            }
            else
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('#', outerSymbols), new string(' ', whitespaces));
            }
        }
    }
}