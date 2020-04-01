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
                foreach (char c in value)
                {
                    if (!Char.IsLetter(c))
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
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                foreach (char c in value)
                {
                    if (!Char.IsLetterOrDigit(c))
                        throw new ArgumentException();
                }
                _serialNumber = value;
            }
        }
        public Engine(int power,float volume,string type,string serialnumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialnumber;
        }

        public void getInformation()
        {
            Console.WriteLine(" Engine ");
            Console.WriteLine($"Power: {Power}  Volume : {Volume} Type : {Type}  Serial Number {SerialNumber}");
        }
    }
}

