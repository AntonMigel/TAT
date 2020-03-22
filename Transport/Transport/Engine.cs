using System;

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
        public string Type 
        {
            get => _type;
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException();
                }
                _type = value;
            }
        }
        public string SerialNumber 
        {
            get => _serialNumber;
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException();
                }
                _serialNumber = value;
            }
        }
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

