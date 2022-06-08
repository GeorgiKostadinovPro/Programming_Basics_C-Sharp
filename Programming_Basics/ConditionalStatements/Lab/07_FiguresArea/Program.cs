using System;

namespace _07_FiguresArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            float firstSide = float.Parse(Console.ReadLine());
            float area = 0;

            switch (figure)
            {
                case "square":
                    area = firstSide * firstSide;
                    break;
                case "rectangle":
                    float secondSide = float.Parse(Console.ReadLine());
                    area = firstSide * secondSide;
                    break;
                case "circle":
                    area = (float)(firstSide * firstSide * 3.14);
                    break;
                case "triangle":
                    float height = float.Parse(Console.ReadLine());
                    area = firstSide * height / 2;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
