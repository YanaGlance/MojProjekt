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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets2
{
    class Program
    {
        public enum Operation { show, dates, quit };

        static void ToDo(Operation operation)
        {
            switch (operation)
            {
                case Operation.show:
                    Console.WriteLine("Your tickets: ");
                    break;

                case Operation.dates:
                    Console.WriteLine("Avaliable dates");
                    Date date1 = new Date(2016, 6, 29);
                    date1.Display();
                    DateTime date2 = new DateTime(2016, 7, 30, 12, 15, "flight is delayed");
                    date2.Display();
                    DateTime date3 = new DateTime(2016, 7, 30, 13, 15, "flight is delayed");
                    date3.Display();
                    DateTime date4 = new DateTime(2016, 7, 30, 13, 25, "flight is delayed");
                    date4.Display();
                    Date date5 = new Date(2016, 7, 1);
                    date5.Display();
                    Date date6 = new Date(2016, 7, 2);
                    date6.Display();
                    Date date7 = new Date(2016, 7, 3);
                    date7.Display();
                    Date date8 = new Date(2016, 7, 4);
                    date8.Display();
                    break;

                case Operation.quit:
                    Console.WriteLine("Bye-bye");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Boolean quit = false;
            TicketServiceImpl service = new TicketServiceImpl();

            do
            {
                Console.WriteLine("1. Looking for tickets");
                Console.WriteLine("2. Available dates");
                Console.WriteLine("3. Exit");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Please, enter the departure city");
                                String city1 = Console.ReadLine();
                                Console.WriteLine("Please, enter the destination city");
                                String city2 = Console.ReadLine();
                                Console.WriteLine("Please, enter the year");
                                int year = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please, enter the month");
                                int month = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please, enter the day");
                                int day = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please, enter the hour");
                                int hour = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please, enter the minute");
                                int minute = int.Parse(Console.ReadLine());
                                Console.WriteLine("Is it delay possible? yes/no");
                                string delay = Console.ReadLine();

                                List<TicketInfo> list1 = service.getTicketInfo(city1, city2, new DateTime(year, month, day, hour, minute, delay));

                                Operation operation = Operation.show;
                                ToDo(operation);

                                foreach (var ticket in list1)
                                    Console.WriteLine(ticket);
                                break;
                            }

                        case 2:
                            {
                                Operation operation = Operation.dates;
                                ToDo(operation);
                                break;
                            }

                        case 3:
                            {
                                quit = true;
                                Operation operation = Operation.quit;
                                ToDo(operation);
                                break;
                            }

                        default:
                            {
                                if (choice < 1 | choice > 3)
                                    Console.WriteLine("Incorrect number");
                            }
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("It's not a number");
                }
                Console.ReadKey();
            } while (!quit);
        }
    }
}

System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets2
{
    class TicketInfo
    {
        private String _from;
        public String From
        {
            get { return _from; }
            set { _from = value; }
        }

        private String _to;
        public String To
        {
            get { return _to; }
            set { _to = value; }
        }

        private DateTime _dateTime;
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private float _duration;
        public float Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        private int _transfer;
        public int Transfer
        {
            get { return _transfer; }
            set { _transfer = value; }
        }

        public TicketInfo(DateTime _dateTime, double _price, String _from, String _to, float _duration, int _tranfer)
        {

            this._from = _from;
            this._to = _to;
            this._dateTime = _dateTime;
            this._price = _price;
            this._duration = _duration;
            this._transfer = _transfer;
        }

        public override string ToString()
        {
            return _from + " -> " + _to + "(Date: " + _dateTime + " Price($): " + _price + ", Duration(h): " + _duration + ", Transfers: " + _transfer + ")";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets2
{
    interface TicketService
    {
        List<TicketInfo> getTicketInfo(String _from, String _to, DateTime _when);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets2
{
    class TicketServiceImpl : TicketService
    {
        List<TicketInfo> tickets = new List<TicketInfo>();

        public TicketServiceImpl()
        {
            tickets.Add(new TicketInfo(new DateTime(2016, 6, 30, 12, 15, "yes"), 50.0d, "Frankfurt", "Munich", 1.2f, 0));
            tickets.Add(new TicketInfo(new DateTime(2016, 6, 30, 13, 15, "yes"), 65.3d, "Frankfurt", "Munich", 1.3f, 0));
            tickets.Add(new TicketInfo(new DateTime(2016, 6, 29, 17, 45, "no"), 43.1d, "Frankfurt", "Munich", 2.0f, 0));
            tickets.Add(new TicketInfo(new DateTime(2016, 6, 30, 13, 25, "yes"), 55.2d, "Frankfurt", "Munich", 1.1f, 0));
            tickets.Add(new TicketInfo(new DateTime(2016, 7, 1, 21, 00, "no"), 47.6d, "Frankfurt", "Munich", 1.5f, 0));
            tickets.Add(new TicketInfo(new DateTime(2016, 6, 29, 22, 15, "no"), 75.7d, "Munich", "London", 1.2f, 1));
            tickets.Add(new TicketInfo(new DateTime(2016, 7, 1, 23, 05, "no"), 435.5d, "London", "New York", 7.4f, 0));
            tickets.Add(new TicketInfo(new DateTime(2016, 7, 2, 14, 25, "no"), 505.0d, "New York", "Paris", 7.1f, 0));
            tickets.Add(new TicketInfo(new DateTime(2016, 7, 3, 17, 35, "no"), 623.5d, "Paris", "Sydney", 23.4f, 2));
            tickets.Add(new TicketInfo(new DateTime(2016, 7, 4, 09, 00, "no"), 615.0d, "Sydney", "Frankfurt", 20.5f, 1));
        }

        public List<TicketInfo> getTicketInfo(String _from, String _to, DateTime _when)
        {

            List<TicketInfo> corrTickets = new List<TicketInfo>();

            foreach (TicketInfo t in tickets)
            {
                if (t.DateTime.equals(_when) && t.From.Equals(_from) && t.To.Equals(_to))
                {
                    corrTickets.Add(t);
                }
            }
            return corrTickets;
        }
    }
}
