namespace Transport
{
    class Bus : Vehicle
    {
        private const string typeOfVehicle = "Bus";
        public Bus(Engine engine, Chassis chassis, Transmission transmission)
              : base(engine, chassis, transmission, typeOfVehicle)
        {
        }
        public override void getInformation()
        {
            base.getInformation();
        }

    }
}
