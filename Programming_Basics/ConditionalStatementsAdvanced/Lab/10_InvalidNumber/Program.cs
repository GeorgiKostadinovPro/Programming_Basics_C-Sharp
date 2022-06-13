using System;

namespace _10_InvalidNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 100 || num > 200)
            {
                if (num != 0)
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
