using System;

namespace DateWhen
{
    public class Program
    {
        public static void Main(string[] args)
        {
          // Console.WriteLine(DateTime.Today);
          // DateTime date1 = new DateTime(2016, 1, 1);
          // DateTime date2 = new DateTime(2017, 03, 5);

          // bool isAfter1 = myDate.IsAfter(date1);  // true
          // bool isAfter2 = myDate.IsAfter(date2);  // false

          // Console.WriteLine(date2);
          // Console.WriteLine(isAfter1);
          // Console.WriteLine(isAfter2);


          int dayth = myDate.DayInYear();
          Console.WriteLine(dayth);
        }
    }

    public class myDate
    {
      /// <summary>
      /// Determine if this date d is before today's date
      /// </summary>
      /// <param name="d"></param>
      /// <returns>true if it is, otherwise false</returns>
      public static bool IsBefore(DateTime d)
      {
          // get today's date
          DateTime today = DateTime.Today;

          if (today > d) {
            return true;
          }

          return false;
      }
      /// <summary>
      /// Determine if this date d is after today's date
      /// </summary>
      /// <param name="d"></param>
      /// <returns>true if it is, otherwise false</returns>
      public static bool IsAfter(DateTime d)
      {
          // get today's date
          DateTime today = DateTime.Today;

          if (d > today) {
            return true;
          }

          return false;
      }
      /// <summary>
      /// Returns the number of today in the year
      /// </summary>
      /// <returns>returns a number 1...366, inclusive, such that this Date is the nth day of its year.</returns>
      public static int DayInYear()
      {
          // get Jan 1 of this year
          DateTime today = DateTime.Today;
          DateTime jan1 = new DateTime(today.Year, 1, 1);

          // subtract it from today
          TimeSpan dayth = today - jan1;

          return dayth.Days;

      }
    }
}