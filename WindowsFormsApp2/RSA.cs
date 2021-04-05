using System;
using System.Collections.Generic;
using System.Numerics;

namespace AlgorithmsLab1
{
    public class RSA
    {
        private static string engAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string ruAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private static string symbols = " .,!@#$%^&*(){}:;<>?\\|/";
        private static string numbers = "1234567890";

        public static readonly char[] Characters = (engAlphabet + engAlphabet.ToLower()
        + ruAlphabet + ruAlphabet.ToLower() + symbols + numbers + Environment.NewLine).ToCharArray();

        public static bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static List<string> Encode(string text, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger E;

            for (int i = 0; i < text.Length; i++)
            {
                int index = Array.IndexOf(Characters, text[i]);

                E = new BigInteger(index);
                E = BigInteger.Pow(E, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                E = E % n_;

                result.Add(E.ToString());
            }

            return result;
        }

        public static string Decode(List<string> encryptedText, long d, long n)
        {
            string result = "";

            BigInteger E;

            foreach (string item in encryptedText)
            {
                E = new BigInteger(Convert.ToDouble(item));
                E = BigInteger.Pow(E, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                E = E % n_;

                int index = Convert.ToInt32(E.ToString());

                result += Characters[index].ToString();
            }

            return result;
        }

        public static long Calculate_e(long fi)
        {
            long d = fi - 1;

            for (long i = 2; i <= fi; i++)
                if (!IsTheNumberSimple(d) || ((fi % i == 0) && (d % i == 0))) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        public static long Calculate_d(long e, long fi)
        { 
            long d = 1;

            while (true)
            {
                if ((d * e) % fi == 1)
                    break;
                else
                    d++;
            }

            return d;
        }
    }
}
