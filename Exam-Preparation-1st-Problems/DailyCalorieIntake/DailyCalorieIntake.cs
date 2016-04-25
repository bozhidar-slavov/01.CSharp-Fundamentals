using System;

class DailyCalorieIntake
{
    static void Main()
    {
        int weightInPounds = int.Parse(Console.ReadLine());
        int heightInInches = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workoutsPerWeek = int.Parse(Console.ReadLine());

        double weightInKilograms = weightInPounds / 2.2d;
        double heightInCentimeters = heightInInches * 2.54d;

        double menBMR = 66.5 + (13.75d * weightInKilograms) + (5.003d * heightInCentimeters) - (6.755d * age);
        double womenBMR = 655 + (9.563d * weightInKilograms) + (1.850d * heightInCentimeters) - (4.676 * age);

        double dciValue;
        if (workoutsPerWeek <= 0)
        {
            dciValue = 1.2d;
        }
        else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
        {
            dciValue = 1.375d;
        }
        else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
        {
            dciValue = 1.55d;
        }
        else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
        {
            dciValue = 1.725d;
        }
        else
        {
            dciValue = 1.9d;
        }

        if (gender == 'm')
        {
            Console.WriteLine(Math.Floor(dciValue * menBMR));
        }
        else
        {
            Console.WriteLine(Math.Floor (dciValue * womenBMR));
        }
    }
}