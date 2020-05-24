using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingUnitTest.Util
{
    public class ContractAssert
    {
        public static void AreEqual(char[] expected, char[] actual)
        {
            for(int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }            
        }
    }
}
