using System;

namespace _04_CinemaVoucher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int vaucher = int.Parse(Console.ReadLine());
            int sum = 0;
            int tickets = 0;
            int otherStuff = 0;

            string name = Console.ReadLine();

            while (name != "End")
            {

                if (name == "End")
                {
                    break;
                }

                if (name.Length > 8)
                {
                    int one = name[0];
                    int two = name[1];
                    sum = one + two;
                    if (vaucher - sum < 0)
                    {
                        break;
                    }
                    else
                    {
                        tickets++;
                        vaucher -= sum;
                    }
                }
                else
                {
                    int one1 = name[0];
                    sum = one1;
                    if (vaucher - sum < 0)
                    {
                        break;
                    }
                    else
                    {
                        otherStuff++;
                        vaucher -= sum;
                    }
                }

                name = Console.ReadLine();
            }

            Console.WriteLine(tickets);
            Console.WriteLine(otherStuff);
        }
    }
}
