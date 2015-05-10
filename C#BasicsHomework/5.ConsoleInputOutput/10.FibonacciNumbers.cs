using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long firstFibNum = 0;
        long secondFibNum = 1;

        for (int i = 0; i < n; i++)
        {
            long currentFibNum = firstFibNum;
            firstFibNum = secondFibNum;
            secondFibNum = currentFibNum+secondFibNum;
            Console.Write(currentFibNum + " ");

        }
        Console.WriteLine();

    }
}

