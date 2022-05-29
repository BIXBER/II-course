using System;
using static System.Math;

namespace MyThirdProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laboratorian Work 1 //
            /*
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());

            for(int counter = 1; counter <= a; counter ++) 
            {
                Console.WriteLine($"Счётчик: {counter}");
            }
            */



            // Task 1 //
            /*
            Console.WriteLine($"Последовательность:");
            for (int counter = -3; counter <= 24; counter+=3)
            {
                Console.WriteLine($"{counter}");
                
            }
            */



            // Task 2 //
            /*
            Console.WriteLine($"Последовательность:");
            for (int counter = 1; counter <= 100; counter++)
            {
                Console.WriteLine($" {counter} ");	
            }
			for (int counter = 99; counter >= 1; counter--)
			{
				 Console.WriteLine($" {counter} ");	 
			}
			*/



            // Task 3
            /*
            Console.WriteLine("Введите любые 10 чисел:");
            int positive = 0;
            int unpositive = 0;

            for (int i = 0; i < 10 ; i++)
            {
                int input = Int32.Parse(Console.ReadLine());
                if (input > 0)
                {
                    positive++;
                }
                else if (input < 0)
                {
                    unpositive++;
                }
            }
            Console.WriteLine($"\nКоличество положительных чисел: {positive}, отрицательных: {unpositive}");
            */



            // Task 4
            /*
            Console.WriteLine("Введите любый 10 чисел:");
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int input = Int32.Parse(Console.ReadLine());
                sum = sum + input;
            }
            Console.WriteLine($"Сумма введённых чисел: {sum}");
            */



            // Task 5
            /*
            int sum = 1;
            int summa = 1;
            Console.Write($"{sum}");
            for (int i = 0; i < 9; i++)
            {
                sum += 2;
                summa += sum;
                Console.Write($" + {sum}");
                
            }
            Console.WriteLine($" = {summa}");
            */



            // Task 6
            /*
            double product = 1.0;
            Console.WriteLine("Введите 10 любых вещественных чисел:");

            for (int i = 0; i < 10; i++)
            {
                double input = Double.Parse(Console.ReadLine());
                product *= input;
                Console.WriteLine($" * {input} ");
            }
            Console.WriteLine($"= {product}");
            */



            // Laboratorian Work 2 //
            /*
            Console.WriteLine("Простые числа: ");
            int outer, inner;

            for (outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer / 2); inner++)
                {
                    if ((outer % inner) == 0) break;
                }

                if (inner > (outer / inner)) ;
                {
                    Console.WriteLine("{0} is prime", outer);
                }
            }
            */



            // Task 7
            /*
            int x, y;
            for (x = 2; x <= 8; x++)
            {

                for (y = 2; y < 5; y++)
                {
                    Console.WriteLine($"z(x,y) = {x}^{y} = {Math.Pow(x,y)}");
                }
            }
            */



            // Task 8
            /*
            int x, y;
            for (x = 30; x <= 33; x++)
            {
                for (y = 1; y <= 5; y++)
                {
                    Console.WriteLine($"z(x,y) = {x} - {y} = {x - y}");
                }
            }
            */




        }

    }
	
}

       

