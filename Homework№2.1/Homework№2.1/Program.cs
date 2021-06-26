using System;

namespace Homework_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите минимальную температуру от -30°С до 0°С");
            int min_temaperatura = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Ведите максимальную температуру от +1°С до +36°С");
            int max_temaperatura = Convert.ToInt32(Console.ReadLine());
            int srednay_temperarura = (min_temaperatura+ max_temaperatura)/2;

                if (min_temaperatura >= -30 && min_temaperatura <= 0 && max_temaperatura >= 1 && max_temaperatura<=36)
                {
                    Console.WriteLine($"Минимальная температура - {min_temaperatura}°С ");
                    Console.WriteLine($"Максимальная температура - +{max_temaperatura}°С ");
                    if(srednay_temperarura < 0)
                    { 
                    Console.WriteLine($"Средняя температура - {srednay_temperarura}");
                    }
                    else
                    {
                        Console.WriteLine($"Средняя температура - +{srednay_temperarura}");
                    }
                }
                else
                {
                Console.WriteLine("Вы превысили максимальную или минимальную температуру");
                }

        }
    }
}
