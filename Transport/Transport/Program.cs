using System;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Engine engine = new Engine(90, 1.8f, "Gasoline", "A24rdf4");
                Transmission transmission = new Transmission("reardrive", 5, "VM");
                Chassis chassis = new Chassis(4, "adsad3", 3000);
                Vehicle car = new Car(engine,  chassis, transmission);
                car.getInformation();
                Vehicle bus = new Bus(engine, chassis, transmission);
                bus.getInformation();
            }
            catch (Exception Exc)
            {
                Console.WriteLine(Exc.Message);
            }
        }
    }
}
