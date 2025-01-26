namespace Task_03_04
{
    internal class Program
    {
        /*Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда
         *пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
         *введенных пользователем
         */
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
