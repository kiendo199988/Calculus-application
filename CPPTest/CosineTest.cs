using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;

namespace CPPTest
{
    /// <summary>
    /// Summary description for CosineTest
    /// </summary>
    [TestClass]
    public class CosineTest
    {
        public CosineTest()
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
        public void GetDerivative1()
        {
            bool result = false;
            Cosine cos = new Cosine(new Variable());
            if (cos.GetDerivative() is Substract && cos.GetDerivative().Simplify().GetInfixFormula() == "(0-(sin(x)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify1()
        {
            bool result = false;
            Cosine cos = new Cosine(new Substract(new RealNumber(3),new RealNumber(3)));
            if (cos.Simplify() is NaturalNumber && cos.Simplify().GetInfixFormula() == "1")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify2()
        {
            bool result = false;
            Cosine cos = new Cosine(new Pi());
            if (cos.Simplify() is RealNumber && cos.Simplify().GetInfixFormula() == "(-1)")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify3()
        {
            bool result = false;
            Cosine cos = new Cosine(new Add(new RealNumber(3), new RealNumber(4)));
            if (cos.Simplify() is Cosine && cos.Simplify().GetInfixFormula() == "(cos(7))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToPrefixString()
        {
            bool result = false;
            Cosine cos = new Cosine(new Substract(new RealNumber(3), new RealNumber(3)));
            if (cos.ToPrefixString()=="cos")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

    }
}
