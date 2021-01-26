using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPP_App.Nodes;

namespace CPP_App
{
    interface IFunc
    {
        //get value of a function based on value of x
        double GetValue(Double x);

        //get derivative
        AbstractNode GetDerivative();

        //deep copy a node
        AbstractNode DeepCopy();

        //simplify
        AbstractNode Simplify();

        //get infix notation of the formula
        string GetInfixFormula();
        //get newton node
        AbstractNode GetNewton(double h);

    }
}
