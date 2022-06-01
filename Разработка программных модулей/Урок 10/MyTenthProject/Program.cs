using System;

namespace MyTenthProject
{
    class Program
    {
        // Task 1
        /*
        static void Main(string[] args)
        {
            int[,] t = {
                {-8,-14,-19,-18},
                { 25,28, 26, 20},
                { 11,18, 20, 25}
                };

            Console.WriteLine($"Температура на 2-ой метеостанции в течении 4-ого дня: {t[1, 3]}, на 3-ей метеостанции в течении 1-ого дня: {t[2, 0]}");
            Console.WriteLine("\nТемпература всех метеостанций в течении 2-ого дня:");
            for (int j = 0; j < t.GetLength(0); j++)
            {
                Console.Write($"{t[j, 1]}  ");
            }

            Console.WriteLine();
            Console.WriteLine("\nТемпература всех метеостанций в течении всех дней:");
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.Write($"{t[i, j]} ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int j = 0; j <= t.GetLength(0); j++)
            {
                sum += t[2, j];
            }
            Console.WriteLine($"\nСредняя температура на 3-ей метеостанции: " + sum / 4);

            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    if (t[i, j] >= 24 && t[i, j] <= 26)
                    {
                        Console.WriteLine($"\nСтанция:{i + 1}, день:{j + 1}");
                    }
                }
            }
            Console.WriteLine();
            */



        // Task 2
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 6 значений для матрицы 2X3:");
            int[,] vasitit = new int[2, 3];
            int sum2 = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    vasitit[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < vasitit.GetLength(0); i++)
            {
                for (int j = 0; j < vasitit.GetLength(1); j++)
                {
                    sum2 += vasitit[i, j];
                }
            }
            Console.WriteLine($"Сумма: {sum2}");
        }   
        */



        // Task 3
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы (12) для двумерного массива 4Х3:");
            int[,] titivas = new int[4, 3];
            int sum3 = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    titivas[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < titivas.GetLength(0); i++)
            {
                for (int j = 0; j < titivas.GetLength(1); j++)
                {
                    if (titivas[i, j] >= 0)
                    {
                        sum3++;
                    }
                }
            }
            Console.WriteLine($"Количество положительных: {sum3}");
        }
        */



        //Task 4
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите количество столбцов:");
            int columns = int.Parse(Console.ReadLine());
            int[,] visitat = new int[rows, columns];
            int minValue = -15;
            int maxValue = 15;
            int min = int.MaxValue;
            int max = int.MinValue;

            FillMatrix(visitat, minValue, maxValue);
            FindMinMaxArr(visitat, ref min, ref max);
            Console.WriteLine($"Минимальное значение: {min}, Максимальное значение: {max}");
        }

        private static void FindMinMaxArr(int[,] visitat, ref int min, ref int max)
        {
            throw new NotImplementedException();
        }

        private static void FillMatrix(int[,] visitat, int minValue, int maxValue)
        {
            throw new NotImplementedException();
        }
        */



        //Task 5
        /*
        static void Main(string[] args)
        {
            int[,] yabloko = new int[5, 5];
            FillMatrix(yabloko, -15, 15);
            PlaceZero(yabloko);
            PrintMatrix(yabloko);
            Console.WriteLine();
        }

        private static void PrintMatrix(int[,] yabloko)
        {
            throw new NotImplementedException();
        }

        private static void PlaceZero(int[,] yabloko)
        {
            throw new NotImplementedException();
        }

        private static void FillMatrix(int[,] yabloko, int v1, int v2)
        {
            throw new NotImplementedException();
        }
        */



        //Task 6
        /*
        static void Main(string[] args)
        {
            int[,] bulka = new int[3, 4];
            FillMatrix(bulka, -15, 15);
            int product;
            Console.WriteLine("Введите номер столбца (первый столбец - 0-й):");
            int m = int.Parse(Console.ReadLine());
            FindProductOfColumn(bulka, m, out product);
            Console.WriteLine($"Произведение элементов 2-го столбца: {product}");
        }

        private static void FindProductOfColumn(int[,] bulka, int m, out int product)
        {
            throw new NotImplementedException();
        }

        private static void FillMatrix(int[,] bulka, int v1, int v2)
        {
            throw new NotImplementedException();
        }
        */



        //Task 7
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы:");
            int m = int.Parse(Console.ReadLine());
            int[,] cucumber = new int[m, m];
            FillMatrix(cucumber, -15, 15);
            Console.WriteLine("\nПроизведение элементов главной диагонали: " + FindDiagonal(cucumber));
        }

        private static void FillMatrix(int[,] matrix, int minValue, int maxValue)
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(minValue, maxValue);
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

        }

        private static void FindMinMaxArr(int[,] matrix, ref int min, ref int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max && matrix[i, j] != 0) { max = matrix[i, j]; }
                    if (matrix[i, j] < min && matrix[i, j] != 0) { min = matrix[i, j]; }
                }
            }
        }

        static void PlaceZero(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[0, i] = 0;
                    matrix[4, i] = 0;
                    matrix[i, 0] = 0;
                    matrix[i, 4] = 0;
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }
        static void FindProductOfColumn(int[,] bulka, int M, out int product)
        {
            product = 1;
            for (int i = 0; i < bulka.GetLength(0); i++)
                for (int j = 0; j < bulka.GetLength(1); j++)
                {
                    if (j == M)
                    {
                        product = product * bulka[i, j];
                    }
                }
        }

        static int FindDiagonal(int[,] cucumber)
        {
            int product = 1;
            for (int i = 0; i < cucumber.GetLength(0); i++)
                for (int j = 0; j < cucumber.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        product = product * cucumber[i, j];
                    }
                }
            return product;
        }
        */
    }
}




    
    

