using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;

namespace CPPTest
{
    /// <summary>
    /// Summary description for PowerTest
    /// </summary>
    [TestClass]
    public class PowerTest
    {
        public PowerTest()
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
        public void Simplify()
        {
            bool result = false;
            Power p = new Power(new Variable(), new NaturalNumber(0));
            if(p.Simplify() is NaturalNumber && p.Simplify().GetInfixFormula() == "1")
            {
                result = true;
            }
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void Simplify2()
        {
            bool result = false;
            Power p = new Power(new RealNumber(-3), new NaturalNumber(2));
            if (p.Simplify() is RealNumber && p.Simplify().GetInfixFormula() == "9")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify3()
        {
            bool result = false;
            Power p = new Power(new Exponential(new RealNumber(2)), new Variable());
            if (p.Simplify() is Exponential && p.Simplify().GetInfixFormula() == "(e^((2*x)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
