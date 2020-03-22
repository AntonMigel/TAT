using System;

namespace Transport
{
    class Scooter : Vehicle
    {
        private const string typeOfVehicle = "Scooter";
        private string _owner;
        public string Owner 
        { 
            get => _owner;
            set 
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException();
                }
                foreach (char c in value)
                {
                    if (!Char.IsLetter(c))
                        throw new ArgumentException();
                }
                _owner = value;
            }
        }
        public Scooter(Engine engine, Chassis chassis, Transmission transmission,string owner )
              : base(engine, chassis, transmission, typeOfVehicle)
        {
            Owner = owner;
        }
        public override void getInformation()
        {
            
            base.getInformation();
            Console.WriteLine(" Owner : " + Owner);
        }
    }
}
