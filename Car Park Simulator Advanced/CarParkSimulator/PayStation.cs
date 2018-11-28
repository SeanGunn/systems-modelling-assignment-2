using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CarParkSimulator
{
    class PayStation
    {
        private string message;
        private CarPark carPark;
        private ActiveTickets activeTickets;

        public void PayForTicket(ActiveTickets activeTickets)
        {
            activeTickets.TicketPaid();
        }

        public string ClearMessage(string text)
        {
            message = text;
            return message;
        }

        public string GetMessage(string text)
        {
            message = text;
            return message;
        }
    }
}
