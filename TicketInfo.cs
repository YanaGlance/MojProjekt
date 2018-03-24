using System;
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
