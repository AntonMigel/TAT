namespace Transport
{
    class BusFactory : Creator
    {
        const int numberOfSeats = 45;
        public Vehicle Create()
        {
            Engine engine = new Engine(120, 3.0f, "Gasoline", "A24rdf4");
            Transmission transmission = new Transmission("automatic", 5, "MAZ");
            Chassis chassis = new Chassis(6, "adsad3", 4500);
            return new Bus(engine, chassis, transmission, numberOfSeats);
        }
    }

}