using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public class RealNumber:AbstractNode,IFunc
    {
        private Double realNumber;
        
        public RealNumber(double realNum):base(realNum)
        {
            this.realNumber = realNum;
        }

        public override AbstractNode DeepCopy()
        {
            return new RealNumber(realNumber);
        }

        public override AbstractNode GetDerivative()
        {
            return new RealNumber(0);
        }

        public override string GetInfixFormula()
        {
            if (realNumber < 0)
            {
                return "(" + this.realNumber.ToString() + ")";
            }
            else
            {
                return this.realNumber.ToString();
            }
            
        }

        public override AbstractNode GetNewton(double h)
        {
            return this.DeepCopy();
        }

        public double GetValue()
        {
            return this.realNumber;
        }

        public override double GetValue(double x)
        {
            return this.realNumber;
        }

        public override AbstractNode Simplify()
        {
            return this.DeepCopy();
        }

        public override string ToPrefixString()
        {
            return this.realNumber.ToString();
        }
    }
}
