using System;
class NumberAsWords
{
    static void Main()
    {
        Console.Write("Please enter number from 1 to 999: ");
        int  number =int.Parse(Console.ReadLine());

        string[] UpperUnits = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","Ten","Eleven",
                                        "Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eightteen","Nineteen"};
        string[] units = new string[] {"","one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten","eleven",
                                        "twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eightteen","nineteen"};
        string[] tenths = new string[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] UpperTenths = new string[] { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        int hundred = number / 100;
        int tenth = (number / 10) % 10;
        int unit = number % 10;
        string numberAsWord = string.Empty;
        if (number>= 0 && number<=19)
        {
            numberAsWord = UpperUnits[number];
        }
        if (number>=20 && number<=99)
        {
            numberAsWord = UpperTenths[tenth] + " " + units[unit];
        }
        if (number>=100 && tenth==0 && unit==0)
        {
            numberAsWord = UpperUnits[hundred] + " hundred"; 
        }
        if (number>=100 && tenth!=0 && unit==0)
        {
            numberAsWord = UpperUnits[hundred] + " hundred and " + UpperTenths[tenth];
        }
        if (number>=100 && tenth==0 && unit!=0)
        {
            numberAsWord = UpperUnits[hundred] + " hundred and " + units[unit];
        }
        if (number>=100 && tenth!=0 && unit!=0)
        {
            if (number%100>=10 && number%100<=19)
            {
                numberAsWord = UpperUnits[hundred] + " hundred and " + units[number % 100];
            }
            else
            {
                numberAsWord = UpperUnits[hundred] + " hundred and " + tenths[tenth] + " " + units[unit]; 
            }
        }
        Console.WriteLine(numberAsWord);
        Main();
    }
}

