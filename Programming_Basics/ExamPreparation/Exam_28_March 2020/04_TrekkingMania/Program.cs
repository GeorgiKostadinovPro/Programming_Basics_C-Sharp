using System;

namespace _04_TrekkingMania
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int totalPeople = 0;

            double musala = 0.0D;
            double monblanc = 0.0D;
            double kilimandjaro = 0.0D;
            double k2 = 0.0D;
            double everest = 0.0D;

            for (int i = 0; i < groups; i++)
            {
                int groupPeople = int.Parse(Console.ReadLine());
                totalPeople += groupPeople;

                if (groupPeople <= 5)
                {
                    musala += groupPeople;
                }
                else if (groupPeople >= 6 && groupPeople <= 12)
                {
                    monblanc += groupPeople;
                }
                else if (groupPeople >= 13 && groupPeople <= 25)
                {
                    kilimandjaro += groupPeople;
                }
                else if (groupPeople >= 26 && groupPeople <= 40)
                {
                    k2 += groupPeople;
                }
                else
                {
                    everest += groupPeople;
                }
            }

            Console.WriteLine($"{(musala / totalPeople * 100):f2}%");
            Console.WriteLine($"{(monblanc / totalPeople * 100):f2}%");
            Console.WriteLine($"{(kilimandjaro / totalPeople * 100):f2}%");
            Console.WriteLine($"{(k2 / totalPeople * 100):f2}%");
            Console.WriteLine($"{(everest / totalPeople * 100):f2}%");
        }
    }
}
