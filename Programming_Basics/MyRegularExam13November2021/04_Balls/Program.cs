using System;
using System.Text;

namespace _04_Balls
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int others = 0;
            int blackDivides = 0;
            int total = 0;

            for (int i = 0; i < balls; i++)
            {
                string colour = Console.ReadLine();

                if (colour == "red")
                {
                    total += 5;
                    red++;
                }
                else if (colour == "orange")
                {
                    total += 10;
                    orange++;
                }
                else if (colour == "yellow")
                {
                    total += 15;
                    yellow++;
                }
                else if (colour == "white")
                {
                    total += 20;
                    white++;
                }
                else if (colour == "black")
                {
                    total /= 2;
                    blackDivides++;
                }
                else
                {
                    others++;
                }
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Total points: {total}");
            sb.AppendLine($"Points from red balls: {red}");
            sb.AppendLine($"Points from orange balls: {orange}");
            sb.AppendLine($"Points from yellow balls: {yellow}");
            sb.AppendLine($"Points from white balls: {white}");
            sb.AppendLine($"Other colors picked: {others}");
            sb.AppendLine($"Divides from black balls: {blackDivides}");

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
