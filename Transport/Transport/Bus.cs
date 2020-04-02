using System;
namespace Transport
{
    class Bus : Vehicle
    {
        private const string typeOfVehicle = "Bus";
        private int _numberOfSeats;
        public int NumberOfSeats { get; set; }
        public Bus(Engine engine, Chassis chassis, Transmission transmission,int numberOfSeats)
              : base(engine, chassis, transmission, typeOfVehicle)
        {
            NumberOfSeats = numberOfSeats;
        }
        public override void getInformation()
        {
            base.getInformation();
            Console.WriteLine($"Number of seats  {NumberOfSeats}");
        }

    }
}
