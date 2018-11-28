using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class FullSign
    {
        private bool lit;

        public bool IsLit()
        {
            if(lit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetLit(int on)    //takes in either 1 or 0, 1 sets the fullsign to true, 0 sets it to false.
        {
            if (on == 1)  
            {
                lit = true;
            }

            else
            {
                lit = false;
            }
        }
    }
}
