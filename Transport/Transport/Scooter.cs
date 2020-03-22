using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    class Scooter : Vehicle
    {
        private const string typeOfVehicle = "Scooter";
        private string _producingCountry;
        public string ProducingCountry { get; set; }
        public Scooter(Engine engine, Chassis chassis, Transmission transmission,string producingCountry )
              : base(engine, chassis, transmission, typeOfVehicle)
        {
            ProducingCountry = producingCountry;
        }
        public override void getInformation()
        {
            
            base.getInformation();
            Console.WriteLine("Producing Country is  " + ProducingCountry);
        }
    }
}
