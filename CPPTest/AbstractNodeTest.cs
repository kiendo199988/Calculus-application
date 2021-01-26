using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App;
using System.Linq;

namespace CPPTest
{
    /// <summary>
    /// Summary description for AbstractNodeTest
    /// </summary>
    [TestClass]
    public class AbstractNodeTest
    {
        public AbstractNodeTest()
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
        public void CheckDomain()
        {
            bool result = false;
            Parser p1 = new Parser("+(x,/(-(3,x),x))");
            Function f1 = new Function(p1.BuildBinaryTree(p1.GetFormula().ToList<char>()));
            if (f1.GetRootNode().CheckDomain(0) == false)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckDomain2()
        {
            bool result = false;
            Parser p1 = new Parser("l(x)");
            Function f1 = new Function(p1.BuildBinaryTree(p1.GetFormula().ToList<char>()));
            if (f1.GetRootNode().CheckDomain(-3) == false)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckDomain3()
        {
            bool result = false;
            Parser p1 = new Parser("^(x,n(-2))");
            Function f1 = new Function(p1.BuildBinaryTree(p1.GetFormula().ToList<char>()));
            if (f1.GetRootNode().CheckDomain(0) == false && f1.GetRootNode().CheckDomain(3) == true)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckDomain4()
        {
            bool result = false;
            Parser p1 = new Parser("+(^(x,n(-2)),3)");
            Function f1 = new Function(p1.BuildBinaryTree(p1.GetFormula().ToList<char>()));
            if (f1.GetRootNode().CheckDomain(0) == false && f1.GetRootNode().CheckDomain(3) == true)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

      
    }
}
