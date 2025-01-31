namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
           * да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
           * элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны).  
           */

            char[,] mass = new char[3, 3];
            char[,] mass2 = new char[3, 3];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mass[i, j] = (char)random.Next('A', 'Z' + 1);
                    mass2[i, j] = (char)random.Next('A', 'Z' + 1);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{mass[i, j]}");
                }
                Console.Write($"\t");


                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{mass2[i, j]}");
                }
                Console.Write($"\t");

                Console.WriteLine();
            }
            Console.WriteLine("->");

            int mass3 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mass[i, j].Equals(mass2[i, j]))
                    {
                        mass3++;
                    }

                }
            }

            if (mass3 == 9)
            Console.WriteLine("матрицы равны друг другу!");


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mass[i, j].Equals(mass2[i, j]))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write($"{mass[i, j]}");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Write($"\t");


                for (int j = 0; j < 3; j++)
                {
                    if (mass[i, j].Equals(mass2[i, j]))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write($"{mass2[i, j]}");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Write($"\t");
            }
        }
    }
}
