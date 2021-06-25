using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 1)
            {
                Console.WriteLine($"число {a} - четное");
            }
            else
            {
                Console.WriteLine($"число {a} - не четное");
            }
        }
    }
}
