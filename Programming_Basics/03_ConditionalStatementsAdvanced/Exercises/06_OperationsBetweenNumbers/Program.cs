using System;

namespace _06_OperationsBetweenNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double operation = 0.0;

            if (n2 != 0)
            {
                switch (symbol)
                {
                    case '+': operation = n1 + n2; break;
                    case '-': operation = n1 - n2; break;
                    case '*': operation = n1 * n2; break;
                    case '/':
                        operation = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {operation:F2}"); break;
                    case '%':
                        operation = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {operation}"); break;
                    default:
                        break;
                }
            }
            else if (n2 == 0)
            {
                switch (symbol)
                {
                    case '+': operation = n1 + n2; break;
                    case '-': operation = n1 - n2; break;
                    case '*': operation = n1 * n2; break;
                    case '/': Console.WriteLine($"Cannot divide {n1} by zero"); break;
                    case '%': Console.WriteLine($"Cannot divide {n1} by zero"); break;
                    default:
                        break;
                }
            }

            double checker = operation % 2;
            string checkerSymbol = "";

            if (checker == 0)
            {
                checkerSymbol = "even";
            }
            else
            {
                checkerSymbol = "odd";
            }


            switch (symbol)
            {
                case '+':
                    Console.WriteLine($"{n1} + {n2} = {operation} - {checkerSymbol}"); break;
                case '-':
                    Console.WriteLine($"{n1} - {n2} = {operation} - {checkerSymbol}"); break;
                case '*':
                    Console.WriteLine($"{n1} * {n2} = {operation} - {checkerSymbol}"); break;
                default:
                    break;
            }
        }
    }
    
}
