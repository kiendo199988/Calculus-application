using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Nodes
{
    public abstract class AbstractNode:IFunc
    {
        //fields
        private AbstractNode leftChild;
        private AbstractNode rightChild;
        private int id;

        //getter setter        
        
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int i)
        {
            this.id = i; 
        }
        public AbstractNode GetRightChild()
        {
            if (this.rightChild != null)
            {
                return this.rightChild;
            }
            else
            {
                return null;
            }
             
        }
        public AbstractNode GetLeftChild()
        {
            if (this.leftChild != null)
            {
                return this.leftChild;
            }
            else
            {
                return null;
            }
        }
            
        //constructor
        
        //variable
        //pi
        public AbstractNode()
        {

        }

        //natural numbers 
        public AbstractNode(int naturalNumber)
        {

        }

        //real number
        public AbstractNode(double realNumber)
        {

        }
        
        //add, divide, multiply, substract, power
        public AbstractNode(AbstractNode left, AbstractNode right)
        {
            this.leftChild = left;  
            this.rightChild = right;
        }

        //power
        //sine, cosine, exp, ln, factorial
        public AbstractNode(AbstractNode left)
        {
            this.leftChild = left;
        }
       
        //method
        
        public void SetIndexForChildrenNode()
        {
            if (this.leftChild != null)
            {
                leftChild.SetId(2 * this.GetId() + 1);
                leftChild.SetIndexForChildrenNode();
            }
            if (rightChild != null)
            {
                rightChild.SetId(2 * this.GetId() + 2);
                rightChild.SetIndexForChildrenNode();
            }
        }

        //get prefix string
        public abstract string ToPrefixString();
        //get value based on variable
        public abstract double GetValue(double x);
        //get derivative
        public abstract AbstractNode GetDerivative();
        //copy a node
        public abstract AbstractNode DeepCopy();
        //simplify a formula
        public abstract AbstractNode Simplify();
        //get the infix notation of the function
        public abstract string GetInfixFormula();
        //get newton function f(x+h)
        public abstract AbstractNode GetNewton(double h);

        //domain
        public bool CheckDomain(double x)
        {
            if (this is Divide && (this.GetRightChild().GetValue(x) == 0 || this.GetLeftChild().CheckDomain(x) == false || this.GetRightChild().CheckDomain(x) == false))
            {               
                return false;                
            }
            if (this is Logarithm && (this.GetLeftChild().GetValue(x) <= 0 || this.GetLeftChild().CheckDomain(x) == false))
            {
                return false;                              
            }
            if (this is Power && ((GetRightChild().GetValue(x)<0 && Math.Pow(GetLeftChild().GetValue(x), -GetRightChild().GetValue(x)) == 0) || GetLeftChild().CheckDomain(x) == false))
            {              
                return false;
            }
            if (this.GetLeftChild() != null && this.GetLeftChild().CheckDomain(x) == false)
            {
                return false;
            }
            if (this.GetRightChild()!=null && this.GetRightChild().CheckDomain(x) == false)
            {
                return false;
            }
            return true;
        }      

    }
}
