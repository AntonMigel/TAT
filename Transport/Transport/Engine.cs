using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    class Engine
    {
        private int _power;
        private float _volume;
        private string _type;
        private string _serialNumber;

        public int Power { get; set; }
        public float Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        public Engine()
        {
            Power = 0;
            Volume = 0f;
            Type = "0";
            SerialNumber = "0";
        }

        public void getInformation()
        {
            Console.WriteLine(" Engine ");
            Console.WriteLine($"Power: {Power}  Volume : {Volume} Type : {Type}  Serial Number {SerialNumber}");
        }
    }
}

