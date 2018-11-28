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

        public void SetLit(int on)
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
