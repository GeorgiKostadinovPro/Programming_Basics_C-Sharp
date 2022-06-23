using System;

namespace _06_TournamentOfChristmas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int dayCountSuccess = 0;
            int dayCountUnSuccess = 0;

            double totalMoney = 0;

            for (int i = 0; i < days; i++)
            {
                int successCount = 0;
                int unsuccessCount = 0;

                double raisePerDay = 0;

                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        successCount++;
                        raisePerDay += 20;
                    }
                    else if (result == "lose")
                    {
                        unsuccessCount++;
                    }

                    sport = Console.ReadLine();
                }

                if (successCount > unsuccessCount)
                {
                    raisePerDay += raisePerDay * 0.1;
                    dayCountSuccess++;
                }
                else
                {
                    dayCountUnSuccess++;
                }

                totalMoney += raisePerDay;

            }

            if (dayCountSuccess > dayCountUnSuccess)
            {
                totalMoney += totalMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
