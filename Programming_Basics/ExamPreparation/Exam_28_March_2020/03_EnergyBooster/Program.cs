using System;

namespace _03_EnergyBooster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orderSets = Int32.Parse(Console.ReadLine());

            double fruitPrice = 0;
            double sizeNumber = 0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    sizeNumber = 2;
                    fruitPrice = 56;
                }
                else if (size == "big")
                {
                    sizeNumber = 5;
                    fruitPrice = 28.7;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    sizeNumber = 2;
                    fruitPrice = 36.66;
                }
                else if (size == "big")
                {
                    sizeNumber = 5;
                    fruitPrice = 19.6;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    sizeNumber = 2;
                    fruitPrice = 42.1;
                }
                else if (size == "big")
                {
                    sizeNumber = 5;
                    fruitPrice = 24.8;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    sizeNumber = 2;
                    fruitPrice = 20;
                }
                else if (size == "big")
                {
                    sizeNumber = 5;
                    fruitPrice = 15.2;
                }
            }
            double result = sizeNumber * fruitPrice * orderSets;

            if (result >= 400 && result <= 1000)
            {
                result *= 0.85;
            }
            else if (result > 1000)
            {
                result *= 0.5;
            }

            Console.WriteLine($"{result:f2} lv.");
        }
    }
}
