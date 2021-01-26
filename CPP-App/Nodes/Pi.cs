using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class Pi : AbstractNode
    {
        public Pi():base()
        {

        }

        public override AbstractNode DeepCopy()
        {
            return new Pi();
        }

        public override AbstractNode GetDerivative()
        {
            return new NaturalNumber(0);
        }

        public override string GetInfixFormula()
        {
            return "pi";
        }

        public override AbstractNode GetNewton(double h)
        {
            return this.DeepCopy();
        }

        public override double GetValue(double x)
        {
            return Math.PI;
        }

        public override AbstractNode Simplify()
        {
            return this.DeepCopy();     
        }

        public override string ToPrefixString()
        {
           return "pi";
        }
    }
}
