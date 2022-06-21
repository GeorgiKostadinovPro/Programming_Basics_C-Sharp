using System;

namespace _06_CinemaTickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int studentCount = 0;
            int standardCount = 0;
            int kidCount = 0;
            while (movie != "Finish")
            {
                var seats = int.Parse(Console.ReadLine());
                int movieTickets = 0;

                for (int i = 0; i < seats; i++)
                {
                    string ticket = Console.ReadLine();

                    if (ticket == "End")
                    {
                        break;
                    }
                    else if (ticket == "student")
                    {
                        studentCount++;
                    }
                    else if (ticket == "standard")
                    {
                        standardCount++;
                    }
                    else if (ticket == "kid")
                    {
                        kidCount++;
                    }

                    movieTickets++;
                }

                Console.WriteLine($"{movie} - {(double)movieTickets / seats * 100:f2}% full.");
                movie = Console.ReadLine();
            }

            int totalTickets = studentCount + standardCount + kidCount;
            string output = string.Format($"Total tickets: {totalTickets}\n" +
            $"{(double)studentCount / totalTickets * 100:f2}% student tickets.\n" +
            $"{(double)standardCount / totalTickets * 100:f2}% standard tickets.\n" +
            $"{(double)kidCount / totalTickets * 100:f2}% kids tickets.");
            Console.WriteLine(output);
        }
    }
}
