using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._3
{
    class Program
    {
        // Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).

        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            for (int i = value.Length -1 ; i >= 0; i--)
            {
                Console.Write(value[i]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
