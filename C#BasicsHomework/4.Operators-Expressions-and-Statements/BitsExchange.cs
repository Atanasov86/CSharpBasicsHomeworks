using System;
class BitsExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 7;
        uint firstBits = (number & (mask << 3))>>3;
        Console.WriteLine(Convert.ToString(firstBits,2).PadLeft(32,'0'));
        uint secondBits = (number & (mask << 24)) >> 24;
        Console.WriteLine(Convert.ToString(secondBits, 2).PadLeft(32, '0'));
        number = number & ~(mask << 3);
        number = number & ~(mask << 24);
        number = number | (firstBits << 24);
        number = number | (firstBits << 3);
        Console.WriteLine(number);
    }
}

