using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZadaniaTesty
{
    class PiratesTest
    {
        public static class Pirates
        {

            public static string CannonsReady(Dictionary<string, string> gunners)
            {

                List<string> e = gunners.Values.ToList();
                int k = 0;
                for (int i = 0; i < e.Count; i++)
                {
                    if(e[i].ToString()== "aye")
                    {
                        k++;
                    }
                    
                }
                if (k == 4)
                {
                    return "Fire!";
                }


                return "Shiver me timbers!";

            }
        }

        //SampleTests
        [TestFixture]
        public class SolutionTest
        {
            [Test, Description("should fire the cannons when ready")]
            public void SampleAyeTest()
            {
                Dictionary<string, string> gunners = new Dictionary<string, string>
    {
      {"Mike", "aye"},
      {"Joe", "aye"},
      {"Johnson", "aye"},
      {"Peter", "aye"}
    };

                Assert.AreEqual("Fire!", Pirates.CannonsReady(gunners));
            }

            [Test, Description("should shiver me timbers if not ready")]
            public void SampleNayTest()
            {
                Dictionary<string, string> gunners = new Dictionary<string, string>
    {
      {"Mike", "aye"},
      {"Joe", "nay"},
      {"Johnson", "aye"},
      {"Peter", "aye"}
    };

                Assert.AreEqual("Shiver me timbers!", Pirates.CannonsReady(gunners));
            }
        }
    }
}
