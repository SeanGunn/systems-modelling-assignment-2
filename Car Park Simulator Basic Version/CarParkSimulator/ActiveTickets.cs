using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        
        private List<Ticket> activeTickets;
        public ActiveTickets()
        {
            activeTickets = new List<Ticket>();       //creates new collection class.
        }
         public string GetTickets()
         {
             string tickets = "";
             foreach(Ticket ticket in activeTickets)
             {
                tickets = "#" + ticket.GetHashCode() + ": " + ticket.IsPaid() + "\n";    //tickets have a set string of numbers, .GetHashCode() generates a unique id.
             }

             return tickets;
         }

        public void AddTicket()
        {
            Ticket newTicket = new Ticket();        //creates new ticket.
            activeTickets.Add(newTicket);           //adds the ticket to the active tickets collection class.
        }

        public void RemoveTicket()
        {
            if(activeTickets[0].IsPaid())    //removes the first ticket in the active tickets collection class.
            {
                activeTickets.Remove(activeTickets[0]);
            }
        }

    }
}
