﻿namespace Task_03_06
{
    internal class Program
    {
        /* Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥| для -4≤x≤4, с шагом h = 0,5.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Значения Y для X в промежутке -4 <= X <= 4 с шагом 0,5: ");

            double x = -4.5; 
            double h = 0.5;
            while(x < 4.0)
            {
                x += h;
                double funk = Math.Abs(x);
                Console.WriteLine($"X = {x}; Y  = {funk}.");
            }
        }
    }
}
