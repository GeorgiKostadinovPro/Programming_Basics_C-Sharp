using System;

namespace _05_SpecialNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1111; num <= 9999; num++)
            {
                int curr = num;
                bool isSpecial = true;

                for (int i = 0; i < 4; i++)
                {
                    int digit = curr % 10;
                    if (digit == 0 || n % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    curr /= 10;
                }

                if (isSpecial)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
