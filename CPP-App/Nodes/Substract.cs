﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPP_App.Nodes
{
    public class Substract : AbstractNode
    {
        public Substract(AbstractNode left, AbstractNode right):base(left,right)
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
            return new Substract(left, right);
        }

        public override AbstractNode GetDerivative()
        {
            Substract derivativeNode = new Substract(this.GetLeftChild().GetDerivative(), this.GetRightChild().GetDerivative());
            return derivativeNode;
        }

        public override string GetInfixFormula()
        {
            return "("+this.GetLeftChild().GetInfixFormula()+"-"+this.GetRightChild().GetInfixFormula()+")";
        }

        public override AbstractNode GetNewton(double h)
        {
            return new Substract(this.GetLeftChild().GetNewton(h), this.GetRightChild().GetNewton(h));
        }

        public override double GetValue(double x)
        {
            return this.GetLeftChild().GetValue(x) - this.GetRightChild().GetValue(x);
        }

        public override AbstractNode Simplify()
        {
            AbstractNode left = this.GetLeftChild().DeepCopy().Simplify();
            AbstractNode right = this.GetRightChild().DeepCopy().Simplify();
            if ((right is NaturalNumber ||right is RealNumber) && (right.GetValue(0) == 0))
            {               
                return left;                             
            }
            else if ((left is NaturalNumber||left is RealNumber) && (right is NaturalNumber||right is RealNumber))
            {
                return new RealNumber((left.GetValue(0) - right.GetValue(0)));
            }
            else if (left is Logarithm && right is Logarithm)
            {
                Divide divide = new Divide(left.GetLeftChild(), right.GetLeftChild());
                Logarithm logarithm = new Logarithm(divide.Simplify());
                return logarithm.Simplify();
            }
            else
            {
                return new Substract(left, right);
            }
        }

        public override string ToPrefixString()
        {
            return "-";
        }
    }
}
