using System;

namespace _06_BarcodeGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            var firstStart = (int)(first / 1000);
            var secondStart = (int)(first / 100) % 10;
            var thirdStart = (int)(first / 10) % 10;
            var fourthStart = (int)(first % 10);

            var firstEnd = (int)(second / 1000);
            var secondEnd = (int)(second / 100) % 10;
            var thirdEnd = (int)(second / 10) % 10;
            var fourthEnd = (int)(second % 10);

            for (int i = firstStart; i < firstEnd + 1; i++)
            {
                for (int j = secondStart; j < secondEnd + 1; j++)
                {
                    for (int k = thirdStart; k < thirdEnd + 1; k++)
                    {
                        for (int l = fourthStart; l < fourthEnd + 1; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
