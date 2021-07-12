using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        // Написать метод GetFullName(string firstName, string lastName, string patronymic),
        // принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
        // Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Степаненко", "Марк", "Владимирович"));
            Console.WriteLine(GetFullName("Путин", "Марк", "Владимирович"));
            Console.WriteLine(GetFullName("Дементьев", "Марк", "Владимирович"));


            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {

            return $"{ firstName} { lastName} { patronymic}";

        }
        // тут я сам хотел вписывать имена, но не понял как это сделать 3 раза 
        /*
          static void Main(string[] args)
        {
            Console.WriteLine("Ведите ФИО");
            Console.WriteLine(GetFullName("lastName", "firstName", "patronymic"));

            Console.ReadKey();
        } 

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.Write("Ведите фамилию: ");
            lastName = Console.ReadLine();
            Console.Write("Ведите имя: ");
            firstName = Console.ReadLine();
            Console.Write("Ведите отчество: ");
            patronymic = Console.ReadLine();

            return $"{ firstName} { lastName} { patronymic}";

        }
        */

    }
}
