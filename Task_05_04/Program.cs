namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
             * диагональной (все элементы вне главной диагонали равны нулю)
             * Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
             * сообщение что матрица не является диагональной. 
             */

            Console.WriteLine("Введите n размер матрицы: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mass = new int[n, n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = random.Next(0, 10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }

            bool line = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && mass[i, j] != 0)
                    {
                        line = false;
                    }
                }
            }

            if (line == true)
            {
                Console.WriteLine("Матрица диагональная:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(mass[i, j] + "\t");
                    }
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            else
            {
                Console.WriteLine("Матрица не диагональная!");
            }
        }
    }
}
