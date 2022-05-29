using System;

namespace MyFoorthProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laboratorian work 1
            /*
            Console.WriteLine("Введите число:");
            int N = Int32.Parse(Console.ReadLine());
            int counter_first = 1;

            while (counter_first <= N)
            {
                Console.WriteLine($"Текущее значение счётчика: {counter_first}");
                counter_first++;
            }
            */



            // Laboratorian work 2
            /*
            int counter_second = 1;
            do
            {
                Console.WriteLine($"Текущее значение счётчика: {counter_second}");
                counter_second++;
            } 
            while (counter_second <= 0);
            */



            // Task 1
            /*
            // При помощи цикла "while":
            int counter1 = 3;
            while (counter1 <= 21)
            {
                Console.Write($"{counter1} ");
                counter1 += 2;
            }

            // При помощи цикла "do...while":
            int counter2 = 3;
            do
            {
                Console.Write($"{counter2} ");
                counter2 += 2;
            } 
            while (counter2 <= 21);
            */



            // Task 2
            /*
            // При помощи цикла "while":
            int counter_1 = 15;
            while (counter_1 >= 0)
            {
                Console.Write($"{counter_1} ");
                counter_1 -= 3;
            }

            // При помощи цикла "do...while":
            int counter_2 = 15;
            do
            {
                Console.Write($"{counter_2} ");
                counter_2 -= 3;
            } 
            while (counter_2 >= 0);
            */



            // Task 3
            /*
            int product = 1;
            int i = 8;
            Console.Write(i);
            while (i >= 8 && i < 20)    
            {                
                i += 2;
                product *= i;
                Console.Write($" * {i}");
            }
            Console.Write($" = {product}");
            */



            // Task 4
            /*
            Console.WriteLine("Введите 5 вещественных чисел:");
            int enters = 0;
            double numb; // То, что вводит пользователь
            double sum = 0;

            while (enters < 5)
            {
                enters += 1;
                numb = Double.Parse(Console.ReadLine());
                sum += numb; 
            }
            Console.WriteLine($"\nСумма введенных чисел = {sum} ");
            */



            // Laboratorian work 3
            /*
            Console.WriteLine("Введите последовательность целых чисел и закончите ввод нулем:");
            int numb;
            int min = int.MaxValue;

            // Ошибка при вводе:
            try
            {
                do
                {
                    numb = Int32.Parse(Console.ReadLine());
                    if (numb < min && numb != 0)
                    {
                        min = numb;
                    }
                }
                while (numb != 0);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " Повторите ввод");
            }

            // Цикл:
            do
            {
                numb = int.Parse(Console.ReadLine());
                if (numb < min && numb != 0)
                {
                    min = numb;  
                }
            } 
            while (numb != 0);

            // Вывод значения:
            Console.WriteLine($"Минимальное значение: {min}");
            */



            // Task 5
            /*
            Console.WriteLine("Введите последовательность чисел и закончите ввод нулем:");
            int numb;
            int max = 0;
            int enters = 0;

            do
            {
                
                numb = int.Parse(Console.ReadLine());
                if (numb > max && numb != 0)
                {
                    max = numb;
                    enters += 1;
                }
            } 
            while (numb != 0);

            Console.WriteLine($"Максимальное число: {max}.\nЕго порядковый номер: {enters}.");
            */
        }
    }
}
