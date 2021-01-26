using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class Factorial:AbstractNode
    {
        public Factorial(AbstractNode left):base(left)
        {
            
        }

        public override AbstractNode DeepCopy()
        {
            AbstractNode left = null;
            if (this.GetLeftChild() != null)
            {
                left = this.GetLeftChild().DeepCopy();
            }
            
            return new Factorial(left);
        }

        public override AbstractNode GetDerivative()
        {
            return new NaturalNumber(0);
        }

        public override string GetInfixFormula()
        {
            return "("+this.GetLeftChild().GetInfixFormula() + "!)";
        }

        public override AbstractNode GetNewton(double h)
        {
            return this.DeepCopy();
        }

        public override double GetValue(double x)
        {
            double result = 1;
            for (int i=1;i<=this.GetLeftChild().GetValue(x);i++)
            {
                result = i*result;
            }
            return result;
        }

        public override AbstractNode Simplify()
        {
            return this.DeepCopy();
        }

        public override string ToPrefixString()
        {
            return "!";
        }
    }
}
