using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    class Chassis
    {
        private int _numberOfWheels;
        private string _number;
        private double _permissibleLoad;
        public int NumberOfWheels { get; set; }
        public string Number { get; set; }
        public double PermissibleLoad { get; set; }
        public Chassis()
        {
            NumberOfWheels = 0;
            Number = "0";
            PermissibleLoad = 0.0;
        }
        public void getInformation()
        {
            Console.WriteLine(" Chassis ");
            Console.WriteLine($"Number Of Wheels: {NumberOfWheels}  Number : {Number} Permissible Load : {PermissibleLoad} ");
        }
    }
}
