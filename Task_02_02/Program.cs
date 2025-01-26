namespace Task_02_02
{
    internal class Program
    {
        /* найдите значение выражения при:
         * a=8 b=14 c=п/4
         */
        static void Main(string[] args)
        {
            double a = 8.0;
            double b = 14.0;
            double c = Math.PI/4.0;

            double ex1 = Math.Pow(a - 1.0, 1.0/3.0);
            double ex2 = Math.Sqrt(Math.Sqrt(b + ex1));
            double ex3 = Math.Pow(Math.Sin(c), 2);
            double ex4 = ex3 + Math.Tan(c);
            double ex5 = Math.Abs(a - b);
            double ex6 = ex5 * ex4;
            double ex7 = ex2 / ex6;

            Console.WriteLine(ex7);
        }
    }
}
