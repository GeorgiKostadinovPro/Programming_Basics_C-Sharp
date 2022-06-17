using System;

namespace _02_Password
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string guesser = Console.ReadLine();

            while (guesser != password)
            {
                guesser = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
