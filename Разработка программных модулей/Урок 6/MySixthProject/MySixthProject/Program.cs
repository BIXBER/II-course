using System;
using static System.Console;

namespace MySixthProject
{
    class Program
    {

        /*
        // *Вызов Laboratorian work 1*
        enum Marks {very_bad, bad, satisfactory, good, excellent, noSuchMark};
        static void Main(string[] args)
        
        {
            
            WriteLine("Введите отметку:");
            int mark = int.Parse(ReadLine());
            Marks characteristic = Marks.very_bad;
            CheckMark(mark, ref characteristic);
            WriteLine($"The characteristic for {mark} is {characteristic}");
        }
        */

        // Laboratorian work 1
        /*
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

        enum DayOfWeek { MON, TUE, WED, THU, FRI, SAT, SUN };

        //the function outputs the names of the days
        static void PrintDayOfWeek(DayOfWeek dow)
        {
            switch (dow)
            {
                case 1:
                   dow = Monday;
                    break;
                case 2:


                default:
                    break;
            }
        }

        //the function inputs the days of week (from 1 to 7) and returns the result of calling the function DayOfWeek with inputted argument
        static DayOfWeek ReadDayOfWeek()
        {
            int day;
            day = int.Parse(Console.ReadLine());

            if ( /*TODO: print the condition when an exception occurs*/ )
                throw new ArgumentOutOfRangeException("day", "day must be > 0 and <8; day=" + day.ToString());
            return /*TODO: here it is needed to make a conversion of the type*/ day;
        }
        static void Main()
        {
            DayOfWeek dow  /*TODO: with a help of the function ReadDayOfWeek you have to initialize dow*/

            //TODO: call the function PrintDayOfWeek

        }


    }
    }
}
