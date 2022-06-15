using System;

namespace _05_CharacterSequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i ++)
            {
                if (i % 2 == 0)
                {
                   Console.WriteLine(Math.Pow(2, i));
                }
            }
        }
    }
}
