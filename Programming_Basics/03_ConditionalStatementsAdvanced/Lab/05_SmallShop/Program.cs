using System;

namespace _05_SmallShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string produkt = Console.ReadLine()
                .ToLower();
            string sity = Console.ReadLine()
                .ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (sity == "sofia")
            {
                if (produkt == "coffee")
                {
                    Console.WriteLine(0.50 * quantity);
                }
                else if (produkt == "water")
                {
                    Console.WriteLine(0.80 * quantity);
                }
                else if (produkt == "beer")
                {
                    Console.WriteLine(1.20 * quantity);
                }
                else if (produkt == "sweets")
                {
                    Console.WriteLine(1.45 * quantity);
                }
                else if (produkt == "peanuts")
                {
                    Console.WriteLine(1.60 * quantity);
                }
            }
            else if (sity == "plovdiv")
            {
                if (produkt == "coffee")
                {
                    Console.WriteLine(0.40 * quantity);
                }
                else if (produkt == "water")
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else if (produkt == "beer")
                {
                    Console.WriteLine(1.15 * quantity);
                }
                else if (produkt == "sweets")
                {
                    Console.WriteLine(1.30 * quantity);
                }
                else if (produkt == "peanuts")
                {
                    Console.WriteLine(1.50 * quantity);
                }
            }
            else if (sity == "varna")
            {
                if (produkt == "coffee")
                {
                    Console.WriteLine(0.45 * quantity);
                }
                else if (produkt == "water")
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else if (produkt == "beer")
                {
                    Console.WriteLine(1.10 * quantity);
                }
                else if (produkt == "sweets")
                {
                    Console.WriteLine(1.35 * quantity);
                }
                else if (produkt == "peanuts")
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }
        }
    }
}
