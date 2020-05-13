using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class Tree2strSolnTests
    {
        [TestMethod]
        public void Tree2strSoln_First()
        {
            var Node_4 = new TreeNode(4);
            var Node_3 = new TreeNode(3);
            var Node_2 = new TreeNode(2, Node_4);
            var Node_1 = new TreeNode(1, Node_2, Node_3);
            var output = "1(2(4))(3)";
            var res = new Tree2strSoln().Tree2str(Node_1);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void Tree2strSoln_Second()
        {
            var Node_4 = new TreeNode(4);
            var Node_3 = new TreeNode(3);
            var Node_2 = new TreeNode(2, null, Node_4);
            var Node_1 = new TreeNode(1, Node_2, Node_3);
            var output = "1(2()(4))(3)";
            var res = new Tree2strSoln().Tree2str(Node_1);

            Assert.AreEqual(res, output);
        }
    }
}
