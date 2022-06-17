using System;

namespace _08_Graduation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int countYears = 0;
            int endCounter = 0;
            double averageGrade = 0.0D;
            bool haveGraduated = true;

            while (countYears < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                averageGrade += grade;

                if (grade < 4)
                {
                    endCounter++;   
                }

                if (endCounter > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {countYears} grade");
                    haveGraduated = false;
                    break;
                }

                countYears++;
            }

            if (haveGraduated)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(averageGrade / 12):F2}");
            }
        }
    }
}
