using System;
using Codes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsCodes
{
    [TestClass]
    public class StockBrokerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var l = "GOOG 300 542.0 B, AAPL 50 145.0 B, CSCO 250.0 29 B, GOOG 200 580.0 S";
            var r = "Buy: 169850 Sell: 116000; Badly formed 1: CSCO 250.0 29 B ;";
            Assert.AreEqual(r, StockBroker.balanceStatements(l));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var l = "ZNGA 1300 2.66 B, CLH15.NYM 50 56.32 B, OWW 1000 11.623 B, OGG 20 580.1 B";
            var r = "Buy: 169850 Sell: 116000; Badly formed 1: CSCO 250.0 29 B ;";
            Assert.AreEqual(r, StockBroker.balanceStatements(l));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var l = "ZNGA 1300 2.66 B,CLH15.NYM 50 56.32 B,OWW 1000 11.623 B,OGG 20 580.1 B";
            var r = "Buy: 169850 Sell: 116000; Badly formed 1: CSCO 250.0 29 B ;";
            Assert.AreEqual(r, StockBroker.balanceStatements(l));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var l = "CLH16.NYM 50 56 S ;OWW 1000 11 S";
            var r = "Buy: 169850 Sell: 116000; Badly formed 1: CSCO 250.0 29 B ;";
            Assert.AreEqual(r, StockBroker.balanceStatements(l));
        }
    }
}
