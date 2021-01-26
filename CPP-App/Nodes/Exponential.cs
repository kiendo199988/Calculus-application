using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class Exponential : AbstractNode
    {
        public Exponential(AbstractNode left):base(left)
        {

        }

        public override AbstractNode DeepCopy()
        {
            AbstractNode left = null;
            if (this.GetLeftChild() != null)
            {
                left = this.GetLeftChild().DeepCopy();
            }
            return new Exponential(left);
        }

        public override AbstractNode GetDerivative()
        {
            Multiply n = new Multiply(this.GetLeftChild().GetDerivative(), this.DeepCopy());
            return n;
        }

        public override string GetInfixFormula()
        {
            return "(e^(" + this.GetLeftChild().GetInfixFormula() + "))";
        }

        public override AbstractNode GetNewton(double h)
        {          
            return new Exponential(this.GetLeftChild().GetNewton(h));
        }

        public override double GetValue(double x)
        {
            return Math.Exp(this.GetLeftChild().GetValue(x));
        }

        public override AbstractNode Simplify()
        {
            AbstractNode left = this.GetLeftChild().DeepCopy().Simplify();
            if ((left is NaturalNumber||left is RealNumber) && left.GetValue(0) == 0)
            {              
                return new NaturalNumber(1);                           
            }
            else if (left is Logarithm)
            {
                return left.GetLeftChild();
            }
            else
            {
                return new Exponential(left);
            }
        }

        public override string ToPrefixString()
        {
            return  "e^";
        }
    }
}
