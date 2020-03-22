using System;

namespace Transport
{
    class Transmission
    {
        private string _type;
        private int _numberOfGears;
        private string _manufacturer;
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
        public int NumberOfGears { get; set; }
        public string Manufacturer 
        { 
            get => _manufacturer;
            set 
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException();
                }
                _manufacturer = value;
            }
        }
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
