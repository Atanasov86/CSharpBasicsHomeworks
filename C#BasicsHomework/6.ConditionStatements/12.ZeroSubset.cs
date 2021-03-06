﻿using System;

namespace _12.Zero_Subset
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            bool checkPairs = false;
            bool checkTriples = false;
            bool checkFours = false;
            checkPairs = CheckNumberPairs(a, b, c, d, e);
            checkTriples = CheckNumberTriples(a, b, c, d, e);
            checkFours = CheckNumberFours(a, b, c, d, e);
            if (a != 0 && b != 0 && c != 0 && d != 0 && e != 0)
            {
                PrintNumberPairs(a, b, c, d, e);
                PrintNumbersTriples(a, b, c, d, e);
                PrintNumbersFours(a, b, c, d, e);
                checkPairs = CheckNumberPairs(a, b, c, d, e);
                checkTriples = CheckNumberTriples(a, b, c, d, e);
                checkFours = CheckNumberFours(a, b, c, d, e);
            }
            if (a + b + c + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0", a, b, c, d, e);
            }
            if (a + b + c + d + e != 0 && (!(checkPairs || checkTriples ||
                 checkFours)))
            {
                Console.WriteLine("no zero subset");
            }
        }
        private static bool CheckNumberFours(int a, int b, int c, int d, int e)
        {
            bool checkNumbers = false;
            if (a + b + c + d == 0 || a + b + d + e == 0 ||
                a + b + c + e == 0 || b + c + d + e == 0 ||
                a + c + d + e == 0)
            {
                checkNumbers = true;
            }
            return checkNumbers;
        }
        private static bool CheckNumberTriples(int a, int b, int c, int d, int e)
        {
            bool checkNumbers = false;
            if (a + b + c == 0 || a + d + e == 0 || a + c + d == 0 || a + c + e == 0 || a + b + d == 0 || a + b + e == 0 ||
                b + c + d == 0 || b + c + e == 0 || b + d + e == 0 || c + d + e == 0)
            {
                checkNumbers = true;
            }
            return checkNumbers;
        }
        private static bool CheckNumberPairs(int a, int b, int c, int d, int e)
        {
            bool checkNumbers = false;
            if (a + b == 0 || b + c == 0 || c + d == 0 || d + e == 0 || b + d == 0 || b + e == 0 || c + e == 0 || c + a == 0 || d + a == 0 || e + a == 0)
            {
                checkNumbers = true;
            }
            return checkNumbers;
        }
        private static void PrintNumbersFours(int a, int b, int c, int d, int e)
        {
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, c, d);
            }
            if (a + b + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, d, e);
            }
            if (a + b + c + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, c, e);
            }
            if (b + c + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", b, c, d, e);
            }
            if (a + c + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, c, d, e);
            }
        }
        private static void PrintNumbersTriples(int a, int b, int c, int d, int e)
        {
            if (a + b + c == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b, c);
            }
            if (a + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, d, e);
            }
            if (a + c + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, c, d);
            }
            if (a + c + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, c, e);
            }
            if (a + b + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b, d);
            }
            if (a + b + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b, e);
            }
            if (b + c + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, c, d);
            }
            if (b + c + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, c, e);
            }
            if (b + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, d, e);
            }
            if (c + d + e == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", c, d, e);
            }
        }
        private static void PrintNumberPairs(int a, int b, int c, int d, int e)
        {
            if (a + b == 0)
            {
                Console.WriteLine("{0}+{1}=0", a, b);
            }
            if (b + c == 0)
            {
                Console.WriteLine("{0}+{1}=0", b, c);
            }
            if (c + d == 0)
            {
                Console.WriteLine("{0}+{1}=0", c, d);
            }
            if (d + e == 0)
            {
                Console.WriteLine("{0}+{1}=0", d, e);
            }
            if (b + d == 0)
            {
                Console.WriteLine("{0}+{1}=0", b, d);
            }
            if (b + e == 0)
            {
                Console.WriteLine("{0}+{1}=0", b, e);
            }
            if (c + e == 0)
            {
                Console.WriteLine("{0}+{1}=0", c, e);
            }
            if (d + a == 0)
            {
                Console.WriteLine("{0}+{1}=0", d, a);
            }
            if (e + a == 0)
            {
                Console.WriteLine("{0}+{1}=0", e, a);
            }
        }
    }
}
