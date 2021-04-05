using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Numerics;

namespace AlgorithmsLab1
{
    [TestFixture]
    class Test_AdditionalOperations
    {
        [Test]
        public void SimpleNumberIsCheckedCorrectly()
        {
            Assert.False(RSA.IsTheNumberSimple(0));
            Assert.False(RSA.IsTheNumberSimple(1));
            Assert.True(RSA.IsTheNumberSimple(2));
            Assert.True(RSA.IsTheNumberSimple(3));
            Assert.False(RSA.IsTheNumberSimple(4));
            Assert.True(RSA.IsTheNumberSimple(5));
            Assert.False(RSA.IsTheNumberSimple(6));
            Assert.True(RSA.IsTheNumberSimple(7));
            Assert.False(RSA.IsTheNumberSimple(8));
            Assert.False(RSA.IsTheNumberSimple(9));
            Assert.False(RSA.IsTheNumberSimple(10));
            Assert.True(RSA.IsTheNumberSimple(103));
            Assert.True(RSA.IsTheNumberSimple(997));
        }

        [Test]
        public void Calculate_E_WorksCorrectly()
        {
            Assert.True(RSA.IsTheNumberSimple(RSA.Calculate_e(8)));
            Assert.AreEqual(7, RSA.Calculate_e(8));
            Assert.True(RSA.IsTheNumberSimple(RSA.Calculate_e(120)));
            Assert.AreEqual(113, RSA.Calculate_e(120));
            Assert.True(RSA.IsTheNumberSimple(RSA.Calculate_e(18000)));
            Assert.AreEqual(17989, RSA.Calculate_e(18000));
        }

        [Test]
        public void Calculate_D_WorksCorrectly()
        {
            Assert.AreEqual(7, RSA.Calculate_d(RSA.Calculate_e(8), 8));
            Assert.AreEqual(4361, RSA.Calculate_d(RSA.Calculate_e(10176), 10176));
            Assert.AreEqual(235, RSA.Calculate_d(RSA.Calculate_e(1176), 1176));
        }
    }

    [TestFixture]
    class Test_EncodedAndDecode
    {
        [Test]
        public void TextIsEncodedCorrectly()
        {
            Assert.AreEqual(0, RSA.Encode("", 3, 7).Count);

            var text = "sample text";
            var encodedText = RSA.Encode(text, 13, 17);
            Assert.AreEqual(text.Length, encodedText.Count);

            foreach (var encodedChar in encodedText)
                try { int.Parse(encodedChar); }
                catch { Assert.Fail(); }

        }

        [Test]
        public void CharIsEncodedCorrectly()
        {
            var p = 13;
            var q = 17;
            long n = p * q;
            long fi = (p - 1) * (q - 1);
            long e = RSA.Calculate_e(fi);

            for (int i = 0; i < 5; i++)
            {
                int index = new Random().Next(0, RSA.Characters.Length);
                var a = RSA.Characters[index].ToString();

                var actual = long.Parse(RSA.Encode(a, e, n)[0]);

                var expected = new BigInteger(index);
                expected = BigInteger.Pow(expected, (int)e);
                BigInteger n_ = new BigInteger((int)n);
                expected = expected % n_;

                Assert.AreEqual((long)expected, actual);
            }
        }

        [Test]
        public void CharIsDecodedCorrectly()
        {
            var p = 13;
            var q = 17;
            long n = p * q;
            long fi = (p - 1) * (q - 1);
            long e = RSA.Calculate_e(fi);
            long d = RSA.Calculate_d(e, fi);

            for (int i = 0; i < 5; i++)
            {
                int index = new Random().Next(0, RSA.Characters.Length);
                var a = RSA.Characters[index].ToString();

                var actual = RSA.Decode(new List<string>(){RSA.Encode(a, e, n)[0]}, d, n);

                Assert.AreEqual(a, actual);
            }
        }

        [Test]
        public void TextIsDecodedCorrectly()
        {
            var text = "sample text";
            var p = 13;
            var q = 17;
            long n = p * q;
            long fi = (p - 1) * (q - 1);
            long e_ = RSA.Calculate_e(fi);
            long d = RSA.Calculate_d(e_, fi);
            var encodedText = RSA.Encode(text, e_, n);
            var decodedText = RSA.Decode(encodedText, d, n);
            Assert.AreEqual(text, decodedText);
        }
    }
}
