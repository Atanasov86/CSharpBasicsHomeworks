using System;
class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter num a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter num b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter num c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Please enter num d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Please enter num e: ");
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The Biggest num is {0}", a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("The Biggest num is {0}", b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("The Biggest num is {0}", c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("The Biggest num is {0}", d);
        }
        else
        {
            Console.WriteLine("The Biggest num is {0}", e);
        }
        Main();
    }
}

