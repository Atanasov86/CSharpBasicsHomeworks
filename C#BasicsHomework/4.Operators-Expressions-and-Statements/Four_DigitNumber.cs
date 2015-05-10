using System;
class Four_DigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int lastDigit = number % 10;
        number /= 10;
        int thirdDigit = number % 10;
        number /= 10;
        int secondDigit = number % 10;
        number /= 10;
        int firstDigit = number % 10;
        int sumOfDigits = firstDigit + secondDigit + thirdDigit + lastDigit;
        Console.WriteLine(sumOfDigits);
        Console.WriteLine(""+lastDigit+thirdDigit+secondDigit+firstDigit);
        Console.WriteLine(""+lastDigit+firstDigit+secondDigit+thirdDigit);
        Console.WriteLine(""+firstDigit+thirdDigit+secondDigit+lastDigit);
    }
}

