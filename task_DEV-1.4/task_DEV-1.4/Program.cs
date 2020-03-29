using System;

namespace task_DEV_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Coordinate p1 = new Coordinate(0, -1, 1);
                Coordinate p2 = new Coordinate(0, 1, 1);
                Console.WriteLine(p1.getDistance(p2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
