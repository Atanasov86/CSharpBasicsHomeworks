using System;
class ThirdDigitIs7
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int tempNum = num / 100;
        int thirdDigit = tempNum % 10;
        bool thirdDigitIsSeven = thirdDigit == 7;
        Console.WriteLine(thirdDigitIsSeven);
    }
}

