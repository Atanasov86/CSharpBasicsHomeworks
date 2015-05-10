using System;
class PointInCircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInside = ((Math.Pow(x,2))+(Math.Pow(y,2))) <= 2*2;
        Console.WriteLine(isInside);
    }
}

