﻿using System;

namespace _02_RadiansToDegrees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());

            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}
