using System;

class BitsToBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string binary = string.Empty;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            binary += Convert.ToString(number, 2).PadLeft(30, '0');
        }

        int currentZeroes = 0;
        int currentOnes = 0;
        int maxZeroes = 0;
        int maxOnes = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                currentZeroes++;
                maxZeroes = (maxZeroes >= currentZeroes) ? maxZeroes : currentZeroes;
            }
            else
            {
                currentZeroes = 0;
            }

            if (binary[i] == '1')
            {
                currentOnes++;
                maxOnes = (maxOnes >= currentOnes) ? maxOnes : currentOnes;
            }
            else
            {
                currentOnes = 0;
            }
        }

        Console.WriteLine(maxOnes);
        Console.WriteLine(maxZeroes);
    }
}