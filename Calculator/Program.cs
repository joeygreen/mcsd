using System;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var control = "y";

            while (control.ToLower() == "y")
            {
                PromptForOperation();
                var operation = Console.ReadLine();
                var left = PromptForLeft();
                var right = PromptForRight();

                Console.WriteLine("\r\nAnswer: {0}", Run((Operations)int.Parse(operation), left, right));
                control = PromptForControl();
            }
        }

        static void PromptForOperation()
        {
            var prompt = new StringBuilder();
            prompt.AppendLine("\r\nPress any following key to perform an arithmetic operation:\r\n");
            prompt.AppendLine("1 - Addition");
            prompt.AppendLine("2 - Subtraction");
            prompt.AppendLine("3 - Multiplication");
            prompt.AppendLine("4 - Division");

            Console.WriteLine(prompt);
        }

        static string PromptForLeft()
        {
            Console.WriteLine("\r\nEnter Value 1:");
            return Console.ReadLine();
        }

        static string PromptForRight()
        {
            Console.WriteLine("\r\nEnter Value 2:");
            return Console.ReadLine();
        }

        static string PromptForControl()
        {
            Console.WriteLine("\r\nDo you want to continue again (Y/N)");
            return Console.ReadLine();
        }

        static int Run(Operations operation, string left, string right)
        {
            return Calculate(operation, int.Parse(left), int.Parse(right));
        }

        static int Calculate(Operations operation, int left, int right)
        {
            switch (operation)
            {
                case Operations.Addition:
                    return Add(left, right);
                case Operations.Subtraction:
                    return Subtract(left, right);
                case Operations.Multiplication:
                    return Multiply(left, right);
                case Operations.Division:
                    return Divide(left, right);
                default:
                    return 0;
            }
        }

        static int Add(int left, int right) => left + right;

        static int Subtract(int left, int right) => left - right;

        static int Multiply(int left, int right) => left * right;

        static int Divide(int left, int right) => left / right;

        enum Operations
        {
            Addition = 1,
            Subtraction,
            Multiplication,
            Division
        }
    }
}
