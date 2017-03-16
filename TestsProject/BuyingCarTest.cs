using Codes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsCodes
{
    /// <summary>
    /// Summary description for BuyingCarTest
    /// </summary>
    [TestClass]
    public class BuyingCarTest
    {

        private int startPriceOld, startPriceNew, savingperMonth;
        private double percentLossByMonth;
       

        public BuyingCarTest()
        {
           
        }

        private TestContext testContextInstance;

       
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
            
        //}
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            startPriceOld = 2000;
            startPriceNew = 8000;
            savingperMonth = 1000;
            percentLossByMonth = 1.5;

            int[] r = new int[] { 6, 766 };
            CollectionAssert.AreEqual(r, BuyingCar.nbMonths(startPriceOld, startPriceNew, savingperMonth, percentLossByMonth));
        }

        [TestMethod]
        public void TestMethod2()
        {
            startPriceOld = 12000;
            startPriceNew = 8000;
            savingperMonth = 1000;
            percentLossByMonth = 1.5;

            int[] r = new int[] { 0, 4000 };
            CollectionAssert.AreEqual(r, BuyingCar.nbMonths(startPriceOld, startPriceNew, savingperMonth, percentLossByMonth));
        }
    }
}
