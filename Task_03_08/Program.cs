namespace Task_03_08
{
    internal class Program
    {
        /*Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5.
         */
        static void Main(string[] args)
        {
            int a = 20;
            Console.WriteLine("Среди чисел от 20 до 50 делятся на 3, но не делятся на 5: ");

            while(a < 50)
            {
                if (a % 3 == 0 && a %5 != 0)
                {   
                    Console.WriteLine(a);
                }
                a++;
            }
        }
    }
}
