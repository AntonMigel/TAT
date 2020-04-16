using System;

namespace task_DEV_1._4
{
    public struct Coordinate
    {

        private float _x;
        private float _y;
        private float _z;
        public float X 
        {
            get => _x;
            set 
            {
                if (value < 0)
                    throw new Exception("Negative component");
                _x = value;
            } 
        }
        public float Y
        {
            get => _y;
            set
            {
                if (value < 0)
                    throw new Exception("Negative component");
                _y = value;
            }
        }
        public float Z
        {
            get => _z;
            set
            {
                if (value < 0)
                    throw new Exception("Negative component");
                _z = value;
            }
        }

        public Coordinate(float x, float y, float z) : this()
        {
          
            X = x;
            Y = y;
            Z = z;
        }
        public float getDistance(Coordinate coordinate)
        {
            double distance = Math.Sqrt(Math.Pow((X - coordinate.X), 2) + Math.Pow((Y - coordinate.Y), 2) + Math.Pow((Z - coordinate.Z), 2));
            return (float) distance;
        }
    }
}
