using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    class TruckFactory
    : Creator
    {
        public Vehicle Create()
        {
            Engine engine = new Engine(210, 10.85f, "Gasoline", "A24rdf4");
            Transmission transmission = new Transmission("manual", 5, "KAMAZ");
            Chassis chassis = new Chassis(6, "adsad3", 10000);
            return new Truck(engine, chassis, transmission);
        }
    }

}