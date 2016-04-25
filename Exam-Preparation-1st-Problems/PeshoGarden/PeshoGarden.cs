using System;

class PeshoGarden
{
    static void Main()
    {
        decimal tomatoSeed = decimal.Parse(Console.ReadLine());
        decimal tomatoArea = decimal.Parse(Console.ReadLine());

        decimal cucumberSeed = decimal.Parse(Console.ReadLine());
        decimal cucumberArea = decimal.Parse(Console.ReadLine());

        decimal potatoSeed = decimal.Parse(Console.ReadLine());
        decimal potatoArea = decimal.Parse(Console.ReadLine());

        decimal carrotSeed = decimal.Parse(Console.ReadLine());
        decimal carrotArea = decimal.Parse(Console.ReadLine());

        decimal cabbageSeed = decimal.Parse(Console.ReadLine());
        decimal cabbageArea = decimal.Parse(Console.ReadLine());

        decimal beanSeed = decimal.Parse(Console.ReadLine());

        decimal tomatoCost = tomatoSeed * 0.5M;
        decimal cucumberCost = cucumberSeed * 0.4M;
        decimal potatoCost = potatoSeed * 0.25M;
        decimal carrotCost = carrotSeed * 0.6M;
        decimal cabbageCost = cabbageSeed * 0.3M;
        decimal beanCost = beanSeed * 0.4M;

        decimal totalCost = (tomatoCost + cucumberCost + potatoCost + carrotCost + cabbageCost + beanCost);

        Console.WriteLine("Total costs: " + totalCost);

        decimal beanArea = 250M - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);

        if (beanArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (beanArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Beans area: " + beanArea);
        }
    }
}