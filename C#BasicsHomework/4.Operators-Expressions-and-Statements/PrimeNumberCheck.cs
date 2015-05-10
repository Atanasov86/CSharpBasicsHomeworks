using System;
class PrimeNumberCheck
{
    static void Main()
    {
        int number =int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider =(int)Math.Sqrt(number);
        bool isPrime = true;
        if (number <= 1)
        {
            Console.WriteLine("False");
        }
        else
        {
            while (isPrime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                }
                divider++;
            }
            Console.WriteLine(isPrime);
        }
    }
}

