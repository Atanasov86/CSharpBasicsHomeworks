using System;
class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double b = double.Parse(Console.ReadLine());
        if (a>b)
        {
            double temp = 0;
            temp = a;
            a = b;
            b=temp;
        }
        Console.WriteLine("{0} {1}",a,b);
    }
}

