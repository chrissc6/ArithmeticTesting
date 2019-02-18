using System;
using ArithmeticTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestArithmetic
{
    [TestClass]
    public class UnitTest1
    {
        //add test

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidAddn80()
        {
            Arithmetic.Add(-80, -80);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidAddn51()
        {
            Arithmetic.Add(-51, -51);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidAddp51()
        {
            Arithmetic.Add(51, 51);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidAddp80()
        {
            Arithmetic.Add(80, 80);
        }

        [TestMethod]
        public void TestValidAdd()
        {
            var actual = Arithmetic.Add(-50, -50);
            Assert.AreEqual(-50 + -50, actual, "n50 fail");
            actual = Arithmetic.Add(-49, -49);
            Assert.AreEqual(-49 + -49, actual, "n49 fail");
            actual = Arithmetic.Add(0, 0);
            Assert.AreEqual(0 + 0, actual, "0 fail");
            actual = Arithmetic.Add(49, 49);
            Assert.AreEqual(49 + 49, actual, "49 fail");
            actual = Arithmetic.Add(50, 50);
            Assert.AreEqual(50 + 50, actual, "50 fail");
        }

        //sub test

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidSubn80()
        {
            Arithmetic.Sub(-80, -80);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidSubn51()
        {
            Arithmetic.Sub(-51, -51);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidSubp51()
        {
            Arithmetic.Sub(51, 51);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidSubp80()
        {
            Arithmetic.Sub(80, 80);
        }



        [TestMethod]
        public void TestValidSub()
        {
            var actual = Arithmetic.Sub(-50, -50);
            Assert.AreEqual(-50 - -50, actual, "n50 fail");
            actual = Arithmetic.Sub(-49, -49);
            Assert.AreEqual(-49 - -49, actual, "n49 fail");
            actual = Arithmetic.Sub(0, 0);
            Assert.AreEqual(0 - 0, actual, "0 fail");
            actual = Arithmetic.Sub(49, 49);
            Assert.AreEqual(49 - 49, actual, "49 fail");
            actual = Arithmetic.Sub(50, 50);
            Assert.AreEqual(50 - 50, actual, "50 fail");
        }

        //mul test

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidMuln80()
        {
            Arithmetic.Mul(-80, -80);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidMuln51()
        {
            Arithmetic.Mul(-51, -51);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidMulp51()
        {
            Arithmetic.Mul(51, 51);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMInvalidMulp80()
        {
            Arithmetic.Mul(80, 80);
        }



        [TestMethod]
        public void TestValidMul()
        {
            var actual = Arithmetic.Mul(-50, -50);
            Assert.AreEqual(-50 * -50, actual, "n50 fail");
            actual = Arithmetic.Mul(-49, -49);
            Assert.AreEqual(-49 * -49, actual, "n49 fail");
            actual = Arithmetic.Mul(0, 0);
            Assert.AreEqual(0 * 0, actual, "0 fail");
            actual = Arithmetic.Mul(49, 49);
            Assert.AreEqual(49 * 49, actual, "49 fail");
            actual = Arithmetic.Mul(50, 50);
            Assert.AreEqual(50 * 50, actual, "50 fail");
        }


        //div

        //MOVED TO OTHER BLOCK WITH TRY CATCH

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void TestMInvalidDivn80()
        //{
        //    Arithmetic.Div(-80, -80);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void TestMInvalidDivn51()
        //{
        //    Arithmetic.Div(-51, -51);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void TestMInvalidDivp51()
        //{
        //    Arithmetic.Div(51, 51);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void TestMInvalidDivp80()
        //{
        //    Arithmetic.Div(80, 80);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void TestMInvalidDiv0()
        //{
        //    Arithmetic.Div(1, 0);
        //}



        [TestMethod]
        public void TestValidDiv()
        {
            var actual = Arithmetic.Div(-50, -50);
            Assert.AreEqual(-50 / -50, actual, "n50 fail");
            actual = Arithmetic.Div(-49, -49);
            Assert.AreEqual(-49 / -49, actual, "n49 fail");
            actual = Arithmetic.Div(1, 1);
            Assert.AreEqual(1 / 1, actual, "1 fail");
            actual = Arithmetic.Div(49, 49);
            Assert.AreEqual(49 / 49, actual, "49 fail");
            actual = Arithmetic.Div(50, 50);
            Assert.AreEqual(50 / 50, actual, "50 fail");
            try
            {
                Arithmetic.Div(1, 0);
                Assert.Fail();
            }
            catch (Exception) { }
            try
            {
                Arithmetic.Div(80, 80);
                Assert.Fail();
            }
            catch (Exception) { }
            try
            {
                Arithmetic.Div(51, 51);
                Assert.Fail();
            }
            catch (Exception) { }
            try
            {
                Arithmetic.Div(-51, -51);
                Assert.Fail();
            }
            catch (Exception) { }
            try
            {
                Arithmetic.Div(-80, -80);
                Assert.Fail();
            }
            catch (Exception) { }
        }
    }
}
