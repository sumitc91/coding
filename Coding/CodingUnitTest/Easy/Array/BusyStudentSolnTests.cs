using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class BusyStudentSolnTests
    {
        [TestMethod]
        public void BusyStudentSoln_First()
        {
            var startTime = new int[] { 1, 2, 3 };
            var endTime = new int[] { 3, 2, 7 };
            var queryTime = 4;
            var output = 1;
            var res = new BusyStudentSoln().BusyStudent(startTime, endTime, queryTime);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void BusyStudentSoln_Second()
        {
            var startTime = new int[] { 4 };
            var endTime = new int[] { 4 };
            var queryTime = 4;
            var output = 1;
            var res = new BusyStudentSoln().BusyStudent(startTime, endTime, queryTime);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void BusyStudentSoln_Third()
        {
            var startTime = new int[] { 1, 1, 1, 1 };
            var endTime = new int[] { 1, 3, 2, 4 };
            var queryTime = 7;
            var output = 0;
            var res = new BusyStudentSoln().BusyStudent(startTime, endTime, queryTime);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void BusyStudentSoln_Fourth()
        {
            var startTime = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var endTime = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            var queryTime = 5;
            var output = 5;
            var res = new BusyStudentSoln().BusyStudent(startTime, endTime, queryTime);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void BusyStudentSoln_Fifth()
        {
            var startTime = new int[] { 4 };
            var endTime = new int[] { 4 };
            var queryTime = 5;
            var output = 0;
            var res = new BusyStudentSoln().BusyStudent(startTime, endTime, queryTime);

            Assert.AreEqual(res, output);
        }
    }
}
