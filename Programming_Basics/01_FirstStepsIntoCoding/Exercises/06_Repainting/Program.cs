using System;

namespace _06_Repainting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int bags = int.Parse(Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hoursToFinish = int.Parse(Console.ReadLine());

            double bagsSum = (bags + 2) * 1.50;
            double paintSum = (quantity + quantity * 0.10) * 14.50;
            double diluentSum = diluent * 5.00;

            double totalSumforMaterials = bagsSum + paintSum + diluentSum + 0.40;
            double workersSum = (totalSumforMaterials * 0.30) * hoursToFinish;
            double totalSum = totalSumforMaterials + workersSum;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
