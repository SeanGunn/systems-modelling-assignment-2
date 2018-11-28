using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Sensor
    {
        protected bool carOnSensor;
        protected CarPark carPark;

        public virtual void CarDetected(CarPark carPark)
        {
            carOnSensor = true;
        }

        public virtual void CarLeftSensor(CarPark carPark)
        {
            carOnSensor = false;
        }

        public bool IsCarOnSensor()
        {
            if(carOnSensor)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
