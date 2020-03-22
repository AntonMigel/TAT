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
                foreach (char c in value)
                {
                  if (!Char.IsLetter(c))
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
                foreach (char c in value)
                {
                    if (!Char.IsLetter(c))
                        throw new ArgumentException();
                }
                _manufacturer = value;
            }
        }
        public Transmission()
        {
            Type = "o";
            NumberOfGears = 0;
            Manufacturer = "o";
        }
        public void getInformation()
        {
            Console.WriteLine(" Transmission ");
            Console.WriteLine($"Type: {Type}   Number Of Gears : {NumberOfGears}  Manufacturer : {Manufacturer}  ");
        }
    }
}
