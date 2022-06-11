using System;

namespace _08_Zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catfood = int.Parse(Console.ReadLine());

            double allFood = dogFood * 2.50 + catfood * 4;

            Console.WriteLine($"{allFood} lv.");
        }
    }
}
