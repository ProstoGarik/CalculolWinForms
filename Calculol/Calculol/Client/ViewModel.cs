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
        public string Equation;
        public string EquationOut = "";

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
            {
                Equation += addToken + " ";
            }
            
        }

        public void EraseFromEq()
        {
            if(!isEmpty())
            {
                Equation = Equation.Remove(Equation.Length - 1);
                Equation = Equation.Remove(Equation.Length - 1);
            }
            
        }

        public void Parse()
        {
            foreach(string i in parser.Parse(Equation))
            {
                EquationOut += i;
            }
        }

        public void Evaluate()
        {
            Equation.Trim();
            evaluator.EvaluatePostfix(parser.Parse(Equation));
        }
    }
}
