using System;

namespace _06_Building
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());

            for (int i = floors; i > 0; i--)
            {
                for (int j = 0; j < apartments; j++)
                {
                    if (i == floors)
                    {
                        Console.Write($"L{i}{j} ");
                        continue;
                    }

                    if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else 
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
