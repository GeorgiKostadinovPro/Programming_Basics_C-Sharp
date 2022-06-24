using System;

namespace _01_AgencyProfit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int childrenTickets = int.Parse(Console.ReadLine());
            double netAdultPrice = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double netChildPrice = netAdultPrice * 0.3;
            double priceAdultWithService = netAdultPrice + price;
            double priceChildWithService = netChildPrice + price;

            double total = (childrenTickets * priceChildWithService) + (adultTickets * priceAdultWithService);
            double result = total * 0.2;

            Console.WriteLine($"The profit of your agency from {name} tickets is {result:f2} lv.");
        }
    }
}
