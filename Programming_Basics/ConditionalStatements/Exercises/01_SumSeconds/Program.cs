using System;

namespace _01_SumSeconds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());

            int sum = first + second + last;

            int minutes = sum / 60;
            int seconds = sum % 60;

            if (seconds >= 10)
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            else 
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
        }
    }
}
