using System;
class SumOf5Numbers
{
    static void Main()
    {
        string inputNums = Console.ReadLine();
        string[] inputNumsAsArray = inputNums.Split(' ');
        double sum = 0;
        for (int i = 0; i < inputNumsAsArray.Length; i++)
        {
            double currentNum = double.Parse(inputNumsAsArray[i]);
            sum += currentNum;
        }
        Console.WriteLine(sum);
    }
}

