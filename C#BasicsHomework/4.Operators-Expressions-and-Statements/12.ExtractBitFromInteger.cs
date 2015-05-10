using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());

        num = num >> pos;
        int bit = num & 1;
        Console.WriteLine(bit);
    }
}

