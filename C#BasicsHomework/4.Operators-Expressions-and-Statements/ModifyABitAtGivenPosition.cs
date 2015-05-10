using System;
class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        if (value == 0)
        {
            int mask = ~(1 << pos);
            int result = num & mask;
            Console.WriteLine(result);
        }
        else
        {
            int mask = 1 << pos;
            int result = num | mask;
            Console.WriteLine(result);
        }
    }
}

