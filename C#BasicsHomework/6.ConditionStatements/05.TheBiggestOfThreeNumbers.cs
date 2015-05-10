using System;
class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Please enter num a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter num b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter num c:");
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("The Biggest num is {0}",a);
        }
        else if (b > c && b > a)
        {
            Console.WriteLine("The Biggest num is {0}", b);
        }
        else
        {
            Console.WriteLine("The Biggest num is {0}", c);
        }
       Main (); 
    }
    
}

