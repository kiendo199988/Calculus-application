using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App.Nodes;
using CPP_App;

namespace CPPTest
{
    /// <summary>
    /// Summary description for DivideTest
    /// </summary>
    [TestClass]
    public class DivideTest
    {
        public DivideTest()
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
            Divide divide = new Divide(new Pi(), new RealNumber(9.2));
            if (divide.DeepCopy().GetInfixFormula() == "(pi/9.2)"&& divide.GetLeftChild() is Pi && divide.GetRightChild().GetInfixFormula()=="9.2")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetDerivative()
        {
            bool result = false;
            Divide divide = new Divide(new Add(new Power(new Variable(), new NaturalNumber(2)), new RealNumber(3)), new RealNumber(2));
            if (divide.GetDerivative().GetInfixFormula() == "(((2*(((2*1)*(x^(1)))+0))-(((x^(2))+3)*0))/(2^(2)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetNewton()
        {
            bool result = false;
            Divide div = new Divide(new RealNumber(1), new Variable());
            if (div.GetNewton(0.1) is Divide && div.GetNewton(0.1).GetInfixFormula() == "(1/(x+0.1))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToPreFixString()
        {
            bool result = false;
            Divide div = new Divide(new RealNumber(1), new Variable());
            if (div.ToPrefixString()=="/")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify()
        {
            bool result = false;
            Divide div = new Divide(new Variable(), new RealNumber(1));
            if (div.Simplify() is Variable)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify2()
        {
            bool result2 = false;
            Divide div2 = new Divide(new NaturalNumber(0), new RealNumber(2));
            if (div2.Simplify() is NaturalNumber && div2.GetValue(0) == 0)
            {
                result2 = true;
            }
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void Simplify3()
        {
            bool result2 = false;
            Divide div2 = new Divide(new NaturalNumber(4), new RealNumber(2));
            if (div2.Simplify() is RealNumber && div2.GetValue(0) == 2)
            {
                result2 = true;
            }
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void Simplify4()
        {
            bool result2 = false;
            Divide div2 = new Divide(new Exponential(new Variable()),new Exponential(new RealNumber(2)));
            if (div2.Simplify() is Exponential && div2.Simplify().GetInfixFormula() == "(e^((x-2)))")
            {
                result2 = true;
            }
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void Simplify5()
        {
            bool result2 = false;
            Divide div2 = new Divide(new Add(new RealNumber(0),new Variable()), new Add(new RealNumber(2),new NaturalNumber(2)));
            if (div2.Simplify() is Divide && div2.Simplify().GetInfixFormula() == "(x/4)")
            {
                result2 = true;
            }
            Assert.IsTrue(result2);
        }
    }
}
