using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._3
{
    class Program
    { //Определить, является ли введённое пользователем число чётным.
        static void Main(string[] args)
        {
            Console.WriteLine("введите целое число. Программа проверит четное ли оно.");
            Console.Write("Ввод числа: ");
            bool namberTrue = Int32.TryParse(Console.ReadLine(), out int namber);
            ProverkaNaChotnoe(namber);

            Console.ReadKey();

        }
        static int ProverkaNaChotnoe(int namber)
        {
            if (namber % 2 ==0 )
            {
                Console.WriteLine($"Число {namber} четное") ;
            }
            else
            {
                Console.WriteLine($"Число {namber} нечетное");
            }
            return namber;
        }
    }
}
