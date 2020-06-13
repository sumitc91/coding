using LeetCode.AskGif.Easy.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.Array
{
    [TestClass]
    public class MinCostToMoveChipsSolnTests
    {
        [TestMethod]
        public void MinCostToMoveChipsSoln_First()
        {
            var chips = new int[] { 1, 2, 3 };
            var output = 1;

            var res = new MinCostToMoveChipsSoln().MinCostToMoveChips(chips);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void MinCostToMoveChipsSoln_Second()
        {
            var chips = new int[] { 2, 2, 2, 3, 3 };
            var output = 2;

            var res = new MinCostToMoveChipsSoln().MinCostToMoveChips(chips);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void MinCostToMoveChipsSoln_Third()
        {
            var chips = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            var output = 15;

            var res = new MinCostToMoveChipsSoln().MinCostToMoveChips(chips);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void MinCostToMoveChipsSoln_Fourth()
        {
            var chips = new int[] { 1, 2, 2, 2, 2 };
            var output = 1;

            var res = new MinCostToMoveChipsSoln().MinCostToMoveChips(chips);

            Assert.AreEqual(output, res);
        }

        [TestMethod]
        public void MinCostToMoveChipsSoln_Fifth()
        {
            var chips = new int[] { 6, 4, 7, 8, 2, 10, 2, 7, 9, 7 };
            var output = 4;

            var res = new MinCostToMoveChipsSoln().MinCostToMoveChips(chips);

            Assert.AreEqual(output, res);
        }
    }
}
