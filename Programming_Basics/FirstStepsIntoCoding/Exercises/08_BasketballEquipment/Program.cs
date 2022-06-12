using System;

namespace _08_BasketballEquipment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double yearPriceForBasketballTraining = double.Parse(Console.ReadLine());
            double basketballShoes = yearPriceForBasketballTraining - yearPriceForBasketballTraining * 0.40;
            double basketballOutfit = basketballShoes - basketballShoes * 0.20;
            double basketBall = basketballOutfit * 0.25;
            double baskeballAccessories = basketBall * 0.20;
            double totalPrice = yearPriceForBasketballTraining + basketballShoes + basketballOutfit + basketBall + baskeballAccessories;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
