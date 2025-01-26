namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var a = Console.ReadLine();
                if(a == "exit")
                {
                    break;
                }
                if (a == "")
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}
