using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._2
{
    // Запросить у пользователя порядковый номер текущего месяца и вывести его название.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца от 1 до 12: ");

            bool namberMonth = Int32.TryParse(Console.ReadLine(), out int month);
            ProverkaNamberMonth(month);
            Console.WriteLine("Программа завершина ");

            Console.ReadKey();
        }
        static int ProverkaNamberMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {

                Console.WriteLine($"заебись месяц {month} это: {(Season)month} ");
            }
            else
            {
                Console.WriteLine("Ошибка. Введите от 1 до 12");
                Console.Write("Ведите еще раз: ");
                while (!Int32.TryParse(Console.ReadLine(), out month))
                {
                }
                if (month >= 1 && month <= 12)
                {
                    Console.WriteLine($"заебись месяц {month} это: {(Season)month} ");
                }
                else
                {
                    Console.WriteLine("Нет такого месяца");
                }
            }
            return month;

        }
    }   
 }


