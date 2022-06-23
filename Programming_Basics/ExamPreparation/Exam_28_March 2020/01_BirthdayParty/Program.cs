using System;

namespace _01_BirthdayParty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cakePrice = rent * 0.2;
            double drinksPrice = cakePrice - cakePrice * 0.45;
            double animatorPrice = rent / 3;
            double total = rent + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(total);
        }
    }
}
