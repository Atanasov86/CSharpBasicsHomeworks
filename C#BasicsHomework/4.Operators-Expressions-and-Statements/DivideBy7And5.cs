using System;
class DivideBy7And5
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool isDivided = num % 7 == 0 && num % 5 == 0 && num!=0;
        Console.WriteLine(isDivided);
    }
}

