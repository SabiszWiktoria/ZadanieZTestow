using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZadaniaTesty
{
    class BitwaZnakowTest
    {
        public class Kata
        {
            public static string Battle(string x, string y)
            {
                Dictionary<char, int> sign = new Dictionary<char, int>();
                sign.Add('A', 1); 
                sign.Add('B', 2);
                sign.Add('C', 3); 
                sign.Add('D', 4);
                sign.Add('E', 5); 
                sign.Add('F', 6);
                sign.Add('G', 7);
                sign.Add('H', 8);
                sign.Add('I', 9);
                sign.Add('J', 10);
                sign.Add('K', 11);
                sign.Add('L', 12);
                sign.Add('M', 13);
                sign.Add('N', 14);
                sign.Add('O', 15);
                sign.Add('P', 16);
                sign.Add('Q', 17);
                sign.Add('R', 18);
                sign.Add('S', 19);
                sign.Add('T', 20);
                sign.Add('U', 21);
                sign.Add('V', 22);
                sign.Add('W', 23);
                sign.Add('X', 24);
                sign.Add('Y', 25);
                sign.Add('Z', 26);

                if (Sum(x, sign) > Sum(y, sign))
                {
                    return x;
                }
                if(Sum(x, sign) < Sum(y, sign))
                {
                    return y;
                }
                // code goes here...
                return "Tie!";
            }
            public static List<char> ReturnListSign(string word)
            {
                int w = word.Length;
                List<char> x = new List<char>();
                for (int i = 0; i < w; i++)
                {
                    x.Add(word[i]);
                }

                return x;
            }
            public static int Sum(string word, Dictionary<char,int> sign)
            {
                int suma = 0;
                List<char> x = ReturnListSign(word);
                for (int i = 0; i < x.Count; i++)
                {
                    suma += sign[x[i]];
                }
                return suma;
            }
        }

        // Sample tests
        [TestFixture]
        public class Test
        {
            [Test]
            public void BasicTests()
            {
                Assert.AreEqual("Z", Kata.Battle("AAA", "Z"));
                Assert.AreEqual("TWO", Kata.Battle("ONE", "TWO"));
                Assert.AreEqual("Tie!", Kata.Battle("ONE", "NEO"));
                Assert.AreEqual("FOUR", Kata.Battle("FOUR", "FIVE"));
            }
        }
    }
}
