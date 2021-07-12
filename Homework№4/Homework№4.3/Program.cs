using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._3
{
    class Program
    { 
        //Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
        //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод,
        //принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
        //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. Если введено некорректное число,
        //вывести в консоль текст «Ошибка: введите число от 1 до 12».

        static void Main(string[] args)
        {
            Console.Write("Ведите номер месяца, от 1 до 12: ");
            ConclusionCheckМonths();

        }
        static void ConclusionCheckМonths()
        {
            while (true)
            {
                if (!Int32.TryParse(Console.ReadLine(), out int season))// проверна ни число
                {
                    Console.Write("Ошибка: введите число, а не символ: ");
                    while (!Int32.TryParse(Console.ReadLine(), out season))//цикл пока не не введешь число 
                    {

                        Console.Write("Ошибка: введите число, а не символ: ");
                        break;
                    }
                    if (season >= 1 && season <= 12)
                    {
                        Console.WriteLine($"время года {season}: {(Мonths)season}");
                        break;
                    }
                }
                else if (!(season >= 1 && season <= 12)) // если было введено не чило, а после введено число не от 1 до 12 то прочит ввести правельный месяц
                {
                    Console.Write($"Ошибка: месяца под номером {season} несуществует. Введите еще раз: ");
                    while (Int32.TryParse(Console.ReadLine(), out season))
                    {
                        Console.Write($"Ошибка: месяца под номером {season} несуществует. Введите еще раз: ");
                        break;
                    }
                    if (season >= 1 && season <= 12)
                    {
                        Console.WriteLine($"время года {season}: {(Мonths)season}");
                        break;
                    }
                }


            }
        }
    }
}

