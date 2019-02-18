using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticTesting;

namespace TestArithmetic
{
    [TestClass] //attributes (modifers: right before a class or a method) "says this class is for running test"
    public class TestSqr
    {
        [TestMethod] //attributes "to be run to run test cases"
        [ExpectedException(typeof(Exception))] //wants to expect an error
        public void TestMInvalidMinus127()
        {
            Arithmetic.Sqr(-127);
        }

        [TestMethod]
        public void TestValid10()
        {
            var actual = Arithmetic.Sqr(10);
            Assert.AreEqual(100, actual, "sqr(10) is not 100"); //if equal test passes
            actual = Arithmetic.Sqr(11);
            Assert.AreEqual(121, actual, "sqr(11) is not 121");
            actual = Arithmetic.Sqr(53);
            Assert.AreEqual(2809, actual, "sqr(53) is not 2809");
            actual = Arithmetic.Sqr(99);
            Assert.AreEqual(9801, actual, "sqr(99) is not 9801");
            Assert.AreEqual(10000, Arithmetic.Sqr(100), "sqr(100) is not 10000");
        }

        //[TestMethod]
        //public void TestAlwaysFails()
        //{
        //    Assert.Fail(); //used to force fail
        //}
    }
}
