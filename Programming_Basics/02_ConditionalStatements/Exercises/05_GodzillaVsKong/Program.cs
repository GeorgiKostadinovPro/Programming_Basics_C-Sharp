using System;

namespace _05_GodzillaVsKong
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceForOneStatists = double.Parse(Console.ReadLine());

            double decoration = budget * 0.1;

            if (statists > 150)
            {
                priceForOneStatists -= priceForOneStatists * 0.1;
            }

            double total = decoration + (statists * priceForOneStatists);

            if (total <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - total):F2} leva left.");
            }
            else 
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - total):F2} leva more.");
            }
        }
    }
}
