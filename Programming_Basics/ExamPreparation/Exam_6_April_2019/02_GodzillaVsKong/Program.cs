using System;

namespace _02_GodzillaVsKong
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double pricePerPerson = double.Parse(Console.ReadLine());

            double decoration = budget * 0.10;
            double clothesSum = people * pricePerPerson;
            double total = 0;
            double neededLeft = 0;
            double promotion = 0;

            if (people > 150)
            {
                promotion = clothesSum * 0.10;
                neededLeft = clothesSum - promotion;
                total = neededLeft + decoration;
            }
            else
            {
                clothesSum = people * pricePerPerson;
                total = clothesSum + decoration;
            }

            if (total > budget)
            {
                double needed = total - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needed:f2} leva more.");
            }
            else
            {
                double left = budget - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {left:f2} leva left.");
            }
        }
    }
}
