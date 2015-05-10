using System;
class PlayWithInt_DoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                    Console.Write("Please enter an integer: ");
                    int num = int.Parse(Console.ReadLine());
                    num += 1;
                    Console.WriteLine("Result is {0}", num);
                    break;
                }
            case 2:
                {
                    Console.Write("Please enter a double: ");
                    double num = double.Parse(Console.ReadLine());
                    num += 1;
                    Console.WriteLine("Result is {0}",num);
                    break;
                }
            case 3:
                {
                    Console.Write("Please enter a string: ");
                    string input = Console.ReadLine();
                    input+="*";
                    Console.WriteLine("Result is {0}", input);
                    break;
                }
        }
    }
}

