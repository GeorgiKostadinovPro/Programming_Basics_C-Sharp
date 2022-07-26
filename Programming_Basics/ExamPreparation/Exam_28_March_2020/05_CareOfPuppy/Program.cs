using System;

namespace _05_CareOfPuppy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            foodQuantity *= 1000;
            int eaten = 0;
            string line;

            while ((line = Console.ReadLine()) != "Adopted")
            {
                int gramsEatenPerDinner = int.Parse(line);
                eaten += gramsEatenPerDinner;
            }

            if (foodQuantity >= eaten)
            {
                foodQuantity -= eaten;
                Console.WriteLine($"Food is enough! Leftovers: {foodQuantity} grams.");
            }
            else
            {
                eaten -= foodQuantity;
                Console.WriteLine($"Food is not enough. You need {eaten} grams more.");
            }
        }
    }
}
