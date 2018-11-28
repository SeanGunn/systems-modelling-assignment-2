using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
    {
        private string message;
        private ActiveTickets activeTicket;
        private CarPark carPark;

        public TicketMachine(ActiveTickets at)
        {
            activeTicket = at;
        }
        public void AssignCarPark(CarPark carpark)
        {
            carPark = carpark;
        }

        public bool CarArrived()
        {
            return true;
        }

        public void PrintTicket(ActiveTickets activeTickets, CarPark carPark)
        {
            activeTickets.AddTicket();
            carPark.TicketDispensed();
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
