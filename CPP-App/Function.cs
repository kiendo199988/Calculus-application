using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPP_App.Nodes;
using System.IO;
using System.Diagnostics;
using CPP_App.Exceptions;

namespace CPP_App
{
    public class Function
    {
        //fields
        private AbstractNode rootNode;
        //getter
        public AbstractNode GetRootNode()
        {
            return this.rootNode;
        }
        //constructor
        public Function(AbstractNode root)
        {
            this.rootNode = root;
            if (this.rootNode != null)
            {
                this.rootNode.SetId(0);
                rootNode.SetIndexForChildrenNode();
            }
        }
           
        //get value of a funtion based on x
        public double GetValue(double x)
        {
            return this.GetRootNode().GetValue(x);
        }

        //get derivative
        public Function GetDerivative()
        {
            Function derivative = new Function(this.rootNode.GetDerivative());
            return derivative;
        }

        //simplify function
        public Function Simplify()
        {
            Function f = new Function(this.rootNode.Simplify());
            return f;
        }

        //get infix formula
        public string GetInfixFormula()
        {
            return this.GetRootNode().GetInfixFormula();
        }
                
        //get newtons quotient function
        public Function GetNewtonQuotientFunction(double h)
        {
            Divide divide = new Divide(new Substract(this.GetRootNode().GetNewton(h), this.GetRootNode().DeepCopy()), new RealNumber(h));
            return new Function(divide);
        }

        //get riemann integrals
        public double GetRiemannIntegral(double bound1,double bound2,double originX,int pixelsPerSquare, int scale)
        {
            double result = 0;
               
            if (bound1 <= bound2)
            {
                for (double i = bound1; i < bound2; i++)
                {
                    double x = (i - originX) / (pixelsPerSquare * scale);
                    if (this.GetRootNode().CheckDomain(x) == true)
                    {                     
                        result += this.GetValue(x)/(pixelsPerSquare * scale);
                    }
                }
            }
            else
            {
                for (double i = bound2; i < bound1; i++)
                {
                    double x = (i - originX) / (pixelsPerSquare * scale);
                    if (this.GetRootNode().CheckDomain(x) == true)
                    {
                        result += this.GetValue(x) / (pixelsPerSquare * scale);
                    }
                }
            }          
            return result;
        }

        //n-th order derivative
        public Function GetNthOrderDerivative(Function f, int nthOrder)
        {
            if (nthOrder > 1)
            {
                nthOrder--;
                Function derivative = f.GetDerivative().Simplify();
                return derivative.GetNthOrderDerivative(derivative, nthOrder);
            }
            else
            {
                return f.GetDerivative().Simplify();
            }
        }
        
        //get mclaurin polynomial terms(analytically)
        public AbstractNode GetMcLaurinTermsAnalytically(Function f,int nthOrder)
        {
            if (f.GetNthOrderDerivative(f, nthOrder).GetRootNode().CheckDomain(0) == true)
            {
                if (nthOrder > 1)
                {
                    Divide coefficient = new Divide(new RealNumber(f.GetNthOrderDerivative(f, nthOrder).GetValue(0)), new Factorial(new NaturalNumber(nthOrder)));
                    Multiply term = new Multiply(coefficient, new Power(new Variable(), new NaturalNumber(nthOrder)));
                    return new Add(term, f.GetMcLaurinTermsAnalytically(f, nthOrder - 1));
                }
                else
                {
                    Divide coefficient = new Divide(new RealNumber(f.GetNthOrderDerivative(f, nthOrder).GetValue(0)), new Factorial(new NaturalNumber(nthOrder)));
                    return new Multiply(coefficient, new Power(new Variable(), new NaturalNumber(nthOrder)));
                }
            }
            else
            {
                return null;
            }
           
        }

        //get mclaurin series(analytically)
        public Function GetMclaurinSeriesAnalytically(int nthOrder)
        {
            if (GetMcLaurinTermsAnalytically(this, nthOrder) != null && (this.GetRootNode().CheckDomain(0)==true))
            {             
                Add mclaurinRoot = new Add(new RealNumber(GetValue(0)), GetMcLaurinTermsAnalytically(this, nthOrder));
                return new Function(mclaurinRoot).Simplify();
            }
            else
            {
                return null;
            }

        }

        //get nth-order derivative using newton's
        public Function GetDerivativeByNewtonQuotient(Function f, int order)
        {
            if (order > 1)
            {
                Function intermediate = f.GetNewtonQuotientFunction(0.01).Simplify(); 
                return intermediate.GetDerivativeByNewtonQuotient(intermediate, order - 1);
            }
            else
            {
                return f.GetNewtonQuotientFunction(0.01).Simplify();
            }
        }

        //get McLaurin terms using newton method
        public AbstractNode GetMcLaurinTermsByNewton(Function f, int nthOrder)
        {
            if (f.GetDerivativeByNewtonQuotient(f, nthOrder).GetRootNode().CheckDomain(0) == true)
            {
                if (nthOrder > 1)
                {
                    Divide coefficient = new Divide(new RealNumber(f.GetDerivativeByNewtonQuotient(f, nthOrder).GetValue(0)), new Factorial(new NaturalNumber(nthOrder)));
                    Multiply term = new Multiply(coefficient, new Power(new Variable(), new NaturalNumber(nthOrder)));
                    return new Add(term, f.GetMcLaurinTermsByNewton(f, nthOrder - 1));
                }
                else
                {
                    Divide coefficient = new Divide(new RealNumber(f.GetDerivativeByNewtonQuotient(f, nthOrder).GetValue(0)), new Factorial(new NaturalNumber(nthOrder)));
                    return new Multiply(coefficient, new Power(new Variable(), new NaturalNumber(nthOrder)));
                }
            }
            else
            {
                return null;
            }
        }

        //get mclaurin series by newton
        public Function GetMclaurinSeriesByNewton(int nthOrder)
        {
            if (GetMcLaurinTermsByNewton(this, nthOrder) != null && (this.GetRootNode().CheckDomain(0) == true))
            {
                Add mclaurinRoot = new Add(new RealNumber(GetValue(0)), GetMcLaurinTermsByNewton(this, nthOrder));
                return new Function(mclaurinRoot).Simplify();
            }
            else
            {
                return null;
            }
        }

       
    }
}
