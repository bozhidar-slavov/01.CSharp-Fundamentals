using System;
using System.Numerics;

class ConsoleApplication1
{
    static void Main()
    {
        string input = Console.ReadLine();
        int counter = 0;
        BigInteger currentProduct = 1;
        BigInteger firstTenProduct = 1;
        BigInteger othersProduct = 1;
        bool isMoreThanTen = false;

        while (input != "END")
        {
            if (counter % 2 != 0)
            {
                foreach (var digit in input)
                {
                    if (digit != '0')
                    {
                        currentProduct *= digit - 48;
                    }
                }

                if (isMoreThanTen)
                {
                    othersProduct *= currentProduct;
                    currentProduct = 1;
                }
                else
                {
                    firstTenProduct *= currentProduct;
                    currentProduct = 1;
                }
            }

            counter++;
            if (counter == 10)
            {
                isMoreThanTen = true;
            }

            input = Console.ReadLine();
        }

        if (isMoreThanTen)
        {
            Console.WriteLine(firstTenProduct);
            Console.WriteLine(othersProduct);
        }
        else
        {
            Console.WriteLine(firstTenProduct);
        }
    }
}