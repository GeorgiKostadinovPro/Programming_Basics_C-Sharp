using System;

namespace _03_OscarsWeekInCinema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string type = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());

            double totalSum = 0.0D;

            if (type == "normal")
            {
                if (name == "A Star Is Born")
                {
                    totalSum = ticketsCount * 7.50;
                }
                else if (name == "Bohemian Rhapsody")
                {
                    totalSum = ticketsCount * 7.35;
                }
                else if (name == "Green Book")
                {
                    totalSum = ticketsCount * 8.15;
                }
                else if (name == "The Favourite")
                {
                    totalSum = ticketsCount * 8.75;
                }
            }
            else if (type == "luxury")
            {
                if (name == "A Star Is Born")
                {
                    totalSum = ticketsCount * 10.50;
                }
                else if (name == "Bohemian Rhapsody")
                {
                    totalSum = ticketsCount * 9.45;
                }
                else if (name == "Green Book")
                {
                    totalSum = ticketsCount * 10.25;
                }
                else if (name == "The Favourite")
                {
                    totalSum = ticketsCount * 11.55;
                }
            }
            else if (type == "ultra luxury")
            {
                if (name == "A Star Is Born")
                {
                    totalSum = ticketsCount * 13.50;
                }
                else if (name == "Bohemian Rhapsody")
                {
                    totalSum = ticketsCount * 12.75;
                }
                else if (name == "Green Book")
                {
                    totalSum = ticketsCount * 13.25;
                }
                else if (name == "The Favourite")
                {
                    totalSum = ticketsCount * 13.95;
                }
            }

            Console.WriteLine($"{name} -> {totalSum:f2} lv.");
        }
    }
}
