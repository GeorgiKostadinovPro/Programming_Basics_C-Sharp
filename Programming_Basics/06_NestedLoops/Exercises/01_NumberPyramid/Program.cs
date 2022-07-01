using System;

namespace _01_NumberPyramid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int curr = 1;
            bool isBigger = false;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (curr > n)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write(curr + " ");
                    curr++;
                }

                if (isBigger)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
