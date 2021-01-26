using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CPP_App.Nodes
{
    public class Sine:AbstractNode
    {
        public Sine(AbstractNode left):base(left)
        {

        }

        public override AbstractNode DeepCopy()
        {
            AbstractNode left = null;
            if (this.GetLeftChild() != null)
            {
                left = this.GetLeftChild().DeepCopy();
            }
            
            return new Sine(left);
        }

        public override AbstractNode GetDerivative()
        {
            Multiply derivativeNode = new Multiply(new Cosine(this.GetLeftChild().DeepCopy()), this.GetLeftChild().GetDerivative());
            return derivativeNode;
        }

        public override string GetInfixFormula()
        {
            return "(sin("+this.GetLeftChild().GetInfixFormula()+"))";
        }

        public override AbstractNode GetNewton(double h)
        {
            return new Sine(this.GetLeftChild().GetNewton(h));
        }

        public override double GetValue(double x)
        {
            return Math.Sin(this.GetLeftChild().GetValue(x));
        }

        public override AbstractNode Simplify()
        {
            AbstractNode left = this.GetLeftChild().DeepCopy().Simplify();
            if ((left is NaturalNumber && ((NaturalNumber)left).GetValue() == 0)
                || (left is RealNumber && ((RealNumber)left).GetValue() == 0)
                || left is Pi)
            {
                return new RealNumber(0);
            }
            else
            {
                return new Sine(left);
            }            
        }

        public override string ToPrefixString()
        {
            return "sin";
        }
    }
}
