using System;

namespace _04_PasswordGuesser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (str.Equals("s3cr3t!P@ssw0rd"))
            {
                Console.WriteLine("Welcome");
            }
            else 
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
