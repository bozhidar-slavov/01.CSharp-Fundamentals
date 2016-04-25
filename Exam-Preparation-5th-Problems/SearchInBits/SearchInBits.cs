using System;
using System.Text;

class SearchInBits
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        string fourBits = Convert.ToString(s, 2).PadLeft(4, '0');

        var binary = new StringBuilder();
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            binary.Append(Convert.ToString(number, 2).PadLeft(30, '0'));
            for (int j = 0; j < binary.Length - 3; j++)
            {
                if (binary[j] == fourBits[0] && binary[j + 1] == fourBits[1] && binary[j + 2] == fourBits[2] && binary[j + 3] == fourBits[3])
                {
                    counter++;
                }
            }

            binary.Clear();
        }

        Console.WriteLine(counter);
    }
}