using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    class Truck : Vehicle
    {
        private const string typeOfVehicle = "Truck";
        public Truck(Engine engine, Chassis chassis, Transmission transmission)
              : base(engine, chassis, transmission, typeOfVehicle)
        {
        }
        public override void getInformation()
        {
            base.getInformation();
        }

    }
}
