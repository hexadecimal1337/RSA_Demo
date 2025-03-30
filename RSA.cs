using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSA {
    public class RSA {
        private RSA() { }

        public static bool isPrime(BigInteger num) {
            if (num == 2)
                return true;
            
            for (int i = 0; i < 100; i++) {
                BigInteger a = (generateRandomNum() % (num - 2)) + 2;
                if (BigInteger.GreatestCommonDivisor(a,num) != 1)
                    return false;
                if (BigInteger.ModPow(a, num - 1, num) != 1)
                    return false;
            }
            return true;
        }

        public static BigInteger generateRandomNum() {
            Random random = new Random();
            byte[] num128 = new byte[16];
            random.NextBytes(num128);
            num128[0] |= 0x80;
            BigInteger bigInteger = new BigInteger(num128, true, true);
            return bigInteger;
        }

        public static BigInteger generatePrimeNum() {
            BigInteger result = generateRandomNum();
            while(!isPrime(result)) {
                result++;
            }
            return result;
        }

        public static BigInteger generateE(BigInteger f) {
            BigInteger result = 0;
            do {
                result = generatePrimeNum() % f;
                if (result <= 1)
                    result++;
            } while (BigInteger.GreatestCommonDivisor(result, f) != 1);
            return result;
        }

        public static BigInteger generateD(BigInteger e, BigInteger f) {
            BigInteger t = 0, newt = 1;
            BigInteger r = f, newr = e;
            while (newr != 0) {
                BigInteger quotient = r / newr;
                (t, newt) = (newt, t - quotient * newt);
                (r, newr) = (newr, r - quotient * newr);
            }
            if (r > 1)
                throw new Exception("Число a не является обратимым");
            if (t < 0)
                t += f;
            return t;
        }

        public static BigInteger encryptMes(string str, BigInteger e, BigInteger N) {
            char[] strMas = str.ToCharArray();
            BigInteger rawStr = new BigInteger(System.Text.Encoding.UTF8.GetBytes(strMas),true);
            BigInteger result = BigInteger.ModPow(rawStr, e, N);
            return result;
        }

        public static BigInteger encryptMes(BigInteger mes, BigInteger e, BigInteger N) {
            BigInteger result = BigInteger.ModPow(mes, e, N);
            return result;
        }

        public static string decryptMes(string rawText, BigInteger d, BigInteger N) {
            BigInteger encrypted = BigInteger.Parse(rawText);
            BigInteger result = BigInteger.ModPow(encrypted, d, N);
            string str = System.Text.Encoding.UTF8.GetString(result.ToByteArray());
            return str;
        }

        public static string decryptMes(BigInteger rawMes, BigInteger d, BigInteger N) {
            BigInteger result = BigInteger.ModPow(rawMes, d, N);
            string str = result.ToString();
            return str;
        }

        public static bool hackKey(BigInteger N, out BigInteger p, out BigInteger q) {
            for (BigInteger i = 2;i < N; ++i) {
                if(N % i == 0) {
                    p = i;
                    q = N / p;
                    return true;
                }
            }
            p = 0;
            q = 0;
            return false;
        }
    }
}
