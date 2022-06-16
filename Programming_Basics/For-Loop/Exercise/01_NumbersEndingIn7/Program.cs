using System;

namespace _01_NumbersEndingIn7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                  Console.WriteLine(i);
                }
            }
        }
    }
}
