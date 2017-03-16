using System;
using Codes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsCodes
{
    [TestClass]
    public class MissingArrayTest
    {
        [TestMethod]
        public void ValidTestOne()
        {
            Assert.AreEqual(3, MissingArray.GetLengthOfMissingArray(new object[][] { new object[] { 1, 2 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }));
            Assert.AreEqual(2, MissingArray.GetLengthOfMissingArray(new object[][] { new object[] { 5, 2, 9 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }));
            Assert.AreEqual(2, MissingArray.GetLengthOfMissingArray(new object[][] { new object[] { null }, new object[] { null, null, null } }));
            Assert.AreEqual(5, MissingArray.GetLengthOfMissingArray(new object[][] { new object[] { 'a', 'a', 'a' }, new object[] { 'a', 'a' }, new object[] { 'a', 'a', 'a', 'a' }, new object[] { 'a' }, new object[] { 'a', 'a', 'a', 'a', 'a', 'a' } }));
            Assert.AreEqual(0, MissingArray.GetLengthOfMissingArray(new object[][] { }));
            Assert.AreEqual(6, MissingArray.GetLengthOfMissingArray(new object[][]
            {
                new object[] {4, 0, 2, 1, 1, 3, 2},
                new object[] {3, 0, 3, 4, 4, 2, 1, 1, 4}, new object[] {3, 2, 0, 4},
                new object[] {2, 1, 4, 2, 4, 0, 2, 4, 3, 3}, new object[] {0, 2, 2, 1, 2, 3, 2, 0, 4, 3, 0},
                new object[] {3, 3, 0, 4, 4, 4, 1, 3, 3, 4, 0, 3, 1},
                new object[] {0, 4, 0, 0, 1, 2, 2, 3, 3, 0, 1, 0, 0, 3},
                new object[] {3, 2, 3, 4, 4},
                new object[] {3, 2, 1, 3, 3, 4, 3, 3},
                new object[] {2, 4, 3, 1, 0, 2, 3, 4, 0, 2, 2, 4}
            }));

            Assert.AreEqual(0, MissingArray.GetLengthOfMissingArray(new object[][]
            {
                new object[] {4},
                new object[] {4, 0, 1, 1, 2, 4, 1, 4}, new object[] {2, 4, 2, 2, 3, 2, 3, 0, 4},
                new object[] {}, new object[] {1, 0, 2},
                new object[] {4, 1, 4, 3, 2, 1},
                new object[] {0, 0, 2, 2, 2, 2, 2},
                new object[] {4, 4},
                new object[] {3, 4, 2, 4},
                new object[] { 3, 3, 4, 3, 1, 4, 0, 1, 1, 0 }
            }));



        }
    }
}
