namespace Task_03_05
{
    internal class Program
    {
        /*Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
         *Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
         *время работы программы
         */
        static void Main(string[] args)
        {
            Console.WriteLine("введите диапазон изменения температуры в градусах Цельсия: ");
            Console.Write("от: ");
            var randsI = Int32.Parse(Console.ReadLine());
            Console.Write("до: ");
            var randsJ = Int32.Parse(Console.ReadLine());
            Console.WriteLine("сколько градусов изменяется за один шаг: ");
            var steps = Int32.Parse(Console.ReadLine());
            while (randsI < randsJ)
            {
                double far = randsI * 1.8 + 32.0;
                Console.WriteLine($"Градусы C: {randsI}; Градусы F: {far}.");
                randsI += steps;
            }
        }
    }
}
