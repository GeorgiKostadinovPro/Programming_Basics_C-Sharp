using System;

namespace _05_Salary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int counttabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int n = 0; n < counttabs; n++)
            {
                string website = Console.ReadLine();

                switch (website)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
