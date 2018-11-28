using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ExitSensor : Sensor
    {
        public ExitSensor(CarPark obj)
        {
            //constructor
        }
        public override void CarDetected(CarPark carPark)
        {
            carOnSensor = true;
            carPark.CarArrivedAtExit();
        }

        public override void CarLeftSensor(CarPark carPark)
        {
            carOnSensor = false;
            carPark.CarExitedCarPark();
        }
    }
}
