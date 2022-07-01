using System;

namespace _07_MinNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int min = int.MaxValue;

            while (line != "Stop")
            {
                int number = int.Parse(line);

                if (number < min)
                {
                    min = number;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
