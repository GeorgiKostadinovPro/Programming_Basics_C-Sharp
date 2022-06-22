using System;

namespace _06_CinemaTickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int students = 0;
            int old = 0;
            int kids = 0;

            while (name != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                int people = 0;

                for (int i = 0; i < freeSeats; i++)
                {
                    string input = Console.ReadLine();

                    if (input == "student")
                    {
                        students++;
                    }
                    else if (input == "kid")
                    {
                        kids++;
                    }
                    else if (input == "standard")
                    {
                        old++;
                    }
                    else if (input == "End")
                    {
                        break;
                    }
                    people++;
                }

                Console.WriteLine($"{name} - {(people * 1.0 / freeSeats * 100):f2}% full.");
                name = Console.ReadLine();
            }

            int total = old + kids + students;
            Console.WriteLine($"Total tickets: {total}");
            Console.WriteLine($"{(students * 1.0 / total * 100):f2}% student tickets.");
            Console.WriteLine($"{(old * 1.0 / total * 100):f2}% standard tickets.");
            Console.WriteLine($"{(kids * 1.0 / total * 100):f2}% kids tickets.");
        }
    }
}
