namespace Task_03_09
{
    internal class Program
    {
        /*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
         *отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
         *менее y рублей.
         *Примеры
         *входные данные
         *100
         *10
         *200
         *выходные данные
         *8
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальную сумму вклада (x):");
            double start = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите годовой процент (p):");
            double year = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите целевую сумму вклада (y):");
            double target = double.Parse(Console.ReadLine());

            int years = CalculateYears(start, year, target);

            Console.WriteLine(years);
        }

        static int CalculateYears(double start, double year, double target)
        {
            double Deposit = start;
            int years = 0;

            while (Deposit < target)
            {
                Deposit = Deposit * (1 + year / 100.0);

                Deposit = Math.Floor(Deposit);

                years++;
            }

            return years;
        }
    }
}
