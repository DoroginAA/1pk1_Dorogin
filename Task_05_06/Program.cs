namespace Task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Осуществить генерация двумерного [10*5] массива по следующему правилу:
             * • 1 столбец содержит нули
             * • 2 столбце содержит числа кратные 2
             * • 3 столбец содержит числа кратные 3
             * • 4 столбец содержит числа кратные 4
             * • 5 столбец содержит числа кратные 5
             * Осуществить транспонирование массива и вывести обновленные данные.
             */

            //создадим массив 
            Console.WriteLine("Создаём пустой массив:");
            int[][] mass = new int[10][];
            mass[0] = new int[5];
            mass[1] = new int[5];
            mass[2] = new int[5];
            mass[3] = new int[5];
            mass[4] = new int[5];
            mass[5] = new int[5];
            mass[6] = new int[5];
            mass[7] = new int[5];
            mass[8] = new int[5];
            mass[9] = new int[5];

            //выведем массив
            foreach (int[] i in mass)
            {
                foreach (int massy in i)
                {
                    Console.Write($"{massy} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //заполним массив нужными числами
            Console.WriteLine("Массив заполняем по условию:");
            for (int i = 0; i < 10; i++)
            {
                for (int colly = 0; colly < 5; colly++)
                {
                    //столбец нулей
                    if (colly == 0)
                    {
                        mass[i][colly] = 0;
                    }
                    //столбец кратных 2
                    else if (colly == 1)
                    {
                        mass[i][colly] = (i + 1) * 2;
                    }
                    //столбец кратных 3
                    else if (colly == 2)
                    {
                        mass[i][colly] = (i + 1) * 3;
                    }
                    //столбец кратных 4
                    else if (colly == 3)
                    {
                        mass[i][colly] = (i + 1) * 4;
                    }
                    //столбец кратных 5
                    else if (colly == 4)
                    {
                        mass[i][colly] = (i + 1) * 5;
                    }
                }
            }

            //выведем массив
            foreach (int[] i in mass)
            {
                foreach (int massy in i)
                {
                    Console.Write($"{massy} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //объявим новый массив для транспонирования
            Console.WriteLine("Транспонируемый массив:");
            int[,] mass2 = new int[5, 10];
            /*mass2[0] = new int[10];
            mass2[1] = new int[10];
            mass2[2] = new int[10];
            mass2[3] = new int[10];
            mass2[4] = new int[10];*/

            //транспонируем массив 
            for (int i = 0; i < mass2.GetLength(0); i++)
            {
                for (int colly = 0; colly < mass2.GetLength(1); colly++)
                {
                    mass2[i, colly] = mass[colly][i];
                    //выводим
                    Console.Write(mass2[i, colly] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
