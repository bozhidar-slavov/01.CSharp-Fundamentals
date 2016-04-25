using System;

class OddOrEvenCounter
{
    static void Main()
    {
        int countOfSets = int.Parse(Console.ReadLine());
        int numbersInSet = int.Parse(Console.ReadLine());
        string oddOrEven = Console.ReadLine();

        int oddCounter = 0;
        int evenCounter = 0;
        int maxEvenSet = 0;
        int maxOddSet = 0;
        int biggestSet = 0;

        for (int i = 1; i <= countOfSets; i++)
        {
            for (int j = 0; j < numbersInSet; j++)
            {
                int currentNumberInSet = int.Parse(Console.ReadLine());

                if (oddOrEven == "even" && currentNumberInSet % 2 == 0)
                {
                    evenCounter++;
                }
                else if (oddOrEven == "odd" && currentNumberInSet % 2 != 0)
                {
                    oddCounter++;
                }
            }

            if (evenCounter > maxEvenSet)
            {
                maxEvenSet = evenCounter;
                biggestSet = i;
            }
            else if (oddCounter > maxOddSet)
            {
                maxOddSet = oddCounter;
                biggestSet = i;
            }

            evenCounter = 0;
            oddCounter = 0;
        }

        string setWithWord = string.Empty;
        switch (biggestSet)
        {
            case 1: setWithWord = "First"; break;
            case 2: setWithWord = "Second"; break;
            case 3: setWithWord = "Third"; break;
            case 4: setWithWord = "Fourth"; break;
            case 5: setWithWord = "Fifth"; break;
            case 6: setWithWord = "Sixth"; break;
            case 7: setWithWord = "Seventh"; break;
            case 8: setWithWord = "Eighth"; break;
            case 9: setWithWord = "Ninth"; break;
            case 10: setWithWord = "Tenth"; break;
        }

        if (oddOrEven == "even" && maxEvenSet > 0)
        {
            Console.WriteLine("{0} set has the most even numbers: {1}", setWithWord, maxEvenSet);
        }
        else if (oddOrEven == "odd" && maxOddSet > 0)
        {
            Console.WriteLine("{0} set has the most odd numbers: {1}", setWithWord, maxOddSet);
        }
        else if (maxOddSet == 0 || maxEvenSet == 0)
        {
            Console.WriteLine("No");
        }
    }
}