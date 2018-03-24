using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets2
{
    public class Date
    {
        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private int _month;
        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        private int _day;
        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public Date(int _year, int _month, int _day)
        {

            this._year = _year;
            this._month = _month;
            this._day = _day;
        }

        public virtual void Display()
        {
            Console.WriteLine("day: " + _day + " month: " + _month + " year: " + _year);
        }
    }
}
