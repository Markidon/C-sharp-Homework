using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._2
{
    
    class Program
    {   //Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий
        //список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
        static void Main(string[] args)
        {
            Spravochnik();
        }

        static void Spravochnik()
        {
         
            Console.WriteLine("Телефонный справочник");
            string[,] spravochnik = {
                {"Витёк", "+73252352352 "},
                {"Григорий", "+7679679679" },
                {"Валера", "+23456789678"},
                {"Миша","ferfvwef@gmail.com"},
                {"Владик","fewfwef23213@gmail.com"} };

            for (int i = 0; i < spravochnik.GetLength(0); i++)
            {
                Console.WriteLine($"{spravochnik[i, 0]} {spravochnik[i,1]}");
            }

        }


    }
}
