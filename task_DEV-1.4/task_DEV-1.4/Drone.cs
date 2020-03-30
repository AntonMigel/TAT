using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_1._4
{
    class Drone : IFlyable
    {
        const int StopTime = 10;
        const int MaxDistance = 1000;
        private int _speed = 10;
        private Coordinate _currentPoint;

        public int Speed { get; set; }
        public Coordinate CurrentPoint { get; set; }
        public Drone (Coordinate currentLocation)
        {
            CurrentPoint = currentLocation;
        }
        public void FlyTo(Coordinate newPoint)
        {
            CurrentPoint = newPoint;
        }
        public float GetFlyTime(Coordinate destinationPoint)
        {
            float time, stoptime ;
            if (destinationPoint.getDistance(CurrentPoint) > MaxDistance)
            {
                throw new Exception("The drone can't fly more than that"+MaxDistance);
            }
            time =destinationPoint.getDistance(CurrentPoint) / Speed;
            stoptime = time / StopTime;
            return time+stoptime;
        }
    }
}
