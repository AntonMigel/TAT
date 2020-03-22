using System;

namespace Transport
{
    class Chassis
    {
        private int _numberOfWheels;
        private string _number;
        private double _permissibleLoad;
        public int NumberOfWheels { get; set; }
        public string Number 
        {
            get => _number;
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException();
                }
                foreach (char c in value)
                {
                    if (!Char.IsLetterOrDigit(c))
                        throw new ArgumentException();
                }
                _number = value;
            }
        }
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
