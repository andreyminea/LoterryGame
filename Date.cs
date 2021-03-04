using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery
{
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set;  }
        public int Year { get; set; }

        public Date() { }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public Date(DateTime dateTime)
        {
            Day = dateTime.Day;
            Month = dateTime.Month;
            Year = dateTime.Year;
        }
        public static implicit operator Date(DateTime dateTime)
        {
            return new Date(dateTime);
        }
        public static implicit operator String(Date date)
        {
            return date.ToString();
        }
        public string ToString()
        {
            return Day.ToString() + "." + Month.ToString() + "." + Year.ToString();
        }
    }
}
