// Problem 13. Solve tasks
// Write a program that can solve these tasks:
//      Reverses the digits of a number
//      Calculates the average of a sequence of integers
//      Solves a linear equation a * x + b = 
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve
// Validate the input data
//      The decimal number should be non-negative
//      The sequence should not be empty
// a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _13.SolveTasks
{
    class SolveTasks
    {
        static void Main()
        {
            Console.WriteLine("1 - Reverses the digits of a number");
            Console.WriteLine("2 - Calculates the average of a sequence of integers");
            Console.WriteLine("3 - Solves a linear equation a * x + b = 0");
            Console.Write("Choose a task: ");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1: Reverese(); break;
                case 2: GetAverage(); break;
                case 3: SolvesTask(); break;
                default: Console.WriteLine("There is no such element on the menu");
                    break;
            }
        }

        private static void Reverese()
        {
            Console.WriteLine("Reverse digits\n".ToUpper());
            int number;
            bool numbersIsPossitive = true;
            do
            {
                if (!numbersIsPossitive)
                    Console.WriteLine("The number must be positive!");
                Console.Write("Enter an intger: ");
                number = int.Parse(Console.ReadLine());
                numbersIsPossitive = number > 0;
            } while (!numbersIsPossitive);
            long result = 0;
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            Console.WriteLine("Reversed: " + result);
        }

        private static void GetAverage()
        {
            Console.WriteLine("Get average\n".ToUpper());
            bool notEmpty = true;
            double[] numbers;
            do
            {
                if (!notEmpty)
                    Console.WriteLine("There sequence cannot be empty!");
                Console.WriteLine("Enter numbers, separated by a comma: ");
                numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToArray();
                notEmpty = numbers.Length > 0;
            } while (!notEmpty);
            double result = numbers.Sum() / numbers.Length;
            Console.WriteLine("Average: {0:F3}", result);
        }

        private static void SolvesTask()
        {
            Console.WriteLine("a * x + b = 0\n".ToUpper());
            double a;
            bool aIsNotZero = true;
            do
            {
                if (!aIsNotZero)
                    Console.WriteLine("A must be different than 0.");
                Console.Write("Enter A: ");
                a = double.Parse(Console.ReadLine());
                aIsNotZero = a != 0;
            } while (!aIsNotZero);
            Console.Write("Enter B: ");
            double b = double.Parse(Console.ReadLine());
            double result = -b / a;
            Console.WriteLine("X = {0:F3}", result);
        }
    }
}
