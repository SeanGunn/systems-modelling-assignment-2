using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class EntrySensor : Sensor
    {
        public EntrySensor(CarPark carpark)
        {
            //constructor
        }
        public override void CarDetected(CarPark carPark)
        {
            carOnSensor = true;
            carPark.CarArrivedAtEntrance();
        }

        public override void CarLeftSensor(CarPark carPark)
        {
            carOnSensor = false;
            carPark.CarEnteredCarPark();
        }
    }
}