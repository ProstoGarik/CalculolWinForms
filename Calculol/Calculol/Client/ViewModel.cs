using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculol.Core;
using CalculolClassLibrary;


namespace Calculol.Client
{
    public class ViewModel
    {
        public string Equation = " ";

        private CalculatorParser parser;
        private CalculatorEvaluator evaluator;


        public ViewModel() {
            parser = new CalculatorParser();
            evaluator = new CalculatorEvaluator();
        }

        public bool isEmpty()
        {
            return Equation == "" || Equation == " " || Equation == null;
        }

        public void AddToEq(char addToken)
        {
            if (int.TryParse(addToken.ToString(), out _))
            {
                Equation += addToken;
            }
            else
            {
                Equation += " " + addToken + " ";
            }
            
        }

        public void EraseFromEq()
        {
            if(!isEmpty())
            {
                if (Equation[Equation.Length-1] == ' ')
                {
                    Equation = Equation.Remove(Equation.Length - 1);
                    Equation = Equation.Remove(Equation.Length - 1);
                }
                else
                {
                    Equation = Equation.Remove(Equation.Length - 1);
                }

            } 
        }

        public void ClearAll()
        {
            Equation = " ";
        }

        public double Evaluate()
        {
            string EqTrim = Equation.Trim();
            return evaluator.EvaluatePostfix(parser.Parse(EqTrim));
        }
    }
}
