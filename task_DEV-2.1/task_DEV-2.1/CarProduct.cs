using System;

namespace task_DEV_2._1
{
    class CarProduct
    {
        private string _brand;
        private string _model;
        private int _count;
        public int _price;
        public string Brand
        {
            get => _brand;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                foreach (char c in value)
                {
                    if (!Char.IsLetter(c))
                        throw new ArgumentException();
                }
                _brand = value;
            }
        }
        public string Model
        {
            get => _model;
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
                _model = value;
            }
        }
        public int Count { get; set; }
        public int Price { get; set; }

        public CarProduct(string brand, string model, int count, int price)
        {
            Brand = brand;
            Model = model;
            Count = count;
            Price = price;
        }

    }
}

