using System;

namespace MySeventhProject
{
    class Program
    {
        // Task 1
        /*
        static void Main(string[] args)
        {
            double[] arr = { 1.1, -2.3, 3.7, 4.1, 5.6, 6.1, 7.1 };
            Print(arr);
            FindMinMax(arr);
        }

        static void Print(double[] array)
        {
            foreach (var i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void FindMinMax(double[] array)
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            foreach (var i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            foreach (var i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine($"Минимальное {min}, Максимальное {max}");
         }
        */



        // Task 2
        /*
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            FillArray(arr);
            Print(arr);
            Console.WriteLine("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            FindN(arr, N);
        }

        static void Print(int[] array)
        {
            foreach (var i in array)
            Console.Write(i + " ");
            Console.WriteLine();
        }

        static void FillArray(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 10);
            }
        }

        static void FindN(int[] arr, int N)
        {
            bool f = false;
            int counter = 0;
            int n_counter = 0;
            foreach (int i in arr)
            {
                if (i == N)
                {
                    f = true;
                    n_counter = counter;
                    break;
                }
                counter++;
            }
            if (f)
            {
                Console.WriteLine("Результат: да");
                Console.WriteLine($"Индекс: {n_counter}");
            }
            else
            {
                Console.WriteLine("Результат: нет");
            }
        }
        */



        // Task 3
        /*
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            FillArray(arr);
            Sum(arr);
        }
        static void FillArray(double[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.NextDouble() * 10 - 5;
            }
            foreach (var i in arr)
            Console.Write("{0:0.00} ", i);
            Console.WriteLine();
        }

        static void Sum(double[] arr)
        {
            double j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    j = arr[i] + arr[i + 1] + arr[i + 2];
                }
                catch
                {
                    continue;
                }

                Console.WriteLine("{0:0.00}", j);
            }
        }
        */

    }
}
