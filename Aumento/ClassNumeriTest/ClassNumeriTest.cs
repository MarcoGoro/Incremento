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
        [DataRow(100, 110)]
        [DataRow(18888, 20776.8)]
        [DataRow(3, 3)]
        [DataRow(0, 0)]
        [DataRow(-72, -72)]
        public void TestIncrementaPari(double a, double ris)
        {
            double newnumber = ClassNumeri.IncrementaPari(a);
            Assert.AreEqual(ris, newnumber);
        }
    }
    }
}
