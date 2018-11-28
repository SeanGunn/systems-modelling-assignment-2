using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        private int currentSpaces = 5;
        private int maxSpaces = 5;
        private FullSign fullSign;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private TicketMachine ticketMachine;
        private TicketValidator ticketValidator;
     

        public CarPark(TicketMachine tm, TicketValidator tv, FullSign fs, Barrier entryB, Barrier exitB)
        {
            //constructor
            ticketMachine = tm;
            ticketValidator = tv;
            fullSign = fs;
            entryBarrier = entryB;
            exitBarrier = exitB;
        }

        public void CarArrivedAtEntrance()
        {
            ticketMachine.CarArrived();
        }

        public void TicketDispensed()
        {
            entryBarrier.Raise();
        }

        public void CarEnteredCarPark()
        {
            entryBarrier.Lower();
            currentSpaces--;       //decrements the available spaces by one as the car entered the carpark.
        }

        public void CarArrivedAtExit()
        {
            ticketValidator.CarArrived();
        }

        public void TicketValidated()
        {
            exitBarrier.Raise();
        }

        public void CarExitedCarPark()
        {
            exitBarrier.Lower();
            currentSpaces++;            //increments the current spaces by 1, as the car left the car park.
        }

        public bool IsFull()
        {
            if(currentSpaces == 0)
            {
                fullSign.SetLit(1);
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool IsEmpty()
        {
            if(currentSpaces == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool HasSpace()
        {
            if(currentSpaces < maxSpaces)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public int GetCurrentSpaces()
        {
            return currentSpaces;
        }

    }
}
