using System;

namespace _03_TimePlus15Minutes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            TimeSpan ts = new TimeSpan(hour, minutes, 0);

            if (ts.Minutes < 10)
            {
                Console.WriteLine($"{ts.Hours}:0{ts.Minutes}");
            }
            else 
            {
                Console.WriteLine($"{ts.Hours}:{ts.Minutes}");
            }
        }
    }
}
