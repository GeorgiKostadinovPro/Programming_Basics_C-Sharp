using System;

namespace _06_Cake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            int wholeCake = cakeLength * cakeWidth;
            int piecesTaken = 0;

            string pieces = Console.ReadLine();

            while (pieces != "STOP")
            {
                piecesTaken = int.Parse(pieces);
                wholeCake -= piecesTaken;

                if (wholeCake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(wholeCake)} pieces more.");
                    break;
                }

                pieces = Console.ReadLine();
            }
            if (pieces == "STOP")
            {
                Console.WriteLine($"{wholeCake} pieces are left.");
            }
        }
    }
}
