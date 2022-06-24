using System;

namespace _02_MountainRun
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double distancePerMeter = double.Parse(Console.ReadLine());

            double time = distance * distancePerMeter;
            double increasedTime = Math.Floor(distance / 50) * 30;
            time += increasedTime;

            if (time < record)
            {
                Console.WriteLine($"Yes! The new record is {time:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(time - record):f2} seconds slower.");
            }
        }
    }
}
