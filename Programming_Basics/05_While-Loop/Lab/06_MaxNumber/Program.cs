using System;

namespace _06_MaxNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int max = int.MinValue;

            while (line != "Stop")
            {
                int number = int.Parse(line);

                if (number > max)
                {
                    max = number;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
