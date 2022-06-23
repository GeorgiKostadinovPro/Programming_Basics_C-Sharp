using System;

namespace _02_CatWalking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int walksCount = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            int totalWalk = walksCount * minutesWalk;
            int totalBurnedCalories = totalWalk * 5;
            int percentage = calories / 2;

            if (totalBurnedCalories >= percentage)
            {
                Console.WriteLine($"Yes, the walk for your cat is " +
                    $"enough. Burned calories per day: {totalBurnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. " +
                    $"Burned calories per day: {totalBurnedCalories}.");
            }
        }
    }
}
