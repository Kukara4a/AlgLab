using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AlgorithmsLab1
{
    [TestFixture]
    class Test_LogicalOperations
    {
        [Test]
        public void EqualsOperatorWorkCorrectly()
        {
            Assert.IsTrue(new BigInt("0") == new BigInt("0"));
            Assert.IsFalse(new BigInt("0") == new BigInt("1"));
            Assert.IsFalse(new BigInt("0") == new BigInt("-1"));
            Assert.IsFalse(new BigInt("-1") == new BigInt("1"));
            Assert.IsTrue(new BigInt("12345678901234567890") == new BigInt("12345678901234567890"));
        }

        [Test]
        public void GreaterOperatorWorkCorrectly()
        {
            Assert.IsFalse(new BigInt("0") > new BigInt("0"));
            Assert.IsFalse(new BigInt("0") > new BigInt("1"));
            Assert.IsTrue(new BigInt("1") > new BigInt("0"));
            Assert.IsTrue(new BigInt("0") > new BigInt("-1"));
            Assert.IsTrue(new BigInt("1") > new BigInt("-1"));
            Assert.IsFalse(new BigInt("-1") > new BigInt("0"));
            Assert.IsFalse(new BigInt("-1") > new BigInt("0"));
            Assert.IsFalse(new BigInt("123456789") > new BigInt("987654321"));
            Assert.IsFalse(new BigInt("-39502850285") > new BigInt("98765"));
            Assert.IsTrue(new BigInt("123") > new BigInt("-98765"));
        }
    }


    [TestFixture]
    class Test_AdditiveOperations
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
            Assert.AreEqual("0", (new BigInt("0") + new BigInt("0")).ToString());
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
            Assert.AreEqual("38", (new BigInt("19") + new BigInt("19")).ToString());
            Assert.AreEqual("300", (new BigInt("100") + new BigInt("200")).ToString());
            Assert.AreEqual("4986658478322", (new BigInt("4985693874527") + new BigInt("964603795")).ToString());
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
            Assert.AreEqual("-119", (new BigInt("-20") - new BigInt("99")).ToString());
            Assert.AreEqual("7", (new BigInt("9") - new BigInt("2")).ToString());
            Assert.AreEqual("999", (new BigInt("1000") - new BigInt("1")).ToString());
            Assert.AreEqual("1000", (new BigInt("999") - new BigInt("-1")).ToString());
        }
    }

    [TestFixture]
    class Test_MultiplicativeOperations
    {
        [Test]
        public void MultiplicationOperatorWorksCorrectly()
        {
            Assert.AreEqual("0", (new BigInt("0") * new BigInt("0")).ToString());
            Assert.AreEqual("0", (new BigInt("1") * new BigInt("0")).ToString());
            Assert.AreEqual("0", (new BigInt("0") * new BigInt("1")).ToString());
            Assert.AreEqual("1", (new BigInt("1") * new BigInt("1")).ToString());
            Assert.AreEqual("100", (new BigInt("10") * new BigInt("10")).ToString());
            Assert.AreEqual("-1", (new BigInt("1") * new BigInt("-1")).ToString());
            Assert.AreEqual("-1", (new BigInt("-1") * new BigInt("1")).ToString());
            Assert.AreEqual("123", (new BigInt("123") * new BigInt("1")).ToString());
            Assert.AreEqual("246420", (new BigInt("555") * new BigInt("444")).ToString());
            Assert.AreEqual("-133649026", (new BigInt("-386") * new BigInt("346241")).ToString());
            Assert.AreEqual("25", (new BigInt("-5") * new BigInt("-5")).ToString());
        }

        [Test]
        public void DivisionOperatorWorksCorrectly()
        {
            try
            {
                var division = new BigInt("1") / new BigInt("0");
                Assert.Fail();
            }
            catch { Assert.Pass(); }

            Assert.AreEqual("10", (new BigInt("0") / new BigInt("10")).ToString());
            Assert.AreEqual("10", (new BigInt("100") / new BigInt("10")).ToString());
            Assert.AreEqual("10", (new BigInt("100") / new BigInt("10")).ToString());
            Assert.AreEqual("-10", (new BigInt("-100") / new BigInt("10")).ToString());
            Assert.AreEqual("-10", (new BigInt("100") / new BigInt("-10")).ToString());
            Assert.AreEqual("99", (new BigInt("99") / new BigInt("1")).ToString());
            Assert.AreEqual("1", (new BigInt("99") / new BigInt("99")).ToString());
            Assert.AreEqual("11", (new BigInt("99") / new BigInt("9")).ToString());
            Assert.AreEqual("0", (new BigInt("5") / new BigInt("9")).ToString());
            Assert.AreEqual("3", (new BigInt("15") / new BigInt("4")).ToString());
            Assert.AreEqual("40", (new BigInt("200") / new BigInt("5")).ToString());
            Assert.AreEqual("1473861", (new BigInt("346357457") / new BigInt("235")).ToString());
        }

        [Test]
        public void DivisionWithRemainderOperatorWorksCorrectly()
        {
            try
            {
                var division = new BigInt("1") % new BigInt("0");
                Assert.Fail();
            }
            catch { Assert.Pass(); }

            Assert.AreEqual("0", (new BigInt("100") % new BigInt("10")).ToString());
            Assert.AreEqual("0", (new BigInt("0") % new BigInt("1")).ToString());
            Assert.AreEqual("4", (new BigInt("11") % new BigInt("7")).ToString());
            Assert.AreEqual("4", (new BigInt("-11") % new BigInt("7")).ToString());
            Assert.AreEqual("4", (new BigInt("11") % new BigInt("-7")).ToString());
            Assert.AreEqual("4", (new BigInt("-11") % new BigInt("-7")).ToString());
            Assert.AreEqual("8242", (new BigInt("98235987235792") % new BigInt("23525")).ToString());
            Assert.AreEqual("0", (new BigInt("456") % new BigInt("456")).ToString());
            Assert.AreEqual("0", (new BigInt("200") % new BigInt("4")).ToString());
        }
    }
}
