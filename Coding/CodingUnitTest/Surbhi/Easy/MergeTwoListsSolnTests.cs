using LeetCode.AskGif.Surbhi.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Surbhi.Easy
{
    [TestClass]
    public class MergeTwoListsSolnTests
    {
        [TestMethod]
        public void MergeTwoListsSoln_First()
        {
            var LL1_1 = new ListNode(1,null);
            var LL1_2 = new ListNode(2, null);
            var LL1_4 = new ListNode(4, null);
            LL1_1.next = LL1_2;
            LL1_2.next = LL1_4;

            var LL2_1 = new ListNode(1, null);
            var LL2_3 = new ListNode(3, null);
            var LL2_4 = new ListNode(4, null);
            LL2_1.next = LL2_3;
            LL2_3.next = LL2_4;

            var output_4 = new ListNode(4, null);
            var output_44 = new ListNode(4, output_4);
            var output_3 = new ListNode(3, output_44);
            var output_2 = new ListNode(2, output_3);
            var output_11 = new ListNode(1, output_2);
            var output_1 = new ListNode(1, output_2);
    
            var res = new MergeTwoListsSoln().MergeTwoLists(LL1_1, LL2_1);

            Assert.AreEqual(res, output_1);
        }
    }
}
