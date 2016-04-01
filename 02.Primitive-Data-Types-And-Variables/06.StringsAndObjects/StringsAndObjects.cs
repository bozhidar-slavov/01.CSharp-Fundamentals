using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object bothStrings = firstWord + " " + secondWord;
        string greeting = bothStrings.ToString();

        Console.WriteLine(greeting);
    }
}