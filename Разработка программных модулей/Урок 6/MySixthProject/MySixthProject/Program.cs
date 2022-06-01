using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySixthProject
{
    class Program
    {


        // *Вызов Laboratorian work 1*
        /*
        enum Marks {very_bad, bad, satisfactory, good, excellent, noSuchMark};
        static void Main(string[] args)
        
        {
            
            WriteLine("Введите отметку:");
            int mark = int.Parse(ReadLine());
            Marks characteristic = Marks.very_bad;
            CheckMark(mark, ref characteristic);
            WriteLine($"The characteristic for {mark} is {characteristic}");
        }
        

        // Laboratorian work 1
        
        static void CheckMark(int mark, ref Marks characteristic)
        {
            switch (mark)
            {
                case 1:
                    characteristic = Marks.very_bad;
                    break;
                case 2:
                    characteristic = Marks.bad;
                    break;
                case 3:
                    characteristic = Marks.satisfactory;
                    break;
                case 4:
                    characteristic = Marks.good;
                    break;
                case 5:
                    characteristic = Marks.excellent;
                    break;
            default:
                    WriteLine("Invalid selection. Please select 1, 2, 3, 4 or 5:");
                    characteristic = Marks.noSuchMark;
                    break;
            }
        */



        // Task 1
        /*
        enum DayOfWeek { MON, TUE, WED, THU, FRI, SAT, SUN };

        //the function outputs the names of the days
        static void PrintDayOfWeek(DayOfWeek dow)
        {
            switch (dow)
            {
                case DayOfWeek.MON:
                    Console.WriteLine("Понедельник");
                    break;
                case DayOfWeek.TUE:
                    Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.WED:
                    Console.WriteLine("Среда");
                    break;
                case DayOfWeek.THU:
                    Console.WriteLine("Четверг");
                    break;
                case DayOfWeek.FRI:
                    Console.WriteLine("Пятница");
                    break;
                case DayOfWeek.SAT:
                    Console.WriteLine("Суббота");
                    break;
                case DayOfWeek.SUN:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    break;
            }
        }

        //the function inputs the days of week (from 1 to 7) and returns the result of calling the function DayOfWeek with inputted argument
        static DayOfWeek ReadDayOfWeek()
        {
            int day;
            day = int.Parse(Console.ReadLine());

            if (day == 0 || day > 7)
            {
                throw new ArgumentOutOfRangeException("day", "day must be > 0 and <8; day=" + day.ToString());
            }
            return (DayOfWeek) day;
        }
        static void Main()
        {
            DayOfWeek dow = ReadDayOfWeek();
            PrintDayOfWeek(dow);
        }
    */


        static void Main(string[] args)
        { 
        // Task 2
        /*
            Console.WriteLine("Введите натуральные числа a и N");
            int a = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int res = a;
            for (int i = 1; i <= N; i++)
            {
                res++;
            }
            IEnumerable<int> seq;
            seq = System.Linq.Enumerable.Range(a, N);
            foreach (var x in seq)
            Console.WriteLine($"{x} ");
        */



        // Task 3
        /*
        int a = 1;
            int b = 9;
            int result = 0;
            for (int i = 1; i <= b; i++)
            {
                result += 2;
            }
            IEnumerable<int> seq;
            seq = System.Linq.Enumerable.Range(a, result);
            foreach (var x in seq)
                if (x % 2 != 0)
                {
                    Console.WriteLine($"{x} ");
                }
        */

        }

    }

}