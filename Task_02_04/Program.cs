using System.ComponentModel.Design;

namespace Task_02_04
{
    internal class Program
    {
        /*
        *Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите
        *расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
        *этом.
        */
        static void Main(string[] args)
        {
            
            Console.WriteLine("введите год своего рождения: ");
            var YYu = int.Parse(Console.ReadLine());
            Console.WriteLine("введите месяц своего рождения: ");
            var MMu = int.Parse(Console.ReadLine());
            Console.WriteLine("введите день своего рождения: ");
            var DDu = int.Parse(Console.ReadLine());

            double a = DateTime.Now.Year;
            double b = DateTime.Now.Month;
            double c = DateTime.Now.Day;

            double d = a - YYu;
            if(b < MMu)
            {
                d--; 
            }
            else if(b == MMu)
            {
                if(c < DDu)
                {
                    d--;
                }
            }
            
            if((a - YYu) <= 18)
            {
                if ((a - YYu) == 18)
                {
                    if (b <= MMu)
                    {
                        if(b == MMu)
                        {
                            if (c <= DDu)
                            {
                                if(c == DDu)
                                {
                                    Console.WriteLine("Вы совершеннолетний!");
                                }
                                else
                                {
                                    Console.WriteLine($"Вам {d} лет!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы совершеннолетний!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Вам {d} лет!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы совершеннолетний!");
                    }
                }
                else
                {
                    Console.WriteLine($"Вам {d} лет!");
                }
            }
            else
            {
                Console.WriteLine("Вы совершеннолетний!");
            }
        }
    }
}
