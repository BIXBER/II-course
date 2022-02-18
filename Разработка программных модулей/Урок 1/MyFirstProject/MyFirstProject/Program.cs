using System;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 //
            /*
            Console.WriteLine("Анкета студента\n");
            Console.WriteLine("Введите ваш пол:");
            string gender = Console.ReadLine();
            Console.WriteLine("Введите Ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилия:");
            string female = Console.ReadLine();
            Console.WriteLine("Введите дату Вашего рождения:");
            DateTime birthdate = new DateTime(2004, 3, 5, 15, 00, 00);
            Console.WriteLine(birthdate);
            Console.WriteLine("\nВведите страну Вашего проживания:");
            string country = Console.ReadLine();
            Console.WriteLine("Введите адрес Вашего проживания:");
            string adress = Console.ReadLine();
            Console.WriteLine("\nАнкета курса:\n");
            Console.WriteLine("Введите название курса, на котором Вы сейчас обучаетесь:");
            string course_name = Console.ReadLine();
            Console.WriteLine("Введите количество набранных баллов по прохождению Вашего курса:");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество занятий в неделю по данному курсу:");
            int number_of_classes = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите фамилию и имя преподавателя курса:");
            string female_and_name_of_teacher = Console.ReadLine();
            Console.WriteLine("\nИнформация о студенте успешно внесена в выгрузку!\n");
            Console.WriteLine($"Данные выгрузки:\n\rИнформация о студенте:\n\rПол\t\tИмя\t\tФамилия\tДата рождения\t\t\tСтрана\tАдрес\n\r{gender}\t\t{name}\t{female}\t{birthdate}\t\t{country}\t{adress}");
            Console.WriteLine($"\n\rИнформация о курсе:\n\rНазвание курса\t\t\t\t\tБаллы\tКоличество занятий в неделю\tПреподаватель\n\r{course_name}\t{score}\t{number_of_classes}\t\t\t\t{female_and_name_of_teacher}");

            Console.ReadKey();
            */



            // Task 2 //
            /*
            Console.WriteLine("Введите два значения через \"Enter\":");

            float a, b, v;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            v = ((a + b) / 2);

            Console.WriteLine($"Среднее значение: {v}");

            Console.ReadKey();
            */



            // Task 3 //
            /*
            Console.WriteLine("Введите сторону:");
            int a = int.Parse(Console.ReadLine());
            double perimeter = a * 3;
            double square = (Math.Sqrt(a) * Math.Pow(a, 2)) / 4;
            Console.WriteLine($"\nПериметр треугольника: {perimeter}\n");
            Console.WriteLine($"Площадь: {square}");
            
            Console.ReadKey();
            */



            // Task 4 //
            /*
            Console.WriteLine("Введите числа");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine((x1 < x2) && (x3 > x4));

            Console.ReadKey();
            */
        }
    }
}
