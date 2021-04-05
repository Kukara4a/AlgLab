using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AlgorithmsLab1
{
    [TestFixture]
    class Test_logicalOperations
    {
        [Test]
        public void test1()
        {
            var a = new BigInt("0");
            var b = new BigInt("0");
            var c = new BigInt("1");
            var d = new BigInt("-1");

            Assert.IsTrue(a == b);
            Assert.IsFalse(a == c);
            Assert.IsFalse(a == d);
            Assert.IsFalse(c == d);
        }

        public void test2()
        {
            var a = new BigInt("0");
            var b = new BigInt("0");
            var c = new BigInt("1");
            var d = new BigInt("-1");

            Assert.IsFalse(a != b);
            Assert.IsTrue(a != c);
            Assert.IsTrue(a != d);
            Assert.IsTrue(c != d);
        }
    }


    [TestFixture]
    class Test_Addition
    {
        [Test]
        public void ClassObjectHasCorrectNumber()
        {
            var input = "1234";
            var byteNumber = new BigInt(input);
            Assert.AreEqual(input, byteNumber.ToString());
        }

        [Test]
        public void ClassObjectHasCorrectSign()
        {
            var input = "5";
            var byteNumber = new BigInt(input);
            Assert.AreEqual(1, byteNumber.Sign);
            input = "-5";
            byteNumber = new BigInt(input);
            Assert.AreEqual(-1, byteNumber.Sign);
        }

        [Test]
        public void SumOperatorWorksCorrectly()
        {
            Assert.AreEqual("-11", (new BigInt("-2") + new BigInt("-9")).ToString());
            Assert.AreEqual("2", (new BigInt("1") + new BigInt("1")).ToString());
            Assert.AreEqual("0", (new BigInt("-1") + new BigInt("1")).ToString());
            Assert.AreEqual("0", (new BigInt("1") + new BigInt("-1")).ToString());
            Assert.AreEqual("10", (new BigInt("1") + new BigInt("9")).ToString());
            Assert.AreEqual("9", (new BigInt("11") + new BigInt("-2")).ToString());
            Assert.AreEqual("9", (new BigInt("-2") + new BigInt("11")).ToString());
            Assert.AreEqual("-2", (new BigInt("-1") + new BigInt("-1")).ToString());
            Assert.AreEqual("-5", (new BigInt("-10") + new BigInt("5")).ToString());
            Assert.AreEqual("-5", (new BigInt("5") + new BigInt("-10")).ToString());
            Assert.AreEqual("1000", (new BigInt("999") + new BigInt("1")).ToString());
        }

        [Test]
        public void DifferenceOperatorWorksCorrectly()
        {
            Assert.AreEqual("0", (new BigInt("1") - new BigInt("1")).ToString());
            Assert.AreEqual("-2", (new BigInt("-1") - new BigInt("1")).ToString());
            Assert.AreEqual("0", (new BigInt("-1") - new BigInt("-1")).ToString());
            Assert.AreEqual("9", (new BigInt("10") - new BigInt("1")).ToString());
            Assert.AreEqual("-9", (new BigInt("1") - new BigInt("10")).ToString());
            Assert.AreEqual("-11", (new BigInt("-2") - new BigInt("9")).ToString());
            Assert.AreEqual("7", (new BigInt("9") - new BigInt("2")).ToString());
            Assert.AreEqual("999", (new BigInt("1000") - new BigInt("1")).ToString());
            Assert.AreEqual("1000", (new BigInt("999") - new BigInt("-1")).ToString());
        }
    }
}
