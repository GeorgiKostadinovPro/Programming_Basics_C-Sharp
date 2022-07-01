using System;

namespace _01_ExcellentGrade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
