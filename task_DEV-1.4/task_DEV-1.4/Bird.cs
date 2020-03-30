using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_1._4
{
    class Bird : IFlyable
    {   
        const int min = 0, max = 20;
        private Coordinate _currentPoint;
        public Coordinate CurrentPoint { get; set; }
        public Bird(Coordinate currentLocation)
        {
            CurrentPoint = currentLocation;
        }
        public void FlyTo(Coordinate newPoint)
        {
            CurrentPoint = newPoint;
        }
        public float GetFlyTime(Coordinate destinationPoint)
        {
            Random rand = new Random();
            return destinationPoint.getDistance(CurrentPoint) / rand.Next(min, max);
        }
    }
}
