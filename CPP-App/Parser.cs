using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPP_App.Nodes;
using CPP_App.Exceptions;

namespace CPP_App
{
    public class Parser
    {
        private string formula;

        public string GetFormula()
        {
            return this.formula;
        }
        public Parser(string formula)
        {
            this.formula = formula;
        }

        public AbstractNode BuildBinaryTree(List<char> formula)
        {
            if (formula.Count > 0)
            {
                if (formula[0] == 'x')
                {
                    formula.RemoveAt(0);
                    Variable variable = new Variable();
                    return variable;
                }
                else if (Char.IsDigit(formula[0]))
                {
                    char prefixChar = formula[0];
                    formula.RemoveAt(0);
                    NaturalNumber naturalNumber = new NaturalNumber((int)char.GetNumericValue(prefixChar));
                    return naturalNumber;
                }
                else if (formula[0] == 'n')
                {
                    if (formula[1] == '(' && (formula[2] == '-' || char.IsDigit(formula[2])))
                    {
                        formula.RemoveAt(0);
                        formula.RemoveAt(0);
                        string naturalNum = "";                       
                        while (formula[0] != ')')
                        {
                            naturalNum += formula[0];
                            formula.RemoveAt(0);
                        }                 
                       
                        if (naturalNum != null)
                        {
                            NaturalNumber naturalNumber = new NaturalNumber(Convert.ToInt32(naturalNum));
                            return naturalNumber;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }               
                else if (formula[0] == 'r')
                {
                    if (formula[1] == '(' && (formula[2] == '-' || char.IsDigit(formula[2])))
                    {
                        formula.RemoveAt(0);
                        formula.RemoveAt(0);

                        string realNum = "";

                        while (formula[0] != ')')
                        {
                            realNum += formula[0];
                            formula.RemoveAt(0);
                        }                       
                        if (realNum != null)
                        {
                            RealNumber realNumber = new RealNumber(Convert.ToDouble(realNum));
                            return realNumber;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else if (formula[0] == '+')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    AbstractNode right = BuildBinaryTree(formula);
                    Add nodeAdd = new Add(left, right);
                    return nodeAdd;
                }
                else if (formula[0] == '-')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    AbstractNode right = BuildBinaryTree(formula);
                    Substract nodeSubstract = new Substract(left, right);
                    return nodeSubstract;
                }
                else if (formula[0] == '*')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    AbstractNode right = BuildBinaryTree(formula);
                    Multiply nodeMultiply = new Multiply(left, right);
                    return nodeMultiply;
                }
                else if (formula[0] == '/')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    AbstractNode right = BuildBinaryTree(formula);
                    Divide nodeDivide = new Divide(left, right);
                    return nodeDivide;
                }
                else if (formula[0] == '^')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    AbstractNode right = BuildBinaryTree(formula);
                    if(right is NaturalNumber && !(left is Exponential))
                    {
                        Power power = new Power(left, right);
                        return power;
                    }
                    else if (left is Exponential)
                    {
                        Power power = new Power(left, right);
                        return power;
                    }
                    else
                    {
                        return null;
                    }
                    
                }
                else if (formula[0] == 's')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    Sine sine = new Sine(left);
                    return sine;
                }
                else if (formula[0] == 'c')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    Cosine cosine = new Cosine(left);
                    return cosine;
                }
                else if (formula[0] == 'e')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    Exponential exponential = new Exponential(left);
                    return exponential;
                }
                else if (formula[0] == 'l')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    Logarithm logarithm = new Logarithm(left);
                    return logarithm;
                }
                else if (formula[0] == '!')
                {
                    formula.RemoveAt(0);
                    AbstractNode left = BuildBinaryTree(formula);
                    if(left is NaturalNumber && ((NaturalNumber)left).GetValue() > 0)
                    {
                        Factorial factorial = new Factorial(left);
                        return factorial;
                    }
                    else
                    {
                        return null;
                    }
                }
                else if (formula[0] == 'p')
                {
                    formula.RemoveAt(0);
                    Pi pi = new Pi();
                    return pi;
                }
                else
                {
                    formula.RemoveAt(0);
                    return this.BuildBinaryTree(formula);
                }               
            }
            else
            {
                return null;
            }
        }

        //parsing coordinates for nPoly
        public List<NPolyCoordinate> GetListOfCoordinates(List<char> formula)
        {
            if (formula.Count > 0)
            {
                if (formula[0] == '-' || char.IsDigit(formula[0]))
                {
                    string x = "";
                    while (formula[0] != ',')
                    {
                        x += formula[0];
                        formula.RemoveAt(0);
                    }
                    formula.RemoveAt(0);
                    string y = "";
                    while (formula[0] != ';')
                    {
                        y += formula[0];
                        formula.RemoveAt(0);
                    }
                    formula.RemoveAt(0);
                    NPolyCoordinate coordinate = new NPolyCoordinate(Convert.ToDouble(x), Convert.ToDouble(y));
                    List<NPolyCoordinate> coordinates = new List<NPolyCoordinate>();
                    coordinates.Add(coordinate);
                    if (GetListOfCoordinates(formula.ToList<char>()) != null)
                    {
                        coordinates.AddRange(GetListOfCoordinates(formula.ToList<char>()));
                    }
                    return coordinates;
                }
                else
                {
                    formula.RemoveAt(0);
                    return GetListOfCoordinates(formula.ToList<char>());
                }
            }
            else
            {
                return null;
            }
            
        }
    }
}
