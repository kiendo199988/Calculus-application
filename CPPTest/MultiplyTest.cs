using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;

namespace CPPTest
{
    /// <summary>
    /// Summary description for Multiply
    /// </summary>
    [TestClass]
    public class MultiplyTest
    {
        public MultiplyTest()
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
            Multiply multiply = new Multiply(new Add(new Power(new Variable(),new RealNumber(2)),new Variable()), new Add(new Power( new Variable(), new NaturalNumber(3)), new Multiply(new RealNumber(3),new Variable())));
            if(multiply.GetDerivative().GetInfixFormula() == "(((((2*1)*(x^(1)))+1)*((x^(3))+(3*x)))+((((3*1)*(x^(2)))+((0*x)+(1*3)))*((x^(2))+x)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify()
        {
            bool result = false;
            Multiply multiply = new Multiply(new RealNumber(0),new Variable());
            if (multiply.Simplify() is NaturalNumber && multiply.Simplify().GetValue(0)==0)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify2()
        {
            bool result = false;
            Multiply multiply = new Multiply(new RealNumber(1), new Variable());
            if (multiply.Simplify() is Variable)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify3()
        {
            bool result = false;
            Multiply multiply = new Multiply(new RealNumber(3.2), new NaturalNumber(2));
            if (multiply.Simplify() is RealNumber && multiply.Simplify().GetValue(0) == 6.4)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify4()
        {
            bool result = false;
            Multiply multiply = new Multiply(new Exponential(new Variable()), new Exponential(new RealNumber(3.5)));
            if (multiply.Simplify() is Exponential && multiply.Simplify().GetInfixFormula() == "(e^((x+3.5)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
