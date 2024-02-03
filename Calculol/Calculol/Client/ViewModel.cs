using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculol.Core;
using Calculol.Properties;
using CalculolClassLibrary;


namespace Calculol.Client
{
    public class ViewModel
    {
        public string Equation = " ";

        private CalculatorParser parser;
        private CalculatorEvaluator evaluator;
        private PrivateFontCollection TypoDigitFont;


        public ViewModel() {
            parser = new CalculatorParser();
            evaluator = new CalculatorEvaluator();
            TypoDigitFont = new PrivateFontCollection();
            TypoDigitFont.AddFontFile(@"..\..\Resources\TypoDigit.ttf");
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

        public string Evaluate()
        {
            string EqTrim = Equation.Trim();
            try
            {
                return evaluator.EvaluatePostfix(parser.Parse(EqTrim)).ToString();
            }
            catch
            {
                ClearCache();
                return "Error";
            }
        }

        public void SetFont(Control control)
        {
            control.Font = new Font(TypoDigitFont.Families[0], control.Font.Size);
        }

        public void ClearCache()
        {
            evaluator = new CalculatorEvaluator();
            parser = new CalculatorParser();
        }
    }
}
