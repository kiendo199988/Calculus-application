using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class Logarithm:AbstractNode
    {
        public Logarithm(AbstractNode left):base(left)
        {

        }

        public override AbstractNode DeepCopy()
        {
            AbstractNode left = null;
            if (this.GetLeftChild() != null)
            {
                left = this.GetLeftChild().DeepCopy();
            }        
            return new Logarithm(left);
        }

        public override AbstractNode GetDerivative()
        {
            Divide n = new Divide(this.GetLeftChild().GetDerivative(), this.GetLeftChild().DeepCopy());
            return n;
        }

        public override string GetInfixFormula()
        {
            return "(ln("+this.GetLeftChild().GetInfixFormula()+"))";
        }

        public override AbstractNode GetNewton(double h)
        {
            return new Logarithm(this.GetLeftChild().GetNewton(h));
        }

        public override double GetValue(double x)
        {          
            return Math.Log(this.GetLeftChild().GetValue(x));           
        }

        public override AbstractNode Simplify()
        {
            AbstractNode left = this.GetLeftChild().DeepCopy().Simplify();
            if ((left is NaturalNumber || left is RealNumber) && (left.GetValue(0) == 1))
            {           
                return new NaturalNumber(0);             
            }
            else if (left is Exponential)
            {
                return left.GetLeftChild();
            }
            else if(left is Power)
            {
                Logarithm l = new Logarithm(left.GetLeftChild());
                Multiply m = new Multiply(left.GetRightChild().Simplify(), l.Simplify());
                return m.Simplify();
            }
            else
            {
                return new Logarithm(left);
            }   
        }

        public override string ToPrefixString()
        {
            return "ln";
        }
    }
}
