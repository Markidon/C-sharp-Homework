using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__________________________________________________");
            int n = int.Parse(Console.ReadLine()), count = 0, sum = 0;
            while (n != 0)
            {
                sum += n;
                count++;
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine((double)sum / count);
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("Введите введите номер месяца от 1 до 12");
            var month_number = Console.ReadLine();

            switch (month_number)
            {
                case "1":
                    Console.WriteLine("первый весяц - явнварь");  
                    break;
                case "2":
                    Console.WriteLine("второй месяц - февраль");
                    break;
                case "3":
                    Console.WriteLine("третий месяц - март");
                    break;
                case "4":
                    Console.WriteLine("четвертый месяц - апрель");
                    break;
                case "5":
                    Console.WriteLine("пятый месяц - май");
                    break;
                case "6":
                    Console.WriteLine("шестой месяц - июнь");
                    break;
                case "7":
                    Console.WriteLine("седьмой месяц - июль");
                    break;
                case "8":
                    Console.WriteLine("восьмой месяц - август");
                    break;
                case "9":
                    Console.WriteLine("девятый месяц - сентябрь");
                    break;
                case "10":
                    Console.WriteLine("десятый месяц - октябрь");
                    break;
                case "11":
                    Console.WriteLine("одиннаднатый месяц - ноябрь");
                    break;
                case "12":
                    Console.WriteLine("двенадцатый месяц - декабрь");
                    break;
                default:
                    Console.WriteLine("такого месяца не существует");
                    break;
            }
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("введите число");
            Console.WriteLine("пройдет проверка на четное или не четное число");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 1)
            {
                Console.WriteLine($"число {a} - четное");
            }
            else
            {
                Console.WriteLine($"число {a} - не четное");
            }
            Console.WriteLine("__________________________________________________");


        }
    }
}
