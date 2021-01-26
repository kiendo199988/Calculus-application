using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class Cosine : AbstractNode
    {
        public Cosine(AbstractNode left):base(left)
        {

        }

        public override AbstractNode DeepCopy()
        {
            AbstractNode left = null;
            if (this.GetLeftChild() != null)
            {
                left = this.GetLeftChild().DeepCopy();
            }          
            return new Cosine(left);
        }

        public override AbstractNode GetDerivative()
        {
            Substract derivativeNode = new Substract(new NaturalNumber(0),
                new Multiply(new Sine(this.GetLeftChild().DeepCopy()),this.GetLeftChild().GetDerivative()));
            return derivativeNode;
        }

        public override string GetInfixFormula()
        {
           return "(cos("+this.GetLeftChild().GetInfixFormula()+"))";
        }

        public override AbstractNode GetNewton(double h)
        {                      
            return new Cosine(this.GetLeftChild().GetNewton(h));
        }

        public override double GetValue(double x)
        {
            return Math.Cos(this.GetLeftChild().GetValue(x));
        }

        public override AbstractNode Simplify()
        {
            AbstractNode left = this.GetLeftChild().DeepCopy().Simplify();
            if ((left is NaturalNumber || left is RealNumber) && left.GetValue(0) == 0)
            {
                return new NaturalNumber(1);
            }
            else if(left is Pi)
            {
                return new RealNumber(-1);
            }
            else
            {
                return new Cosine(left);              
            }
            
        }

        public override string ToPrefixString()
        {
            return "cos";
        }
    }
}
