using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App;
using System.Linq;
using CPP_App.Nodes;

namespace CPPTest
{
    [TestClass]
    public class FunctionTest
    {
        [TestMethod]
        public void GetValue()
        {
            bool result = false;
            Parser p1 = new Parser("+(x,/(-(3,x),2))");
            Function f1 = new Function(p1.BuildBinaryTree(p1.GetFormula().ToList<char>()));
            Parser p2 = new Parser("+(r(0.7),x)");
            Function f2 = new Function(p2.BuildBinaryTree(p2.GetFormula().ToList<char>()));
            Parser p3 = new Parser("*(x,4)");
            Function f3 = new Function(p3.BuildBinaryTree(p3.GetFormula().ToList<char>()));
            Parser p4 = new Parser("^(+(x,n(10)),2)");
            Function f4 = new Function(p4.BuildBinaryTree(p4.GetFormula().ToList<char>()));
            Parser p5 = new Parser("s(/(p,2))");
            Function f5 = new Function(p5.BuildBinaryTree(p5.GetFormula().ToList<char>()));
            Parser p6 = new Parser("c(+(x,p))");
            Function f6 = new Function(p6.BuildBinaryTree(p6.GetFormula().ToList<char>()));
            Parser p7 = new Parser("e(/(x,n(8)))");
            Function f7 = new Function(p7.BuildBinaryTree(p7.GetFormula().ToList<char>()));
            Parser p8 = new Parser("l(x)");
            Function f8 = new Function(p8.BuildBinaryTree(p8.GetFormula().ToList<char>()));
            Parser p9 = new Parser("!(n(10))");
            Function f9 = new Function(p9.BuildBinaryTree(p9.GetFormula().ToList<char>()));
            if (f1.GetValue(9) == 6 && f2.GetValue(3) == 3.7 && f3.GetValue(8.43) == 33.72 && f4.GetValue(3) == 169
                && f5.GetValue(3) == 1 && f6.GetValue(0) == -1 &&f8.GetValue(1)==0
                 && f9.GetValue(0) == 3628800)
            { result = true; }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetDerivative()
        {
            bool result = false;
            Parser p1 = new Parser("^(x,2)");
            Function f1 = new Function(p1.BuildBinaryTree(p1.GetFormula().ToList<char>()));
            if (f1.GetDerivative().GetInfixFormula() == "((2*1)*(x^(1)))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify()
        {
            bool result = false;
            Parser p1 = new Parser("^(x,2)");
            Function f1 = new Function(p1.BuildBinaryTree(p1.GetFormula().ToList<char>()));
            if (f1.GetDerivative().Simplify().GetInfixFormula() == "(2*x)")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Simplify2()
        {
            bool result = false;
            Parser p1 = new Parser("+(^(x,2),1)");
            Function f1 = new Function(p1.BuildBinaryTree(p1.GetFormula().ToList<char>()));
            if (f1.GetDerivative().Simplify().GetInfixFormula() == "(2*x)")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetNewtonQotient()
        {
            bool result = false;
            Parser p1 = new Parser("*(c(s(+(x,4))),l(x))");
            Function f1 = new Function(p1.BuildBinaryTree(p1.GetFormula().ToList<char>()));
            if (f1.GetNewtonQuotientFunction(0.1).GetInfixFormula() == "((((cos((sin(((x+0.1)+4)))))*(ln((x+0.1))))-((cos((sin((x+4)))))*(ln(x))))/0.1)")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetRiemannIntegral1()
        {
            bool result = false;
            Function f = new Function(new RealNumber(1));
            if (f.GetRiemannIntegral(730, 745, 715, 15, 1).ToString() == "1")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetRiemannIntegral2()
        {
            bool result = false;
            Function f = new Function(new RealNumber(-1));
            if (f.GetRiemannIntegral(745, 730, 715, 15, 1).ToString() == "-1")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetNthOrderDerivativeTest()
        {
            bool result = false;
            Function f = new Function(new Power(new Variable(), new NaturalNumber(2)));
            if (f.GetNthOrderDerivative(f, 2).GetInfixFormula() == "2")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetMclaurinSeriesAnalyticallyTest()
        {
            bool result = false;
            Function f = new Function(new Sine(new Variable()));
            if (f.GetMclaurinSeriesAnalytically(6).GetInfixFormula() == "((0.00833333333333333*(x^(5)))+(((-0.166666666666667)*(x^(3)))+x))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetMclaurinSeriesByNewtonTest()
        {
            bool result = false;
            Function f = new Function(new Sine(new Variable()));
            if (f.GetMclaurinSeriesByNewton(6).GetInfixFormula() == "(((-4.16133177299432E-05)*(x^(6)))+((0.00833055430193852*(x^(5)))+((0.000833263925451947*(x^(4)))+(((-0.166645833931112)*(x^(3)))+(((-0.00499987500124366)*(x^(2)))+(0.999983333416666*x))))))")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

    }
}
