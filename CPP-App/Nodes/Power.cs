using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class Power : AbstractNode
    {
        public Power(AbstractNode left, AbstractNode right):base(left,right)
        {
            
        }

        public override AbstractNode DeepCopy()
        {
            AbstractNode left = null;
            AbstractNode right = null;
            if (this.GetLeftChild() != null)
            {
                left = this.GetLeftChild().DeepCopy();
            }
            if (this.GetRightChild() != null)
            {
                right = this.GetRightChild().DeepCopy();
            }
            return new Power(left, right);
        }

        public override AbstractNode GetDerivative()
        {
            Multiply n = new Multiply( 
                new Multiply(this.GetRightChild().DeepCopy(),this.GetLeftChild().GetDerivative()),
                new Power(this.GetLeftChild().DeepCopy(),
                new NaturalNumber(Convert.ToInt32(this.GetRightChild().GetValue(0)-1))));
            return n;
        }

        public override string GetInfixFormula()
        {
            return "("+this.GetLeftChild().GetInfixFormula()+"^("+this.GetRightChild().GetInfixFormula()+"))";
        }

        public override AbstractNode GetNewton(double h)
        {
            return new Power(this.GetLeftChild().GetNewton(h), this.GetRightChild().GetNewton(h));
        }

        public override double GetValue(double x)
        {
            return Math.Pow(this.GetLeftChild().GetValue(x), this.GetRightChild().GetValue(x));
        }

        public override AbstractNode Simplify()
        {
            AbstractNode left = this.GetLeftChild().DeepCopy().Simplify();
            AbstractNode right = this.GetRightChild().DeepCopy().Simplify();
            if (right is NaturalNumber && ((NaturalNumber)right).GetValue() == 0)
            {                
                return new NaturalNumber(1);                                       
            }
            else if (right is NaturalNumber && ((NaturalNumber)right).GetValue() == 1)
            {
                return this.GetLeftChild().DeepCopy().Simplify();
            }
            else if (right is NaturalNumber && (left is NaturalNumber || left is RealNumber))
            {
                return new RealNumber(Math.Pow(left.GetValue(0), right.GetValue(0)));
            }
            else if(left is Exponential)
            {
                Multiply multiply = new Multiply(left.GetLeftChild(), right);
                Exponential e = new Exponential(multiply.Simplify());
                return e;
            }
            else
            {
                return new Power(this.GetLeftChild().DeepCopy().Simplify(), this.GetRightChild().DeepCopy().Simplify());              
            }
        }

        public override string ToPrefixString()
        {
            return "^";
        }
    }
}
