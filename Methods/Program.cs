using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetResult(ShowMenu(), GetUserVals()));
        }

        private static double GetResult(string choice, List<double> values)
        {
            switch (choice)
            {
                case "1":
                    return Sum(values[0], values[1]);
                case "2":
                    return Subtract(values[0], values[1]);
                case "3":
                    return Divide(values[0], values[1]);
                case "4":
                    return Multiply(values[0], values[1]);
                default:
                    return 0.0;
                    break;
            }
        }

        private static List<double> GetUserVals()
        {
            List<double> values = new List<double>();

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Enter value {i + 1}:");
                values.Add(Convert.ToDouble(Console.ReadLine()));
            }
            return values;
        }
        private static string ShowMenu()
        {
            Console.WriteLine("1. Add\n2.Delete\n3.Divide\n4.Multiply\nEnter choice (x to exit):");
            string choice = Console.ReadLine();
            return choice;
        }

        private static double Sum(double a, double b)
        {
            return a + b;
        }
        
        private static double Divide(double a, double b)
        {
            return a / b;
        }     

        private static double Multiply(double a, double b)
        {
            return a * b;
        }
        
        private static double Subtract(double a, double b)
        {
            return a - b;
        }

    }
}
