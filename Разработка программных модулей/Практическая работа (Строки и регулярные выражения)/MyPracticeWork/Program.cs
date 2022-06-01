using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Строки_и_регулярные_выражения
{
    class Program
    {
        // Test
        /*
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер телефона:");
            string number = Console.ReadLine();
            Console.WriteLine(IsPhonenumber(number));
            Console.ReadKey();

            Console.WriteLine("Тесты пройдены");
        }

        static bool IsPhonenumber(string stringNumber)
        {
            return Regex.IsMatch(stringNumber, @"^\+7\s\(863\)\s\d{3}-\d{2}-\d{2}$");
            Debug.Assert(!IsPhonenumber("+7 (800) 231-45-84"));
            Debug.Assert(IsPhonenumber("+7 (863) 231-45-84"));
            Debug.Assert(!IsPhonenumber("+7 (8631) 21-45-84"));

            Console.WriteLine("Тесты пройдены");
        }
        */



        // Task 1.0
        /*
        static void Main(string[] args)
        {
            var name = "Дарья";
            string surname = " Кувшинка";
            string fullname = " Дарья кувшинка";
            var lastname = "кувшинкина";
        }
        */



        // Task 1.1
        /*
        static void Main(string[] args)
        {
            System.Console.WriteLine("Имя = " + name + ", фамилия = " + surname + "\r\nПолное имя:\r\n" + fullname);
            var name = "Дарья";
            string surname = " Кувшинка";
            string fullname = " Дарья кувшинка";
            var lastname = "кувшинкина";
            Console.WriteLine(lastname);
        }
        */



        // Task 2
        /*
        static void Main(string[] args)
        {
            var name = "Дарья";
            string surname = " Кувшинка";
            var lastname = "Кувшинкина";
            string fullname = name + " " + lastname;
            Console.WriteLine(fullname);   
        }
        */
    }
}