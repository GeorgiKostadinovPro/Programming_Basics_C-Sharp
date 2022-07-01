using System;

namespace _04_ToysShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());

            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double collectedMoney = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

            int orders = puzzles + dolls + bears + minions + trucks;

            if (orders >= 50)
            {
                collectedMoney -= collectedMoney * 0.25;
            }

            collectedMoney -= collectedMoney * 0.10;

            if (collectedMoney >= excursionPrice)
            {
                Console.WriteLine($"Yes! {(collectedMoney - excursionPrice):F2} lv left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! {Math.Abs(collectedMoney - excursionPrice):F2} lv needed.");
            }
        }
    }
}
