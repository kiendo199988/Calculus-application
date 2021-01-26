using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPP_App.Nodes;

namespace CPP_App
{
    public class NPolynomialGenerator
    {
        private double[] coefficients;
        
        public NPolynomialGenerator(Matrix m)
        {
            GaussianEliminator eliminator = new GaussianEliminator();
            if (m.GetPoints() != null)
            {
                coefficients = eliminator.GaussianElim(m, m.GetPoints().Count);
            }
            if (m.GetnPolyCoordinates() != null)
            {
                coefficients = eliminator.GaussianElim(m, m.GetnPolyCoordinates().Count);
            }

        }

        //return abstract node for polynomial
        public AbstractNode GetNPolynomial(double[] coefficients, int i,int j)
        {
            if (i < coefficients.Length - 1)
            {
                Multiply mul = new Multiply(new RealNumber(coefficients[i]), new Power(new Variable(), new NaturalNumber(i + j)));
                return new Add(mul, this.GetNPolynomial(coefficients,i + 1,j));
            }
            else
            {
                return new Multiply(new RealNumber(coefficients[i]), new Power(new Variable(), new NaturalNumber(i + j)));

            }
        }

        //get the whole fuction for the npoly
        public Function GetNPolyFunction()
        {
            return new Function(this.GetNPolynomial(coefficients,0,0));
        }

        
    }
}
