using System;
class BitwiseExtractBit3
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = 3;
        num = num >> pos;
        int bit = num & 1;
        Console.WriteLine(bit);
    }
}


