using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Please enter num a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter num b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter num c:");
        double c = double.Parse(Console.ReadLine());
        int counterSign = 0;

        if (a==0 || b==0 || c==0)
        {
            Console.WriteLine("Product is 0.");
        }
        else
        {
            if (a<0)
            {
                counterSign++;
            }
            if (b<0)
            {
                counterSign++;
            }
            if (c<0)
            {
                counterSign++;
            }
            if (counterSign%2==1)
            {
                Console.WriteLine("The sign of product is \"-\"");
            }
            else
            {
                Console.WriteLine("The sign of product is \"+\".");
            }
        }
        Main();
    }
}

