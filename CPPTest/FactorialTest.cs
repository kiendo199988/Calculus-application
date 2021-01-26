using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;

namespace CPPTest
{
    /// <summary>
    /// Summary description for FactorialTest
    /// </summary>
    [TestClass]
    public class FactorialTest
    {
        public FactorialTest()
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
        public void DeepCopy()
        {
            bool result = false;
            Factorial f = new Factorial(new NaturalNumber(3));
            if(f.DeepCopy() is Factorial && f.DeepCopy().GetLeftChild().GetValue(0) == 3)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetDerivative()
        {
            bool result = false;
            Factorial f = new Factorial(new NaturalNumber(3));
            if (f.GetDerivative() is NaturalNumber && f.GetDerivative().GetValue(0) == 0)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetInfixFormula()
        {
            bool result = false;
            Factorial f = new Factorial(new NaturalNumber(4));
            if (f.GetInfixFormula() == "(4!)")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToPrefixString()
        {
            bool result = false;
            Factorial f = new Factorial(new NaturalNumber(4));
            if (f.ToPrefixString() == "!")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
