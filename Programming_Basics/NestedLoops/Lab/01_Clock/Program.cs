﻿using System;

namespace _01_Clock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int h = 0; h < 24; h++)
            {
                for (int min = 0; min < 60; min++)
                {
                    Console.WriteLine($"{h:D2}:{min:D2}");
                }
            }
        }
    }
}
