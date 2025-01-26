namespace Task_04_05
{
    internal class Program
    {
        /*В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее
         *количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
         *отдельно вывести дни без осадков. Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
         *осадков, до 300 мм выпавших осадков.
         */
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();
            int countZero = 0;
            int countRainfall = 0;
            int a = 0;
            int b = 0;
            Console.WriteLine("Количество осадков за месяц(30 дней)");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 300);
                countRainfall += array[i];
                if ((i + 1) % 10 == 0)
                {
                    a++;
                    Console.Write($"Общее количество осадков за {a} декаду: ");
                    Console.WriteLine(countRainfall);
                    countRainfall = 0;
                }
                if (array[i] > array[b])
                {
                    b = i;
                }
            }
            foreach (int i in array)
                if (i == 0)          
                {
                    countZero++;
                }
            Console.WriteLine(countZero != 0 ? $"Дней без осадков: {countZero}." : "Дней без осадков нет.");
            Console.WriteLine(b + " день с наибольшим значением количества осадков");
        }
    }
}
