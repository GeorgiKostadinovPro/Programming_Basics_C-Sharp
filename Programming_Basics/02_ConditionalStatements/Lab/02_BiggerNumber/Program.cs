using System;

namespace _02_BiggerNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(n, m));
        }
    }
}
