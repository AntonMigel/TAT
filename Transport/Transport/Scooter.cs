using System;

namespace Transport
{
    class Scooter : Vehicle
    {
        private const string typeOfVehicle = "Scooter";
        private string _producingCountry;
        public string ProducingCountry 
        { 
            get => _producingCountry;
            set 
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException();
                }
                _producingCountry = value;
            }
        }
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
