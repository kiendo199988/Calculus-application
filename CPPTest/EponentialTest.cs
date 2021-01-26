using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;

namespace CPPTest
{
    /// <summary>
    /// Summary description for EponentialTest
    /// </summary>
    [TestClass]
    public class EponentialTest
    {
        public EponentialTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
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
        public void GetDerivative()
        {
            bool result = false;
            Exponential e = new Exponential(new Power(new Variable(), new NaturalNumber(2)));
            if (e.GetDerivative() is Multiply && e.GetDerivative().GetInfixFormula() == "(((2*1)*(x^(1)))*(e^((x^(2)))))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetNewton()
        {
            bool result = false;
            Exponential e = new Exponential(new Power( new Variable(), new NaturalNumber(2)));
            if (e.GetNewton(0.1).GetInfixFormula() == "(e^(((x+0.1)^(2))))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetValue()
        {
            bool result = false;
            Exponential e = new Exponential(new Power(new Variable(), new NaturalNumber(2)));
            if (e.GetValue(4) == Math.Exp(16))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetValue2()
        {
            bool result = false;
            Exponential e = new Exponential(new Power(new Variable(), new NaturalNumber(2)));
            if (e.GetValue(1) == Math.Pow(Math.E,1))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify()
        {
            bool result = false;
            Exponential e = new Exponential(new RealNumber(0));
            if (e.Simplify() is NaturalNumber && e.Simplify().GetValue(0) == 1)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify2()
        {
            bool result = false;
            Exponential e = new Exponential(new Logarithm(new Add(new Variable(),new RealNumber(0))));
            if (e.Simplify() is Variable && e.Simplify().GetInfixFormula()=="x")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToPrefixString()
        {
            bool result = false;
            Exponential e = new Exponential(new Variable());
            if (e.ToPrefixString() == "e^")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
