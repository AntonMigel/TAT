using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_1._4
{
    class Plane : IFlyable 
    {
        private int _speed = 200;
        public Plane(Coordinate currentPoint)
        {
            CurrentPoint = currentPoint;
        }
        public int Speed { get; set; }
        public Coordinate CurrentPoint { get; set; }
        public void FlyTo(Coordinate destinationPoint)
        {
            CurrentPoint = destinationPoint;
        }
        public float GetFlyTime(Coordinate destinationPoint)
        {
            float distance = destinationPoint.getDistance(CurrentPoint);
            float time = 0;
      
            return time = distance / Speed;
        }
    }
}
