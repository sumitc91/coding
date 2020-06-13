using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class DayOfTheWeekSolnTests
    {
        [TestMethod]
        public void DayOfTheWeekSoln_First()
        {
            var day = 31;
            var month = 8;
            var year = 2019;

            var output = "Saturday";

            var res = new DayOfTheWeekSoln().DayOfTheWeek(day, month, year);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void DayOfTheWeekSoln_Second()
        {
            var day = 18;
            var month = 7;
            var year = 1999;

            var output = "Sunday";

            var res = new DayOfTheWeekSoln().DayOfTheWeek(day, month, year);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void DayOfTheWeekSoln_Third()
        {
            var day = 15;
            var month = 8;
            var year = 1993;

            var output = "Sunday";

            var res = new DayOfTheWeekSoln().DayOfTheWeek(day, month, year);

            Assert.AreEqual(output, res);
        }
    }
}
