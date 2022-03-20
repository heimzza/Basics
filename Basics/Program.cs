using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 to 100 in ascending order
            PrintOneToNumberWithOrder(100, true);

            //1 to 100 in descending order
            PrintOneToNumberWithOrder(100, false);

            // test for all 3 sum methods and print
            TestSumMethods(90);
        }

        static void PrintOneToNumberWithOrder (int number, bool isAscending = true)
        {
            if (isAscending)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = number; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // sum of 1 to number using math
        public static int Sum(int n)
        {
            return n * (n + 1) / 2;
        }

        // sum of 1 to number using for loop
        public static int Sum_A(int n)
        {
            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        // sum of 1 to number using LINQ
        public static int Sum_B(int n)
        {
            List<int> numbersList = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbersList.Add(i);
            }

            return numbersList.Sum();
        }

        // test all 3 sum methods and print
        public static void TestSumMethods(int n)
        {
            Console.WriteLine("\nTest for sum methods;");
            Console.WriteLine("(Using math formula) Sum({0}): {1}", n, Sum(n).ToString());
            Console.WriteLine("(Using for loop) Sum_A({0}): {1}", n, Sum_A(n).ToString());
            Console.WriteLine("(Using LINQ) Sum_B({0}): {1}", n, Sum_B(n).ToString());
        }
    }
}
