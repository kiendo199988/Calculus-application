using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class Divide : AbstractNode
    {
        public Divide(AbstractNode left, AbstractNode right):base(left,right)
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
            return new Divide(left, right);
        }

        public override AbstractNode GetDerivative()
        {
            Divide derivativeNode = new Divide( 
                new Substract(new Multiply(this.GetRightChild().DeepCopy(),this.GetLeftChild().GetDerivative()),
                new Multiply(this.GetLeftChild().DeepCopy(), this.GetRightChild().GetDerivative())), 
                new Power(this.GetRightChild().DeepCopy(),new NaturalNumber(2)));
            return derivativeNode;
        }

        public override string GetInfixFormula()
        {
            return "("+this.GetLeftChild().GetInfixFormula()+"/"+this.GetRightChild().GetInfixFormula()+")";
        }

        public override AbstractNode GetNewton(double h)
        {     
            return new Divide(this.GetLeftChild().GetNewton(h), this.GetRightChild().GetNewton(h));
        }

        public override double GetValue(double x)
        {
            return this.GetLeftChild().GetValue(x) / this.GetRightChild().GetValue(x);          
        }

        public override AbstractNode Simplify()
        {
            AbstractNode left = this.GetLeftChild().DeepCopy().Simplify();
            AbstractNode right = this.GetRightChild().DeepCopy().Simplify();
            if ((right is NaturalNumber|| right is RealNumber) && (right.GetValue(0) == 1))
            {
                return left;                          
            }
            else if ( ( (left is NaturalNumber || left is RealNumber) && (left.GetValue(0) == 0) )
                && ( (right is NaturalNumber|| right is RealNumber || right is Factorial) && (right.GetValue(0) != 0) ) )
            {
                return new NaturalNumber(0);
            }
            else if ((left is NaturalNumber || left is RealNumber || left is Factorial) && (right is NaturalNumber || right is RealNumber ||right is Factorial) && right.GetValue(0) != 0)
            {
                return new RealNumber((left.GetValue(0) / right.GetValue(0)));
            }
            else if (left is Exponential && right is Exponential)
            {
                Substract sub = new Substract(left.GetLeftChild(), right.GetLeftChild());
                Exponential exponential = new Exponential(sub.Simplify());
                return exponential.Simplify();
            }
            else
            {
                return new Divide(left, right);
            }
        }

        public override string ToPrefixString()
        {
            return "/";
        }
    }
}
