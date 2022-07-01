using System;

namespace _09_LeftAndRightSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < n * 2; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i >= n)
                {
                    leftSum += number;
                }
                else 
                {
                    rightSum += number;
                }
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else 
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}
