using System;

namespace _05_AccountBalance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();
            double sum = 0.0D;

            while (line != "NoMoreMoney")
            {
                double number = double.Parse(line);

                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                sum += number;
                Console.WriteLine($"Increase: {number:F2}");

                line = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
