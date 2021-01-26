using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class NaturalNumber:AbstractNode,IFunc
    {
        private int naturalNum;
        public NaturalNumber(int number):base(number)
        {
            this.naturalNum = number;
        }

        public override AbstractNode DeepCopy()
        {         
            return new NaturalNumber(naturalNum);
        }

        public override AbstractNode GetDerivative()
        {
            return new NaturalNumber(0);
        }

        public override string GetInfixFormula()
        {
            if (this.naturalNum < 0)
            {
                return "(" + this.naturalNum.ToString() + ")";
            }
            else
            {
                return this.naturalNum.ToString();
            }
        }

        public override AbstractNode GetNewton(double h)
        {
            return this.DeepCopy();
        }

        public int GetValue()
        {
            return this.naturalNum;
        }

        public override double GetValue(double x)
        {
            return Convert.ToDouble(this.naturalNum);
        }

        public override AbstractNode Simplify()
        {
            return this.DeepCopy();
        }

        public override string ToPrefixString()
        {
            return this.naturalNum.ToString();
        }
    }
}
