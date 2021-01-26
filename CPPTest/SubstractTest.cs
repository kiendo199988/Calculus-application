using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;

namespace CPPTest
{
    /// <summary>
    /// Summary description for SubstractTest
    /// </summary>
    [TestClass]
    public class SubstractTest
    {
        public SubstractTest()
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
            Substract s = new Substract(new Power(new Variable(),new NaturalNumber(2)),new Multiply(new RealNumber(2), new Variable()));
            if(s.GetDerivative().GetInfixFormula() == "(((2*1)*(x^(1)))-((0*x)+(1*2)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetNewton()
        {
            bool result = false;
            Substract s = new Substract(new Power( new Variable(), new NaturalNumber(2)), new Multiply(new RealNumber(2), new Variable()));
            if (s.GetNewton(0.1).GetInfixFormula() == "(((x+0.1)^(2))-(2*(x+0.1)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify()
        {
            bool result = false;
            Substract s = new Substract(new Variable(), new RealNumber(0));
            if (s.Simplify().GetInfixFormula() == "x")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify2()
        {
            bool result = false;
            Substract s = new Substract(new Logarithm(new RealNumber(6)), new Logarithm(new RealNumber(2)));
            if (s.Simplify() is Logarithm && s.Simplify().GetInfixFormula()=="(ln(3))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
