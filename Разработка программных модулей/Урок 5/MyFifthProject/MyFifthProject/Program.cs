using System;

namespace MyFifthProject
{
	class Program
	{
		static void Main(string[] args)
		{
			// *Вызов Laboratorian Work 1*
			/*
			Console.WriteLine("Введите два числа:");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int result = Sum(a, b);
			Console.WriteLine($"Вызов Sum() с двумя аргументами {result}");
			
			int result3 = Sum(10, 50, 80);
			Console.WriteLine($"Вызов Sum() с тремя аргументами {result3}");

			double dblResult = Sum(20.5, 30.6);
			Console.WriteLine($"Вызов Sum() с двумя аргументами {dblResult}");
			*/

			// *Вызов Task 1*
			/*
			Console.WriteLine("Введите длину, ширину и высоту треугольника:");
			int length = int.Parse(Console.ReadLine());
			int width = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());

			Perimeter(length, width, height);
			*/

			// *Вызов Task 2*
			/*
			Console.WriteLine("Введите длину, ширину и высоту треугольника:");
			int length = int.Parse(Console.ReadLine());
			int width = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());

			int perimeter = Perimeter(length, width, height);
			Console.WriteLine($"Периметр треугольника равен {perimeter}");
			*/

			// *Вызов Laboratorian Work 2*
			/*
			Console.WriteLine("Введите два числа: число и его степень соответственно:");
			int a = Int32.Parse(Console.ReadLine());
			int b = Int32.Parse(Console.ReadLine());
			Console.WriteLine(GetPow(a,b));
			*/

			// *Вызов Task 3*
			/*
			Console.WriteLine("Введите координаты двух точек (четыре целых числа: x1, y1, x2, y2):");
			int x1 = Int32.Parse(Console.ReadLine());
			int y1 = Int32.Parse(Console.ReadLine());
			int x2 = Int32.Parse(Console.ReadLine());
			int y2 = Int32.Parse(Console.ReadLine());
			Distance(x1, y1, x2, y2);
			*/

			//*Вызов Task 4*
			/*
			Console.WriteLine("Введите координаты двух точек (четыре целых числа: x1, y1, x2, y2):");
			double x1 = Convert.ToDouble(Console.ReadLine());
			double y1 = Convert.ToDouble(Console.ReadLine());
			double x2 = Convert.ToDouble(Console.ReadLine());
			double y2 = Convert.ToDouble(Console.ReadLine());
			Distance(x1, y1, x2, y2);
			*/
		}



        // *Laboratorian Work 1*
        /*
		static void Sum(int first, int second)
		{
			int sum = first + second;
			Console.WriteLine($"Сумма {first} + {second} = {sum}");
		}
		
		static int Sum(int first, int second)
        {
			int sum = first + second;
			return sum;
        }

		static int Sum(int first, int second, int third)
        {
			int sum = first + second + third;
			return sum;
        }

		static double Sum(double first, double second)
        {
			double result = first + second;
			return result;
        }
		*/



        // Task 1
        /*
		static void Perimeter(int length, int width, int height)
        {
			
			int perimeter = length + width + height;
			Console.WriteLine($"\nПериметр треугольника равен {perimeter}");
        }
		*/



        // Task 2
        /*
		static int Perimeter(int length, int width, int height)
        {
			int perimeter = length + width + height;
			return perimeter;
		}
		*/



        // Laboratorian Work 2
        /*
		public static int GetPow(int baseNum, int powNum)
        {
			int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
			return result;
        }
		*/



        // Task 3
        /*
		static void Distance (int x1, int y1, int x2, int y2)
        {
			double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
			Console.WriteLine($"Расстояние: {distance}");
		}
		*/



        // Task 4
		/*
        static double Distance(double x1, double y1, double x2, double y2)
        {
			double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
			Console.WriteLine($"Расстояние: {distance}");
			return distance;
		}
		*/




	}
}
