using System;
using System.Collections.Generic;

namespace _02_EqualSumsEvenOddPosition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int num = n; num <= m; num++)
            {
                var even = 0;
                var odd = 0;
                var newNum = num.ToString();

                for (int i = 0; i < newNum.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        even += newNum[i] - '0';
                    }
                    else
                    {
                        odd += newNum[i] - '0';
                    }
                }

                if (even == odd)
                {
                    nums.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
