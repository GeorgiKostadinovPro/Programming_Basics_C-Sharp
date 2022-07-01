using System;

namespace _01_USDToBGN
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());

            decimal BGN = money * 1.79549M;

            Console.WriteLine(BGN);
        }
    }
}
