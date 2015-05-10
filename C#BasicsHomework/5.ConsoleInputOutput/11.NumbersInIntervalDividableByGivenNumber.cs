using System;
class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = startNum; i <= endNum; i++)
        {
            if (i%5==0)
            {
                Console.Write(i+", ");
                counter++;
            }
        }
        Console.WriteLine();
        Console.WriteLine(counter);
    }
}

