using System;
class SumOf3Numbers
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());
        Console.WriteLine(numA+numB+numC);
        Main();
    }
}

