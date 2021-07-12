using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._2
{
    class Program
    {
        // Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
        // и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран.
        static void Main(string[] args)
        {
            Console.Write("Ведите числа через пробел: ");

            string nambers = Console.ReadLine();
            string[] temp = nambers.Split(new Char[] { ' ' });
            int sum = 0;
            foreach (var item in temp)
            {
                sum += ParseLine(item);
            }
            if (sum >= 0)
                { 
                Console.WriteLine($"сумма всех чисел = {sum}");
            }

            Console.ReadKey();
        }
        static int ParseLine(string line)
        {
           
            if (!Int32.TryParse(line, out int namber) || namber < 0) 
            { 
                Console.WriteLine("Ошибка: ты ввел не число, тебе должно быть стыдно!!!"); 
            }
            // иногда выводит не так как надо
            // потом подумаю как исправить
            return namber;
        }
    }
}
