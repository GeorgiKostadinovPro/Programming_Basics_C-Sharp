using System;

namespace _04_MustLiterature
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double Pages = double.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            double HoursOfReading = numberOfPages / Pages;
            double HoursADay = HoursOfReading / numberOfDays;
            Console.WriteLine(Math.Floor(HoursADay));
        }
    }
}
