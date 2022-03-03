using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        [DataRow((ushort)0)]
        [ExpectedException(typeof(RomanNumberException))]
        public void RomanNumberTest_ValueZero(ushort n)
        {
            RomanNumber number = new RomanNumber(n);
        }

        [TestMethod()]
        [DataRow((ushort)5, "V")]
        [DataRow((ushort)39, "XXXIX")]
        [DataRow((ushort)498, "CDXCVIII")]
        [DataRow((ushort)3789, "MMMDCCLXXXIX")]
        public void ToStringTest(ushort number, string expected)
        {
            string actual = new RomanNumber(number).ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow((ushort)5, "V")]
        [DataRow((ushort)39, "XXXIX")]
        [DataRow((ushort)498, "CDXCVIII")]
        [DataRow((ushort)3789, "MMMDCCLXXXIX")]
        public void CloneTest(ushort number, string expected)
        {
            RomanNumber roman = new RomanNumber(number);
            RomanNumber clone = (RomanNumber)roman.Clone();
            Assert.AreEqual(expected, clone.ToString());
        }

        [TestMethod()]
        [DataRow(5, 10, true)]
        [DataRow(10, 10, false)]
        [DataRow(100, 10, false)]
        public void CompareToTest(int n1, int n2, bool expected)
        {
            RomanNumber number1 = new RomanNumber((ushort)n1);
            RomanNumber number2 = new RomanNumber((ushort)n2);
            Assert.AreEqual(number1.CompareTo(number2) < 0, expected);
        }

        [TestMethod()]
        [DataRow(5, null)]
        [DataRow(5, new int[] {0,1})]
        [ExpectedException(typeof(RomanNumberException))]
        public void CompareToTest_exception(int num, object obj)
        {
            RomanNumber number = new RomanNumber((ushort)num);
            number.CompareTo(obj);
        }
    }
}