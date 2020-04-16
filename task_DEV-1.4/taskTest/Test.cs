using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task_DEV_1._4;

namespace taskTest 
{ 
        [TestClass]
        public class CoordinateTests
        {
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            [DataRow(-1, 2, 3)]
            [DataRow(0, -1, 1)]
            [DataRow(1, 2, -3)]
            public void CoordinateIncorrectArgumentThrowsArgumentException(float x, float y, float z)
            {
                var coordinate = new Coordinate(x, y, z);
            }
            [TestMethod]
            public void getDistanceTest()
            {
                var coordinate1 = new Coordinate(1, 0, 0);
                var coordinate2 = new Coordinate(2, 0, 0);
                float expected = 1;

                float actual = coordinate2.getDistance(coordinate2);

                Assert.AreEqual(expected, actual);
            }
        }
        [TestClass]
        public class DroneTest
        {
            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void DroneIncorrectDestinationThrowsArgumentOutOfRangeException()
            {
                var CurrentPoint = new Coordinate(0, 0, 0);
                var DestinationPoint = new Coordinate(1000, 1000, 1000);
                var drone = new Drone(CurrentPoint);
                drone.GetFlyTime(DestinationPoint);
            }
        }

        [TestClass]
        public class PlaneTests
        {
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void PlaneIncorrectDestinationThrowsArgumentOutOfRangeException()
            {
                var CurrentPoint = new Coordinate(0, 0, 0);
                var DestinationPoint = new Coordinate(2500, 2500, 2500);
                var plane = new Plane(CurrentPoint);
                plane.GetFlyTime(DestinationPoint);
            }
        }
}