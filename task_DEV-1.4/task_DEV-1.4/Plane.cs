using System;

namespace task_DEV_1._4
{
    class Plane : IFlyable 
    {
        const int MaxDistance = 2500;
        private int _speed = 200;
        private Coordinate _currentPoint;
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
            if (distance > MaxDistance)
            {
                throw new Exception("Maximum flight range" + MaxDistance);
            }
            float finalSpeed = distance + _speed;
            float acceleration = (float)(Math.Pow((finalSpeed), 2) + Math.Pow((_speed), 2))/(2*distance);
            return (finalSpeed-_speed) / acceleration;
        }
    }
}
