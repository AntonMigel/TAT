using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    abstract class Vehicle
    {
        private Engine _engine;
        private Chassis _chassis;
        private Transmission _transmission;
        private string _typeOfVehicle;
        public Vehicle(Engine engine, Chassis chassis, Transmission transmission, string typeOfVehicle)
        {
            _engine = engine;
            _chassis = chassis;
            _transmission = transmission;
            _typeOfVehicle = typeOfVehicle;
        }

        public virtual void getInformation() 
        {
            Console.WriteLine("Vehicle type is " + _typeOfVehicle);
            _engine.getInformation();
            _chassis.getInformation();
            _transmission.getInformation();
        }

    }
}
