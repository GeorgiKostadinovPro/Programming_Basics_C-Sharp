using System;

namespace _05_MovieRatings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());
            double totalRating = 0.0D;

            double highestRating = 0.0D;
            double lowestRating = 11;
            string filmWithRating = string.Empty;
            string filmWithRating1 = string.Empty;

            for (int i = 0; i < movies; i++)
            {
                string name = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                totalRating += rating;

                if (rating > highestRating)
                {
                    highestRating = rating;
                    filmWithRating = name;
                }
                if (rating < lowestRating)
                {
                    lowestRating = rating;
                    filmWithRating1 = name;
                }
            }

            Console.WriteLine($"{filmWithRating} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{filmWithRating1} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {(totalRating / movies):f1}");
        }
    }
}
