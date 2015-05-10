using System;
class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        // Check if num b is integer 
        bool isIntNumB = b == (int)b;
        // Check if num c is integer 
        bool isIntNumC = c == (int)c;
        Console.Write("|{0,-10:X}", a);
        Console.Write("|{0,-10}|", Convert.ToString(a, 2).PadLeft(10, '0'));
        // If is true we printing num b without 2 digits after the decimal point
        Console.Write(isIntNumB ? "{0,10}|" : "{0,10:F2}|", b);
        // If is true we printing num c without 3 digits after the decimal point
        Console.Write(isIntNumC ? "{0,-10}|" : "{0,-10:F3}|", c);
        Console.WriteLine();
    }
}
