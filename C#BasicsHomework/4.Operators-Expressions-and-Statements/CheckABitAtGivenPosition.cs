using System;
class CheckABitAtGivenPosition
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());

        num = num >> pos;
        int bit = num & 1;
        bool isOne = (bit == 1);
        Console.WriteLine(isOne);
    }
}

