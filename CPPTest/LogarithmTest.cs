using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;

namespace CPPTest
{
    /// <summary>
    /// Summary description for LogarithmTest
    /// </summary>
    [TestClass]
    public class LogarithmTest
    {
        public LogarithmTest()
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
            Logarithm logarithm = new Logarithm(new Add(new Power(new Variable(),new NaturalNumber(2)),new Variable()));
            if(logarithm.GetDerivative() is Divide && logarithm.GetDerivative().GetInfixFormula()== "((((2*1)*(x^(1)))+1)/((x^(2))+x))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify()
        {
            bool result = false;
            Logarithm logarithm = new Logarithm(new RealNumber(1));
            if (logarithm.Simplify() is NaturalNumber && logarithm.GetValue(0)==0)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify2()
        {
            bool result = false;
            Logarithm logarithm = new Logarithm(new Exponential(new Add(new Variable(),new RealNumber(3))));
            if (logarithm.Simplify() is Add && logarithm.Simplify().GetInfixFormula() == "(x+3)")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify3()
        {
            bool result = false;
            Logarithm logarithm = new Logarithm(new Power(new Variable(),new NaturalNumber(2)));
            if (logarithm.Simplify() is Multiply && logarithm.Simplify().GetInfixFormula() == "(2*(ln(x)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetPrefixString()
        {
            bool result = false;
            Logarithm logarithm = new Logarithm(new Variable());
            if (logarithm.ToPrefixString() == "ln")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
