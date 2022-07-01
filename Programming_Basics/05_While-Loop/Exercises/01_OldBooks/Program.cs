using System;

namespace _01_OldBooks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
           
            int countChechedBooks = 0;
            bool isFound = false;

            string nextBook = Console.ReadLine();

            while (nextBook != "No More Books")
            {
                if (nextBook == searchedBook)
                {
                    isFound = true;
                    break;
                }

                countChechedBooks++;
                nextBook = Console.ReadLine();
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {countChechedBooks} books and found it.");
            }
            else 
            { 
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countChechedBooks} books.");
            }
        }
    }
}
