using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        int age = (int)((DateTime.Now - birthDate).TotalDays / 365.242199);

        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}