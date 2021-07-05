using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._1
{
    class Program
    {
        //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

        static void Main(string[] args)
        {
            Console.Write("Ведите минимальную теипературу от -30 до 5 C°: ");
            bool minTemperatureTrue = Int32.TryParse(Console.ReadLine(), out int minTemperature); // ввод минимальной температуры
            PriverkaMinTemperature(minTemperature);

            Console.WriteLine();
            Console.Write("Ведите максимальную температуру от 5 до 30 C°: ");
            bool maxTemperatureTrue = Int32.TryParse(Console.ReadLine(), out int maxTemperature); // ввод максимальной температуры
            PriverkaMaxTemperature(maxTemperature);

            Console.WriteLine();
            Console.WriteLine("Все ведено вверно, спасибо. Расчитать среднюю температуру? Если да введите Yes если нет NO");
            Console.WriteLine("Если хотите выйти Go out");

            string prodolzhit = Console.ReadLine();
            bool yes = false;

            switch (prodolzhit)
            {
                case "Yes":
                    yes = true;
                    double averageTemperature = (double)(minTemperature + maxTemperature) / 2;
                    if (averageTemperature > 0)
                    {
                        Console.WriteLine($"Средняя температура: +{averageTemperature} C°");
                    }
                    else
                    {
                        Console.WriteLine($"Средняя температура: {averageTemperature} C°");
                    }
                    Console.WriteLine("Програма завершина");
                    break;
                case "No":
                    yes = false;
                    Console.WriteLine("Ну ладно, НЕТ так НЕТ");
                    Console.WriteLine("Програма завершина");
                    break;
                case "Go out":
                    yes = true;
                    Console.WriteLine("Програма завершина");
                    break;
                default:
                    // просто сгорела жопа)))
                    SgorelaZopa();
                    break;
            }

            Console.ReadKey();
        }
        static int PriverkaMinTemperature(int minTemperature)
        {
            if (minTemperature <= 5 && minTemperature >= -30) // проверка введенного числа 
            {
                Console.Write("Ведите еще раз: ");
                while (!Int32.TryParse(Console.ReadLine(), out minTemperature)) //зациеленный если введино не число  
                {
                    Console.WriteLine("Вы ввели недопустимый символ минимальной температуры!!! Попробуйте еще раз");
                    Console.WriteLine("Ведите минимальную температуру: ");
                }

            }
            else
            {
                Console.WriteLine("Привысели минимальную температуру, попробуйте снова!!! ");
                Console.Write("Ведите еще раз: ");
                while (!Int32.TryParse(Console.ReadLine(), out minTemperature)) //зациеленный если число привышено 
                {
                }
            }
            return minTemperature;
        }
        static int PriverkaMaxTemperature(int maxTemperature)
        {
            if (maxTemperature <= 30 && maxTemperature >= 5) // проверка введенного числа 
            {
                Console.Write("Ведите еще раз: ");
                while (!Int32.TryParse(Console.ReadLine(), out maxTemperature)) //зациеленный если введино не число 
                {
                    Console.WriteLine("Вы ввели недопустимый символ максимальной температуры!!! Попробуйте еще раз");
                    Console.WriteLine("Ведите максимальную температуру: ");
                }
            }
            else
            {
                Console.WriteLine("Привысели максимальную температуру, попробуйте снова!!! ");
                Console.Write("Ведите еще раз: ");
                while (!Int32.TryParse(Console.ReadLine(), out maxTemperature)) //зациеленный если число привышено
                {
                }
            }
            return maxTemperature;

            
        }
        static void SgorelaZopa()
        {
            Console.WriteLine();
            Console.WriteLine("Ты ввел неправелно.");
            Console.WriteLine();
            Console.WriteLine("Я бы попросил тебя ввести заново, так как ты неправельно ввел. ");
            Console.WriteLine("Но нме похуй я не понял как это сделать. можно было бы это все в цикл ебануть, ");
            Console.WriteLine("но в инете было сказанно что так и доантипаттерна не далеко");
            Console.WriteLine();
            Console.WriteLine("Антипаттерн(англ.anti - pattern) — это распространённый подход к решению класса часто встречающихся проблем, ");
            Console.WriteLine("являющийся неэффективным, рискованным или непродуктивным.");
            Console.WriteLine();
            Console.WriteLine("Спасибо большое за все, Програма завершина");

        }
    }
}

