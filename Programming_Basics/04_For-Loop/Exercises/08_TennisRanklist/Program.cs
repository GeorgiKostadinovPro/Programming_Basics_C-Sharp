using System;

namespace _08_TennisRanklist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numTour = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            double sumW = 0;
            double sumF = 0;
            double sumSf = 0;
            double numW = 0;

            for (int i = 0; i < numTour; i++)
            {
                string lvl = Console.ReadLine();

                if (lvl == "W")
                {
                    sumW += 2000;
                    numW++;
                }
                else if (lvl == "F")
                {
                    sumF += 1200;
                }
                else if (lvl == "SF")
                {
                    sumSf += 720;
                }
            }

            double prWins = numW / numTour * 100;
            double sumFromTour = sumSf + sumW + sumF;
            double allPoints = sumSf + sumW + sumF + startPoints;
            double averagePoints = Math.Floor(sumFromTour / numTour);

            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{prWins:f2}%");
        }
    }
}