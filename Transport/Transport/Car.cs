namespace Transport
{
    class Car: Vehicle
    {
       private const string typeOfVehicle = "Car";
        public Car(Engine engine, Chassis chassis, Transmission transmission)
              : base(engine, chassis, transmission, typeOfVehicle) 
        { 
        }
        public override void getInformation()
        {
            base.getInformation();
        }
    }
}
