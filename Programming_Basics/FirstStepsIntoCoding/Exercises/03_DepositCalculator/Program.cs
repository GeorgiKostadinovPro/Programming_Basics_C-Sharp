using System;

namespace _03_DepositCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double yearPercentage = double.Parse(Console.ReadLine());

            double result = depositSum + term * ((depositSum * (yearPercentage / 100)) / 12);

            Console.WriteLine($"{result:f2}");

        }
    }
}
