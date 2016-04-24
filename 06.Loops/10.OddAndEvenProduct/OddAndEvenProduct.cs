using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.ReadLine();
        string[] numbers = Console.ReadLine().Split(' ');

        long evenProduct = 1;
        long oddProduct = 1;

        for (int position = 0; position < numbers.Length; position++)
        {
            int number = int.Parse(numbers[position]);
            if (position % 2 == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes " + evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}