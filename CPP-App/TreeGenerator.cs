using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CPP_App.Nodes;
using System.Diagnostics;

namespace CPP_App
{
    public class TreeGenerator
    {
        private Function function;

        public TreeGenerator(Function f)
        {
            this.function = f;
        }

        //generate tree for original function
        public void GenerateTreeImage()
        {
            GenerateTextFile();
            Process dot = new Process();

            dot.StartInfo.FileName = @"dot.exe";
            dot.StartInfo.Arguments = "-Tpng -obinarytree.png graph.dot";
            dot.Start();
            dot.WaitForExit();
        }

        //generate a text that helps to build a tree image
        public string WriteTextFileWithFormula(AbstractNode currentNode)
        {
            string text = "";
            text += "node" + currentNode.GetId() + " [ label = \"" + currentNode.ToPrefixString() + "\" ]" + "\n";
            if (currentNode.GetLeftChild() != null)
            {
                text += "node" + currentNode.GetId() + " -- " + "node" + currentNode.GetLeftChild().GetId() + "\n";
                text += WriteTextFileWithFormula(currentNode.GetLeftChild());
            }

            if (currentNode.GetRightChild() != null)
            {
                text += "node" + currentNode.GetId() + " -- " + "node" + currentNode.GetRightChild().GetId() + "\n";
                text += WriteTextFileWithFormula(currentNode.GetRightChild());
            }
            return text;
        }

        //generate a text file to create a tree image
        private void GenerateTextFile()
        {
            string s = "graph calculus{node [ fontname = \"arial\"]" + "\n" + this.WriteTextFileWithFormula(this.function.GetRootNode()) + "\n" + "}";
            try
            {
                using (StreamWriter sw = new StreamWriter("./graph.dot"))
                {
                    sw.WriteLine(s);
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    
        public void GenerateTreeImageForDerivative()
        {
            GenerateDerivativeTextFile();
            Process dot = new Process();

            dot.StartInfo.FileName = @"dot.exe";
            dot.StartInfo.Arguments = "-Tpng -oderivativetree.png graph.dot";
            dot.Start();
            dot.WaitForExit();
        }


        //generate a text file to create a tree image of the derivative
        private void GenerateDerivativeTextFile()
        {
            string s = "graph calculus{node [ fontname = \"arial\"]" + "\n" + this.WriteTextFileWithFormula(this.function.GetDerivative().Simplify().GetRootNode()) + "\n" + "}";
            try
            {
                using (StreamWriter sw = new StreamWriter("./graph.dot"))
                {
                    sw.WriteLine(s);
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }
}
