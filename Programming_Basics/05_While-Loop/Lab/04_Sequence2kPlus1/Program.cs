using System;

namespace _04_Sequence2kPlus1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currNumber = 1;

            while (currNumber <= n)
            {
                Console.WriteLine(currNumber);
                currNumber = currNumber * 2 + 1;
            }
        }
    }
}
