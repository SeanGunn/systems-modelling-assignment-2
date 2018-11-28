using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
    {
        private string message;
        private ActiveTickets activeTicket;
        private CarPark carPark;

        public TicketValidator(ActiveTickets at)
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

        public void TicketEntered(CarPark carPark)
        {
            activeTicket.RemoveTicket();
            carPark.TicketValidated();
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
