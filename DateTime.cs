using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets2
{
    public class DateTime : Date
    {
        private int _hour;
        public int Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        private int _minute;
        public int Minute
        {
            get { return _minute; }
            set { _minute = value; }
        }

        private string _delay;
        public string Delay
        {
            get { return _delay; }
            set { _delay = value; }
        }

        public DateTime(int _year, int _month, int _day, int _hour, int _minute, String _delay) : base(_year, _month, _day)
        {

            this._hour = _hour;
            this._minute = _minute;
            this._delay = _delay;
        }

        public Boolean equals(Object obj)
        {
            if (obj != null && obj is DateTime)
            {
                DateTime time = (DateTime)obj;
                if (time.Day == Day && time.Month == Month && time.Year == Year && time.Hour == Hour && time.Minute == Minute && time.Delay == Delay)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return Day + "." + Month + "." + Year + ", " + _hour + ":" + _minute + " Delay: " + _delay;
        }

        public override void Display()
        {
            Console.WriteLine("day: " + Day + " month: " + Month + " year: " + Year + " Time: " + _hour + ":" + _minute + " " + "Possible delays: " + _delay);
        }
    }
}
