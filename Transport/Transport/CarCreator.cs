using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    class CarCreator : Creator
    {
        public  Vehicle Create()
        {
            Engine engine = new Engine(90, 1.8f, "Gasoline", "A24rdf4");
            Transmission transmission = new Transmission("automatic", 5, "VM");
            Chassis chassis = new Chassis(4, "adsad3", 3000);
            return new Car(engine, chassis, transmission);
        }
    }

}
