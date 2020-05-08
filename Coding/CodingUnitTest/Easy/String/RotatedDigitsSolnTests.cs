using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class RotatedDigitsSolnTests
    {
        [TestMethod]
        public void RotatedDigits_10()
        {
            var input = 10;
            var expected = 4;

            var res = new RotatedDigitsSoln().RotatedDigits(input);
            Assert.AreEqual(res, expected);
        }

    }
}
