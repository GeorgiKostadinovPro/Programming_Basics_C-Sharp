using System;

namespace _09_GreeningFields
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double finalPrice = area * 7.61;
            double discount = finalPrice * 0.18;
            finalPrice -= discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
