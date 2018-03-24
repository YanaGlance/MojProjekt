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
