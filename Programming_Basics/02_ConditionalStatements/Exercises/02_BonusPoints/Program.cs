using System;

namespace _02_BonusPoints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            double bonus = 0.0D;

            if (start <= 100)
            {
                bonus += 5;
            }
            else if (start > 100 && start <= 1000)
            {
                bonus += 0.2 * start;
            }
            else if (start > 1000)
            {
                bonus += 0.1 * start;
            }

            if (start % 2 == 0)
            {
                bonus += 1;
            }

            if (start.ToString().EndsWith("5"))
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(start + bonus);
        }
    }
}
