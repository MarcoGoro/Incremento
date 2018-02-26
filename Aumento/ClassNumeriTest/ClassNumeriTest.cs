using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassNumeriTest;


namespace ClassNumeriTest
{
    [TestClass]
    public class ClassNumeriTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        [DataTestMethod]
        [DataRow(90, 99)]
        [DataRow(20, 22)]
        [DataRow(10, 1)]
        [DataRow(0, 0)]
        [DataRow(12, 13.2)]
        public void TestIncrementaPari(double a, double ris)
        {
            double newnumber = ClassNumeri.IncrementaPari(a);
            Assert.AreEqual(ris, newnumber);
        }
    }
    }
}
