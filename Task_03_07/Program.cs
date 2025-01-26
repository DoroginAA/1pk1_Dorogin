namespace Task_03_07
{
    internal class Program
    {
        /* Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t ,
         *где 2 g = 9,8 м/с2 – ускорение свободного падения.
         */
        static void Main(string[] args)
        {
            Console.Write("Введите промежуток времени падения тела: ");
            var t = Int32.Parse(Console.ReadLine());
            t++;
            double t1 = 0.5;
            double t2 = 0;
            while(t2 < t)
            {
                double g = 9.8;
                double v = g * t2;
                Console.WriteLine($"t = {t2} с; V = {v} м/с.");
                t2++;
            }
        }
    }
}
