using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._1
{
    class Program
    {
        //Написать программу, выводящую элементы двухмерного массива по диагонали.

        private static int rangeArray;
        private static int rangeArray2;

        static void Main(string[] args)
        {
            Console.WriteLine("Задайте диапазон двухмерного массива");

            Console.Write("Введите первый диапазон: ");
            rangeArray = RangeArray(rangeArray);
            Console.WriteLine();

            Console.Write("Введите второй диапазон: ");
            rangeArray2 = RangeArray(rangeArray); //почему я тут могу написать rangeArray2 = RangeArray(rangeArray2);???
            Console.WriteLine();

            DiagonalArray();

            Console.ReadKey();

        }
        static int RangeArray(int rangeArray)
        {
            if ((Int32.TryParse(Console.ReadLine(), out rangeArray)))
            {
                Console.WriteLine("Все хорошо");
            }
            else
            {
                Console.WriteLine("Ошибка, веди еще раз");
                while (!Int32.TryParse(Console.ReadLine(), out rangeArray))
                {
                    Console.WriteLine("Ошибка, веди еще раз");
                }

            }
            return rangeArray;
        }
        static void DiagonalArray()
        {
            int[,] array = new int[rangeArray, rangeArray2];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10000);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();

            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                try
                {
                    Console.Write($"{ new string(' ', i)} {array[i, i]}");
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
    }
}
