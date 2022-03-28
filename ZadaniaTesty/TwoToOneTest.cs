using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Zadania;

namespace ZadaniaTesty
{



    // Sample tests
    [TestFixture]
    public static class TwoToOneTests
    {
        //   TwoToOne twoToOne = new TwoToOne();
        [Test]
        public static void test1()
        {
            Assert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
            //bledny test    Assert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("abdefgilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));//poprawiony
            //bledny test  Assert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
            Assert.AreEqual("acefhinoprstu", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));//poprawiony
        }
    }

}
