using System;

namespace _01_OscarsCeremony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statuePrice = rent * 0.70;
            double cateringPrice = statuePrice * 0.85;
            double SoundPrice = (cateringPrice) * 1 / 2;
            double Total = rent + statuePrice + cateringPrice + SoundPrice;

            Console.WriteLine("{0:f2}", Total);
        }
    }
}
