using System;

namespace _04_TrainTheTrainers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            double finalResult = 0.0;
            int gradeCount = 0;

            while (line != "Finish")
            {
                string name = line;
                double sum = 0.0;

                for (int i = 0; i < jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeCount++;
                    sum += grade;
                }

                double avg = sum / jury;
                Console.WriteLine($"{name} - {avg:f2}.");
                finalResult += sum;
                line = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {(finalResult / gradeCount):f2}.");
        }
    }
}
