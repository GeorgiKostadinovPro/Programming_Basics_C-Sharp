using System;

namespace _07_WorkingHours
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (10 <= hours && hours <= 18)
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;

                    case "Sunday":
                    default:
                        Console.WriteLine("closed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
