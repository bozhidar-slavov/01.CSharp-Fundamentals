using System;

class PointCircleRectangle
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        decimal centerX = 1m;
        decimal centerY = 1m;
        decimal r = 1.5m;

        decimal leftX = -1m;
        decimal rightX = 5m;
        decimal topY = 1m;
        decimal bottomY = -1m;

        bool isInCircle = (x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= (r * r);
        bool isInRectangle = (x >= leftX && x <= rightX) && (y <= topY && y >= bottomY);
        
        if (isInCircle)
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }

        if (isInRectangle)
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }
    }
}