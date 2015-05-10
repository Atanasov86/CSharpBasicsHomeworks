using System;
class PointInsideACircleOutsideOfARectan
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInsideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
        bool isOutsideRectangle = x >= -1 && x <= 5 && y <= 1 && y >= -1;
        if (isInsideCircle && !isOutsideRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Main();
    } 
}

