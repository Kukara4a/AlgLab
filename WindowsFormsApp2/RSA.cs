using System;
using System.Collections.Generic;
using System.Numerics;

namespace AlgorithmsLab1
{
    public class RSA
    {
        private static char[] characters = new char[] { '#', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
                                                'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с',
                                                'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ',
                                                'э', 'ю', 'я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0', ',', '-', '(', ')', '=', '+', '!', '?', '.' };

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
                int index = Array.IndexOf(characters, text[i]);

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

                result += characters[index].ToString();
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
