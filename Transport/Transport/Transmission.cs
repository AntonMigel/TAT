using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    class Transmission
    {
        private string _type;
        private int _numberOfGears;
        private string _manufacturer;
        public string Type { get; set; }
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
        public Transmission()
        {
            Type = "0";
            NumberOfGears = 0;
            Manufacturer = "0";
        }
        public void getInformation()
        {
            Console.WriteLine(" Transmission ");
            Console.WriteLine($"Type: {Type}   Number Of Gears : {NumberOfGears}  Manufacturer : {Manufacturer}  ");
        }
    }
}
