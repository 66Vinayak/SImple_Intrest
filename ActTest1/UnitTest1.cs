using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ActTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //expected
            int y = 5;
            double p = 100;
            double r = 1;
            double expec1 = 500;
            double expec2 = 5000;

            //act
           double act1= SImple_Intrest.CalculateSI.CalCulate(p, y, r);
           // double act2 = SImple_Intrest.CalculateSI.CalCulate(p, y, r);
            Assert.AreEqual(expec1, act1);
            //Assert.AreEqual(expec2, act2);

        }
    }
}
