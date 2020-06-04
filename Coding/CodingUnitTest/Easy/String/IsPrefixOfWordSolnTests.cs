using LeetCode.AskGif.Easy.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Easy.String
{
    [TestClass]
    public class IsPrefixOfWordSolnTests
    {
        [TestMethod]
        public void IsPrefixOfWordSoln_First()
        {
            var sentence = "i love eating burger";
            var searchWord = "burg";
            var output = 4;
            var res = new IsPrefixOfWordSoln().IsPrefixOfWord(sentence, searchWord);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void IsPrefixOfWordSoln_Second()
        {
            var sentence = "this problem is an easy problem";
            var searchWord = "pro";
            var output = 2;
            var res = new IsPrefixOfWordSoln().IsPrefixOfWord(sentence, searchWord);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void IsPrefixOfWordSoln_Fourth()
        {
            var sentence = "i use triple pillow";
            var searchWord = "pill";
            var output = 4;
            var res = new IsPrefixOfWordSoln().IsPrefixOfWord(sentence, searchWord);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void IsPrefixOfWordSoln_Third()
        {
            var sentence = "i am tired";
            var searchWord = "you";
            var output = -1;
            var res = new IsPrefixOfWordSoln().IsPrefixOfWord(sentence, searchWord);

            Assert.AreEqual(res, output);
        }

        [TestMethod]
        public void IsPrefixOfWordSoln_Fifth()
        {
            var sentence = "hello from the other side";
            var searchWord = "they";
            var output = -1;
            var res = new IsPrefixOfWordSoln().IsPrefixOfWord(sentence, searchWord);

            Assert.AreEqual(res, output);
        }
    }
}
