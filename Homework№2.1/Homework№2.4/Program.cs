using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._4
{
    class Program
    {//* Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца от 1 до 12: ");
            bool Month = Int32.TryParse(Console.ReadLine(), out int namberMonth);
            CheckMonth(namberMonth);
            Console.Write("Введите средню температуру: ");
            bool averageTemperatгre = Int32.TryParse(Console.ReadLine(), out int namberAverageTemperature);
            CheckrAverageTemperature(namberAverageTemperature);

        }
        
        static int CheckMonth(int namberAverageTemperature)
        {
            if (namberAverageTemperature >= 1 && namberAverageTemperature <= 12)
            {
                Console.Write("Ведите еще раз: ");
                while (!Int32.TryParse(Console.ReadLine(), out namberAverageTemperature)) //зациеленный если число привышено 
                {
                    Console.WriteLine($"{namberAverageTemperature} месяц это - {(Season)namberAverageTemperature}");
                }

            }
            else
            {
                Console.WriteLine("Ошибка. Введите месяц от 1 до 12");
                Console.Write("Ведите еще раз: ");

                while (!Int32.TryParse(Console.ReadLine(), out namberAverageTemperature)) //зациеленный если число привышено 
                {
                    Console.WriteLine($"{namberAverageTemperature} месяц это - {(Season)namberAverageTemperature}");
                }
 
                
            }
            return namberAverageTemperature;

        }
        static int CheckrAverageTemperature(int namberAverageTemperature)
        {
            
                switch (namberMonth) 
                {
                    case (int)Season.Декабрь:
                    case (int)Season.Январь:
                    case (int)Season.Февраль:
                    if (namberAverageTemperature >0)
                    {
                        Console.WriteLine("дождливая зима");
                        Console.WriteLine("Программа завершина");
                    }
                        
                        break;
                    default:
                        Console.WriteLine("Программа завершина");
                        break;
                }
            
            return namberAverageTemperature;
        }
    }
}
