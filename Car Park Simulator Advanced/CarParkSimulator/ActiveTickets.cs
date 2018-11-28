using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        
        private List<Ticket> activeTickets;
        private List<int> carParkSpaces = new List<int>() { 0, 0, 0, 0, 0 };
        public ActiveTickets()
        {
            activeTickets = new List<Ticket>();
        }
         public string GetTickets()
         {
             string tickets = "";
             foreach(Ticket ticket in activeTickets)
             {
                tickets = "#" + ticket.GetHashCode() + ": " + ticket.IsPaid() + "\n";
             }

             return tickets;
         }
        public void AddTicket()
        {
            Ticket newTicket = new Ticket();
            activeTickets.Add(newTicket);
            int i = 0;
            while (i < 5)
            {
                if (carParkSpaces[i].GetHashCode() == 0)
                {
                    carParkSpaces[i] = newTicket.GetHashCode();
                    break;
                }
                i++;
            }
        }

        public void RemoveTicket()
        {
            int i = 0;
            while (i < 5)
            {
                if (carParkSpaces[i] == activeTickets[0].GetHashCode())
                {
                    carParkSpaces[i] = 0;
                    activeTickets.Remove(activeTickets[0]);
                    break;
                }
                i++;
            }
            if (activeTickets.Count() > 0)
            {
                if (activeTickets[0].IsPaid())
                {
                    activeTickets.Remove(activeTickets[0]);
                }
            }
        }

        public void TicketPaid()
        {
            if (activeTickets.Count() > 0)
            {
                activeTickets[0].SetPaid();
            }
            
        }
        public List<int> GetCarParkSpaces()
        {
            return carParkSpaces;
        }
    }
}
