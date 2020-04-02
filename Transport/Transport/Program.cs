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
                Creator[] CreatorAutomatic = new AutomaticTransmissionFactory[2];
                Creator[] CreatorManual = new ManualTransmissionFactory[3];
                Creator[] CreatorBus = new BusFactory[2];
                Creator[] CreatorTruck = new BusFactory[2];
                autopark.Add(CreatorAutomatic[1].Create());
                autopark.Add(CreatorAutomatic[2].Create());
                autopark.Add(CreatorManual[1].Create());
                autopark.Add(CreatorManual[2].Create());
                autopark.Add(CreatorManual[3].Create());
                autopark.Add(CreatorBus[1].Create());
                autopark.Add(CreatorBus[2].Create());
                autopark.Add(CreatorTruck[1].Create());
                autopark.Add(CreatorTruck[2].Create());
                
            }
            catch (Exception Exc)
            {
                Console.WriteLine(Exc.Message);
            }
        }
    }
}
