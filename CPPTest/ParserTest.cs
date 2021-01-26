using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP_App;
using System.Linq;
using CPP_App.Nodes;

namespace CPPTest
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void BuildBinaryTree()
        {
            bool result = false;
            Parser p = new Parser("+(/(1,x),/(2,-(l(-(x,8)),r(3.5)))");
            AbstractNode root = p.BuildBinaryTree(p.GetFormula().ToList<char>());
            if(root is Add && root.GetLeftChild() is Divide && root.GetRightChild() is Divide)
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetListOfCoordinatesTest()
        {
            bool result = false;
            Parser p = new Parser("1,3;4,6;0,7;");
            string s = "";
            foreach(NPolyCoordinate c in p.GetListOfCoordinates(p.GetFormula().ToList<char>()))
            {
                s += c.X() + "," + c.Y()+"/";
            }
            if(s == "1,3/4,6/0,7/")
            {
                result = true;
            }
            Assert.IsTrue(result);
        }
    }
}
