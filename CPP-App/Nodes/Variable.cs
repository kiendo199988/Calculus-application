using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class Variable:AbstractNode
    {
        public Variable() : base()
        {

        }

        public override AbstractNode DeepCopy()
        {
            return new Variable();
        }

        public override AbstractNode GetDerivative()
        {
            return new RealNumber(1);
        }

        public override string GetInfixFormula()
        {
            return "x";
        }

        public override AbstractNode GetNewton(double h)
        {
            return new Add(this.DeepCopy(), new RealNumber(h));
        }

        public override double GetValue(double x)
        {
            return x;
        }

        public override AbstractNode Simplify()
        {
            return this.DeepCopy();
        }

        public override string ToPrefixString()
        {
            return "x";
        }
    }
}
