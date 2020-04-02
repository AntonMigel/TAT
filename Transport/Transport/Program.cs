using System;
using System.Collections.Generic;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Vehicle> autopark = new List<Vehicle>();
                Creator CreatorAutomatic = new AutomaticTransmissionFactory();
                Creator CreatorManual = new ManualTransmissionFactory();
                Creator CreatorBus = new BusFactory();
                Creator CreatorTruck = new BusFactory();
                autopark.Add(CreatorAutomatic.Create());
                autopark.Add(CreatorManual.Create());
                autopark.Add(CreatorBus.Create());
                autopark.Add(CreatorTruck.Create());
            }
            catch (Exception Exc)
            {
                Console.WriteLine(Exc.Message);
            }
        }
    }
}
