using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLeapYearRet1 = MyDate.IsLeapYear(2004);
            bool isLeapYearRet2 = MyDate.IsLeapYear(2000);
            bool isLeapYearRet3 = MyDate.IsLeapYear(100);
            bool isLeapYearRet4 = MyDate.IsLeapYear(4);
            Console.WriteLine(isLeapYearRet1);
            Console.WriteLine(isLeapYearRet2);
            Console.WriteLine(isLeapYearRet3);
            Console.WriteLine(isLeapYearRet4);
        }
    }

    public static class MyDate
    {
        // check whether leap year
        // year to be verified
        // true if leap year, otherwise false



        public static bool IsLeapYear(int year)
        {
            // your implementation here
            year = Convert.ToInt32(year);

            // conditions for leap year
            bool condition1 = year % 4 == 0;
            bool condition2 = year % 100 != 0;
            bool condition3 = year % 400 == 0;

            if ((condition1 && condition2) || condition3)
            {
                Console.WriteLine("{0} is a leap year!", year);
                return true;
            }
            return false;
        }
    }
}
