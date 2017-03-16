using Codes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsCodes
{
    [TestClass]
    public class NextBiggerNumberTest
    {
        [TestMethod]
        public void ValidTesteOne()
        {
            Assert.AreEqual(-1, NextBiggerNumberKata.NextBiggerNumber(111));
            Assert.AreEqual(-1, NextBiggerNumberKata.NextBiggerNumber(9));
            Assert.AreEqual(-1, NextBiggerNumberKata.NextBiggerNumber(531));
            Assert.AreEqual(21, NextBiggerNumberKata.NextBiggerNumber(12));
            Assert.AreEqual(531, NextBiggerNumberKata.NextBiggerNumber(513));
            Assert.AreEqual(2071, NextBiggerNumberKata.NextBiggerNumber(2017));
            Assert.AreEqual(441, NextBiggerNumberKata.NextBiggerNumber(414));
            Assert.AreEqual(414, NextBiggerNumberKata.NextBiggerNumber(144));
        }
    }
}
