using System;

class ComparingFloats
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        bool areEqual = Math.Abs(firstNumber - secondNumber) < 0.000001;
        if (areEqual)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}