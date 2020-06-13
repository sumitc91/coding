using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class DistanceBetweenBusStopsSolnTests
    {
        [TestMethod]
        public void DistanceBetweenBusStopsSoln_First()
        {
            var distance = new int[] { 1, 2, 3, 4 };
            var start = 0;
            var destination = 1;

            var output = 1;

            var res = new DistanceBetweenBusStopsSoln().DistanceBetweenBusStops(distance, start, destination);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void DistanceBetweenBusStopsSoln_Second()
        {
            var distance = new int[] { 1, 2, 3, 4 };
            var start = 0;
            var destination = 2;

            var output = 3;

            var res = new DistanceBetweenBusStopsSoln().DistanceBetweenBusStops(distance, start, destination);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void DistanceBetweenBusStopsSoln_Third()
        {
            var distance = new int[] { 1, 2, 3, 4 };
            var start = 0;
            var destination = 3;

            var output = 4;

            var res = new DistanceBetweenBusStopsSoln().DistanceBetweenBusStops(distance, start, destination);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void DistanceBetweenBusStopsSoln_Fourt()
        { 
            var distance = new int[] { 7, 10, 1, 12, 11, 14, 5, 0 };
            var start = 7;
            var destination = 2;

            var output = 17;

            var res = new DistanceBetweenBusStopsSoln().DistanceBetweenBusStops(distance, start, destination);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void DistanceBetweenBusStopsSoln_Fifth()
        {           
            var distance = new int[] { 3, 6, 7, 2, 9, 10, 7, 16, 11 };
            var start = 6;
            var destination = 2;

            var output = 28;

            var res = new DistanceBetweenBusStopsSoln().DistanceBetweenBusStops(distance, start, destination);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void DistanceBetweenBusStopsSoln_Sixth()
        {            
            var distance = new int[] { 14, 13, 4, 7, 10, 17, 8, 3, 2, 13 };
            var start = 2;
            var destination = 9;

            var output = 40;

            var res = new DistanceBetweenBusStopsSoln().DistanceBetweenBusStops(distance, start, destination);

            Assert.AreEqual(output, res);
        }
    }
}
