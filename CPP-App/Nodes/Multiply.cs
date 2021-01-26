using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class Multiply:AbstractNode
    {
        public Multiply(AbstractNode left, AbstractNode right):base(left,right)
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
            return new Multiply(left, right);
        }

        public override AbstractNode GetDerivative()
        {
            Add n = new Add(new Multiply(this.GetLeftChild().GetDerivative(), this.GetRightChild().DeepCopy())
                , new Multiply(this.GetRightChild().GetDerivative(), this.GetLeftChild().DeepCopy()));
            return n;
        }

        public override string GetInfixFormula()
        {
            return "("+this.GetLeftChild().GetInfixFormula()+"*"+this.GetRightChild().GetInfixFormula()+")";
        }

        public override AbstractNode GetNewton(double h)
        {
            return new Multiply(this.GetLeftChild().GetNewton(h), this.GetRightChild().GetNewton(h));
        }

        public override double GetValue(double x)
        {
            return this.GetLeftChild().GetValue(x) * this.GetRightChild().GetValue(x);
        }

        public override AbstractNode Simplify()
        {
            AbstractNode left = this.GetLeftChild().DeepCopy().Simplify();
            AbstractNode right = this.GetRightChild().DeepCopy().Simplify();
            if (((left is NaturalNumber || left is RealNumber) && left.GetValue(0) == 0) ||((right is NaturalNumber || right is RealNumber) && right.GetValue(0) == 0))
            {
                return new NaturalNumber(0);
            }
            else if ((left is NaturalNumber || left is RealNumber) && left.GetValue(0) == 1)
            {
                return right;
            }
            else if ((right is NaturalNumber || right is RealNumber) && right.GetValue(0) == 1)
            {
                return left;
            }
            else if ((left is NaturalNumber || left is RealNumber) && (right is NaturalNumber || right is RealNumber))
            {
                return new RealNumber((left.GetValue(0) * right.GetValue(0)));
            }
            else if(left is Exponential && right is Exponential)
            {
                Add add = new Add(left.GetLeftChild(), right.GetLeftChild());
                Exponential exponential = new Exponential(add.Simplify());
                return exponential.Simplify();
            }
            else
            {
                return new Multiply(left, right);
            }
        }

        public override string ToPrefixString()
        {
            return "*";
        }
    }
}
