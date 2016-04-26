using System;

class Firefighters
{
    static void Main()
    {
        int firefighters = int.Parse(Console.ReadLine());
        string peopoleToSave = Console.ReadLine();

        int savedKids = 0;
        int savedAdults = 0;
        int savedSeniors = 0;

        while (peopoleToSave != "rain")
        {
            int kidsToSave = 0;
            int adultsToSave = 0;
            int seniorsToSave = 0;
            foreach (var human in peopoleToSave)
            {
                if (human == 'K')
                {
                    kidsToSave++;
                }
                if (human == 'A')
                {
                    adultsToSave++;
                }
                if (human == 'S')
                {
                    seniorsToSave++;
                }
            }

            int firefightersCount = firefighters;
            if (firefightersCount > 0)
            {
                savedKids += firefightersCount >= kidsToSave ? kidsToSave : firefightersCount;
                firefightersCount -= kidsToSave;
            }
            
            if (firefightersCount > 0)
            {
                savedAdults += firefightersCount >= adultsToSave ? adultsToSave : firefightersCount;
                firefightersCount -= adultsToSave;
            }

            if (firefightersCount > 0)
            {
                savedSeniors += firefightersCount >= seniorsToSave ? seniorsToSave : firefightersCount;
                firefightersCount -= seniorsToSave;
            }

            peopoleToSave = Console.ReadLine();
        }

        Console.WriteLine("Kids: {0}", savedKids);
        Console.WriteLine("Adults: {0}", savedAdults);
        Console.WriteLine("Seniors: {0}", savedSeniors);
    }
}