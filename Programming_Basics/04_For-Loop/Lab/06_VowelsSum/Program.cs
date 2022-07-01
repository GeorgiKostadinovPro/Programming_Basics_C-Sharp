using System;

namespace _06_VowelsSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < str.Length; i ++)
            {
                if (str[i] == 'a')
                {
                    sum += 1;
                }
                else if (str[i] == 'e')
                {
                    sum += 2;
                }
                else if (str[i] == 'i')
                {
                    sum += 3;
                }
                else if (str[i] == 'o')
                {
                    sum += 4;
                }
                else if (str[i] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
