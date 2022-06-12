using System;

namespace _05_SuppliesForSchool
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double pensCost = pens * 5.80;
            double markersCost = markers * 7.20;
            double litersCost = liters * 1.20;
            double TotalCost = pensCost + markersCost + litersCost;

            double discountNumber = discount / 100;

            double finalPrice = (TotalCost - (TotalCost * discountNumber));

            Console.WriteLine(finalPrice);
        }
    }
}
