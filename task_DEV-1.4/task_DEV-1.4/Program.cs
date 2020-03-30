using System;

namespace task_DEV_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Coordinate p1 = new Coordinate(0, 0, 0);
                Coordinate p2 = new Coordinate(100, 100, 100);
                Console.WriteLine(p2.getDistance(p1));
                Bird bird = new Bird(p1);
                Console.WriteLine(bird.GetFlyTime(p2));
                bird.FlyTo(p2);
                Drone drone = new Drone(p1);
                Console.WriteLine(drone.GetFlyTime(p2));
                drone.FlyTo(p2);
                Plane plane = new Plane(p1);
                Console.WriteLine(plane.GetFlyTime(p2));
                plane.FlyTo(p2);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
