using System;

namespace _01_Cinema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string cinema = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int full = rows * columns;
            double income = 0.0;
            switch (cinema)
            {
                case "Premiere":
                    income = full * 12.00;
                    Console.WriteLine($"{income:F2} leva");
                    break;
                case "Normal":
                    income = full * 7.50;
                    Console.WriteLine($"{income:F2} leva");
                    break;
                case "Discount":
                    income = full * 5.00;
                    Console.WriteLine($"{income:F2} leva");
                    break;
            }
        }
    }
}
