using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;

namespace CPPTest
{
    /// <summary>
    /// Summary description for AddTest
    /// </summary>
    [TestClass]
    public class AddTest
    {
        public AddTest()
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
            Add add = new Add(new RealNumber(0), new Variable());
            if(add.Simplify().GetInfixFormula() == "x")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify1()
        {
            bool result = false;
            Add add = new Add(new RealNumber(1), new RealNumber(3.5));
            if (add.Simplify() is RealNumber&&add.Simplify().GetInfixFormula()=="4.5")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify2()
        {
            bool result = false;
            Add add = new Add(new Logarithm(new Variable()), new Logarithm(new RealNumber(3.5)));
            if (add.Simplify() is Logarithm && add.Simplify().GetInfixFormula()== "(ln((x*3.5)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify3()
        {
            bool result = false;
            Add add = new Add(new Variable(), new Add(new RealNumber(3.5),new RealNumber(0.5)));
            if (add.Simplify() is Add && add.Simplify().GetInfixFormula() == "(x+4)")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToPrefixString()
        {
            bool result = false;
            Add add = new Add(new RealNumber(3), new Variable());
            if (add.ToPrefixString() == "+")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
