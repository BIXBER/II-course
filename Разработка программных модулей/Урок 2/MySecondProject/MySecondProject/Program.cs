using System;

namespace MySecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Laboratorian work #1 //
            /*
            Console.WriteLine ("Введите любое число:");
            int numb = Int32.Parse (Console.ReadLine());
            if (numb % 2 == 0)
            {
                Console.WriteLine ("Введенное число четное!");
            }
            else 
            {
                Console.WriteLine ("Введенное число нечетное!");
            }
            */



            // Task 1 //
            /*
            Console.WriteLine ("Введите любое число:");
            int numb = Convert.ToInt32 (Console.ReadLine());
            if (numb > 0)
            {
                Console.WriteLine("Введенное число - положительное!");
            }
            else
            {
                Console.WriteLine("Введенное число - отрицательное.");
            }
            */



            // Task 2 //
            /*
            Console.WriteLine ("Введите любое двузначное число:");
            int numb = Convert.ToInt32(Console.ReadLine());

            int desyatki = Convert.ToInt32 (numb / 10);
            int edinitci = Convert.ToInt32 (numb % 10);

            Console.WriteLine($"Результат: десятки - {desyatki}, единицы {edinitci}");
            */



            // Task 3 //
            /*
            Console.WriteLine ("Введите любое трехзначное число:");
            int numb = Int32.Parse (Console.ReadLine());

            int sotni = Convert.ToInt32 (numb / 100);
            int desyatki = Convert.ToInt32 ((numb % 100) / 10);
            int edinitsi = Convert.ToInt32 (numb % 10);

            int desyatki_v_nol = Convert.ToInt32 (desyatki * 0);

            Console.WriteLine($"Цифры числа: {sotni}, {desyatki}, {edinitsi}. Результат: {sotni}{desyatki_v_nol}{edinitsi}");
            */



            // Task 4 //
            /*
            int first = 8;
            int second = 5;
            int third = 8;

            if (first != second || third != second)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */



            // Task 5 //
            /*
            int a, b, c, p;
            double s;

            Console.WriteLine("Введите три числа через \"Enter\":");
            a = Convert.ToInt32(Console.ReadLine()); 
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            p = (a + b + c) / 2;
            s = Math.Sqrt(Convert.ToInt32(p * (p - a) * (p - b) * (p - c)));

            if (a == 4 && b == 8 && c == 6)
            {
                Console.WriteLine($"\nТреугольник существует, его площадь {s}");
            }
            else 
            {
                Console.WriteLine("\nОшибка! - Треугольника не существует!");
            }
            */



            // Task 6 //
            /*
            Console.WriteLine("Введите любое значение:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x <= -2 || x >= 2)
            {
                Console.WriteLine(2 * x);
            }
            else
            {
                Console.WriteLine(-3 * x);
            }
            */



            // Task 7 //
            /*
            Console.WriteLine("Введите любое значение:");
            float x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine($"Результат: {2 * Math.Sin(x)}");
            }
            else if (x <= 0)
            {
                Console.WriteLine($"Результат: {6 - x}");
            }
            */



            // Laboratorian work #2 //
            /*
            Console.WriteLine("Возможные порции: 1 - small 2 - medium 3 - large");
            Console.WriteLine("Укажите Ваш выбор:");

            string choose = Console.ReadLine();
            int price = 0;

            switch (choose)
            {
                case "1":
                    price += 25;
                    break;
                case "2":
                    price += 50;
                    break;
                case "3":
                    price += 75;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Введите число от 1 до 3 включительно.");
                    break;
            }
            if (price != 0)
            {
                Console.WriteLine($"{price} руб");
            }
            */



            // Task 8 //
            /*
            Console.WriteLine("Введите номер дня недели (от 1 до 7 включительно):");

            string number_of_week = Console.ReadLine();
            int number = 0;
            string name = "";

            switch (number_of_week)
            {
                case "1":
                    number += 1;
                    name = "понедельник";
                    break;
                case "2":
                    number += 2;
                    name = "вторник";
                    break;
                case "3":
                    number += 3;
                    name = "среда";
                    break;
                case "4":
                    number += 4;
                    name = "четверг";
                    break;
                case "5":
                    number += 5;
                    name = "пятница";
                    break;
                case "6":
                    number += 6;
                    name = "суббота";
                    break;
                case "7":
                    number += 7;
                    name = "воскресенье";
                    break;
                default:
                    Console.WriteLine("\nОшибка! Такого дня недели нет, введите число от 1 до 7 включильно.");
                    break;
            }
            if (number_of_week != "0")
                Console.WriteLine($"\nРазультат: {number_of_week}-й день недели - это {name}!");
            */



        }
    }
}
