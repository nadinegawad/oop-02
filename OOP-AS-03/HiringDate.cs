using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AS_03
{
    //2
    internal class HiringDate
    {
        public int day;
        public int month;
        public int year;

        public HiringDate() { }
        public HiringDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }

        public int Day
        {
            get { return day; }
            set
            {
                day = value > 31 || value < 1 ? 1 : value;
            }

        }

        public int Month
        {
            get { return month; }
            set
            {
                month = value > 12 || value < 1 ? 1 : value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                year = value > 2024 || value < 2020 ? 2020 : value;
            }
        }
        public string getHiringDate()
        {
            return $"hiring date:{Day}/{Month}/{Year}";
        }
    }
}
