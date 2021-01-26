using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App;
using System.Linq;

namespace CPPTest
{
    /// <summary>
    /// Summary description for MatrixTest
    /// </summary>
    [TestClass]
    public class MatrixTest
    {
        public MatrixTest()
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
        public void TestMethod1()
        {
            bool result = false;
            Parser p = new Parser("1,3;4,6;0,7;");
            Matrix m = new Matrix(p.GetListOfCoordinates(p.GetFormula().ToList<char>()));
            NPolynomialGenerator generator = new NPolynomialGenerator(m);
            if(generator.GetNPolyFunction().GetInfixFormula() == "((7*(x^(0)))+(((-5.25)*(x^(1)))+(1.25*(x^(2)))))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
