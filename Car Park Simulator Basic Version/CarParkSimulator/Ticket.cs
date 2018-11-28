using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Ticket
    {
        private bool paid = false;

        public Ticket()
        {
            //new ticket
        }

        public bool IsPaid()
        {
            if(paid)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void SetPaid()
        {
            paid = true;
        }
    }
}
