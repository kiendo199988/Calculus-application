using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;

namespace CPPTest
{
    /// <summary>
    /// Summary description for SineTest
    /// </summary>
    [TestClass]
    public class SineTest
    {
        public SineTest()
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
            bool b = false;
            Sine s = new Sine(new Power(new Variable(), new NaturalNumber(2)));
            if(s.GetDerivative().GetInfixFormula()== "((cos((x^(2))))*((2*1)*(x^(1))))")
            {
                b = true;
            }
            Assert.IsTrue(b);
        }

        [TestMethod]
        public void Simplify()
        {
            bool b = false;
            Sine s = new Sine(new RealNumber(0));
            if (s.Simplify().GetValue(0) == 0)
            {
                b = true;
            }
            Assert.IsTrue(b);
        }

    }
}
