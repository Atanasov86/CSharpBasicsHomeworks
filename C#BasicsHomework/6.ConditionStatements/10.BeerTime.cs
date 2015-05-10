using System;
class BeerTime
{
    static void Main()
    {
        Console.Write("Please enter time in format (hh:mm tt): ");
        string inputTime = Console.ReadLine();
        string[] input = inputTime.Split(':', ' ');
        int hours = int.Parse(input[0]);
        int minutes = int.Parse(input[1]);
        string type = input[2];
        if ((hours >= 1 && hours< 12 && type =="PM") || (((hours <3 && hours >= 0) || hours==12) && type=="AM" ))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
        Main();
    }
}

