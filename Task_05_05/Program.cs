namespace Task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
             * случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
             * по следующему правилу:
             * Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
             * Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
             */

            Console.Write("Введите n колличество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите m колличество столбцов: ");
            int m = int.Parse(Console.ReadLine());

            int[,] mass = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = random.Next(-99, 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mass[i, j] < 0)
                    {
                        mass[i, j] = Math.Abs(mass[i, j]);
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (mass[i, j] == 0)
                    {
                        mass[i, j] = random.Next(-99, 0);
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write(mass[i, j] + "\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }
        }
    }
}
