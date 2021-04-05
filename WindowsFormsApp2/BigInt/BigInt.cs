using System;
using System.Collections.Generic;

namespace AlgorithmsLab1
{
    class BigInt
    {
        public sbyte Sign = 1; // 1  =  +;  -1 = 
        public List<byte> Number = new List<byte>();

        public BigInt(sbyte sign, List<byte> number)
        {
            this.Sign = sign;
            this.Number = number;
        }

        public BigInt(string str)
        {
            int start = 0;
            if (str[0] == '-')
            {
                Sign = -1;
                start++;
            }

            for (int i = start; i < str.Length; i++)
                Number.Add((byte)(str[i] - '0'));
        }

        public static bool operator ==(BigInt a, BigInt b)
        {
            if (a.Sign != b.Sign || a.Number.Count != b.Number.Count)
                return false;

            for (int i = 0; i < a.Number.Count; i++)
                if (a.Number[i] != b.Number[i])
                    return false;

            return true;
        }

        public static bool operator !=(BigInt a, BigInt b) => !(a == b);

        public static bool operator >(BigInt a, BigInt b)
        {
            if (a.Sign != b.Sign)
                return a.Sign == 1;

            if (a.Number.Count != b.Number.Count)
                if (a.Sign == 1)
                    return a.Number.Count > b.Number.Count;
                else
                    return a.Number.Count < b.Number.Count;

            for (int i = 0; i < a.Number.Count; i++)
                if (a.Number[i] != b.Number[i])
                    if (a.Sign == 1)
                        return a.Number[i] > b.Number[i];
                    else
                        return a.Number[i] < b.Number[i];

            return false;
        }

        public static bool operator <(BigInt a, BigInt b) => a != b && !(a > b);

        public static bool operator <=(BigInt a, BigInt b) => a == b || a < b;

        public static bool operator >=(BigInt a, BigInt b) => a == b || a > b;

        public static BigInt operator +(BigInt a, BigInt b)
        {
            if (a.Number.Count > 0 && a.Number.TrueForAll(x => x == 0))
                a.Number = new List<byte>() { 0 };

            if (b.Number.Count > 0 && b.Number.TrueForAll(x => x == 0))
                b.Number = new List<byte>() { 0 };

            BigInt longNumber = a;
            BigInt shortNumber = b;

            if (a.Number.Count < b.Number.Count)
            {
                shortNumber = a;
                longNumber = b;
            }

            var result = new List<byte>(longNumber.Number);
            sbyte resultSign;
            var lengthDif = longNumber.Number.Count - shortNumber.Number.Count;

            if (a.Sign == b.Sign)
            {
                for (int i = result.Count - 1; i >= lengthDif; i--)
                {
                    result[i] += shortNumber.Number[i - lengthDif];

                    if (result[i] > 9)
                    {
                        result[i] -= 10;

                        for (int j = i; j > 0; j--)
                        {
                            if (result[j - 1] == 9)
                                result[j - 1] = 0;
                            else
                            {
                                result[j - 1]++;
                                break;
                            }
                        }

                        if (result[0] == 0 || i == 0)
                        {
                            result.Insert(0, 1);
                            lengthDif++;
                            i++;
                        }
                    }
                }

                if (result.Count > 1 && result[0] == 0)
                    result.Insert(0, 1);

                resultSign = a.Sign;
            }
            else
            {
                for (int i = result.Count - 1; i >= lengthDif; i--)
                {
                    if (i == 0 && result[i] == 0)
                        break;

                    if (result[i] < shortNumber.Number[i - lengthDif])
                    {
                        result[i] += 10;

                        for (int j = i; j > 0; j--)
                        {
                            if (result[j - 1] == 0)
                                result[j - 1] = 9;
                            else
                            {
                                result[j - 1]--;
                                break;
                            }
                        }
                    }

                    result[i] -= shortNumber.Number[i - lengthDif];
                }

                while (result.Count > 1 && result[0] == 0)
                    result.RemoveAt(0);

                if (result[0] == 0)
                    resultSign = 1;
                else
                    resultSign = new BigInt(1, a.Number)
                        > new BigInt(1, b.Number) ? a.Sign : b.Sign;
            }

            return new BigInt(resultSign, result);
        }

        public static BigInt operator -(BigInt a, BigInt b)
            => a + new BigInt((sbyte)(b.Sign * -1), b.Number);

        public static BigInt operator *(BigInt a, BigInt b)
        {
            var result = new BigInt("0");

            var firstNumber = new List<byte>(a.Number);
            var secondNumber = new List<byte>(b.Number);

            firstNumber.Reverse();
            secondNumber.Reverse();

            var products = new List<BigInt>();
            int remainder;

            foreach (var lowerDigit in secondNumber)
            {
                var product = new List<byte>();
                remainder = 0;

                foreach (var upperDigit in firstNumber)
                {
                    var digitsProduct = upperDigit * lowerDigit + remainder;

                    if (digitsProduct.ToString().Length == 2)
                    {
                        remainder = digitsProduct / 10;
                        digitsProduct %= 10;
                    }
                    else
                        remainder = 0;

                    product.Insert(0, (byte)digitsProduct);
                }

                if (remainder > 0)
                    product.Insert(0, (byte)remainder);

                for (int i = 0; i < products.Count; i++)
                    product.Add(0);

                products.Add(new BigInt(1, product));
            }

            foreach (var product in products)
                result += product;

            if (a.Sign != b.Sign) result.Sign = -1;

            return result;
        }

        public static BigInt operator /(BigInt divisible, BigInt divisor)
        {
            if (divisor.Number[0] == 0)
                throw new Exception("На ноль делить нельзя");

            var divisorModule = new BigInt(1, divisor.Number);
            var i = 0;
            var resultNumb = new List<byte>();
            var incompleteDivisible = new BigInt(1, new List<byte>(0));

            while (i != divisible.Number.Count)
            {
                for (; i < divisible.Number.Count; i++)
                {
                    if (incompleteDivisible >= divisorModule)
                        break;

                    incompleteDivisible.Number.Add(divisible.Number[i]);
                }

                if (incompleteDivisible.Number.TrueForAll(x => x == 0))
                {
                    for (int j = 0; j < incompleteDivisible.Number.Count - 1; j++)
                        resultNumb.Add(0);
                    break;
                }

                for (int j = 0; j < 10; j++)
                {
                    if (incompleteDivisible < divisorModule)
                    {
                        resultNumb.Add((byte)j);
                        break;
                    }

                    incompleteDivisible -= divisorModule;
                }
            }

            if (resultNumb.Count == 0)
                resultNumb.Add(0);

            return new BigInt((sbyte)(divisible.Sign != divisor.Sign ? -1 : 1), resultNumb);
        }

        public static BigInt operator %(BigInt divisible, BigInt divisor)
        {
            if (divisor.Number[0] == 0)
                throw new Exception("На ноль делить нельзя");

            var i = 0;
            var incompleteDivisible = new BigInt(1, new List<byte>(0));

            while (i != divisible.Number.Count)
            {
                for (; i < divisible.Number.Count; i++)
                {
                    if (incompleteDivisible > divisor)
                        break;

                    incompleteDivisible.Number.Add(divisible.Number[i]);
                }

                if (incompleteDivisible.Number.TrueForAll(x => x == 0))
                {
                    incompleteDivisible = new BigInt("0");
                    break;
                }

                while (incompleteDivisible >= divisor)
                    incompleteDivisible -= divisor;
            }

            return incompleteDivisible;
        }

        public static BigInt operator ^(BigInt value, long exponent)
        {
            string binaryExponent = Convert.ToString(exponent, 2);
            var rusult = new BigInt("1");

            for (int i = 0; i < binaryExponent.Length; i++)
            {
                if (i == binaryExponent.Length - 1 && binaryExponent[i] == '0')
                    break;

                if (binaryExponent[i] == '1')
                {
                    var a = rusult * value;
                    rusult = a * a;
                }
                else
                    rusult = rusult * rusult;
            }

            return rusult;
        }

        public override string ToString()
        {
            var result = Sign == 1 ? "" : "-";
            foreach (var digit in Number)
                result += digit;
            return result;
        }
    }
}


