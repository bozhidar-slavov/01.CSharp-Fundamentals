using System;

class JumpingSums
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int jumps = int.Parse(Console.ReadLine());

        int[] intArray = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            intArray[i] = int.Parse(input[i]);
        }

        int maxSum = int.MinValue;
        for (int i = 0; i < input.Length; i++)
        {
            int currentSum = 0;
            int value = intArray[i];
            int currentIndex = i;
            int nextIndex = (currentIndex + value) % input.Length;
            for (int j = 0; j <= jumps; j++)
            {
                currentSum += value;
                value = intArray[nextIndex];
                currentIndex = nextIndex;
                nextIndex = (currentIndex + value) % input.Length;
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        Console.WriteLine("max sum = {0}", maxSum);
    }
}