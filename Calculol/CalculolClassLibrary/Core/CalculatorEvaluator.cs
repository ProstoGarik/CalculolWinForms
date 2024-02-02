using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculol.Core
{
    public class CalculatorEvaluator
    {
        string[] operators = { "+", "-", "/", "*", "^"};

        public double EvaluatePostfix(List<string> equation)
        {
            double a;
            double b;
            Stack<double> values = new Stack<double>();
            foreach (string token in equation)
            {
                if (!operators.Contains(token))
                {
                    if (token != "")
                    {
                        values.Push(double.Parse(token));
                    }       
                }
                else
                {
                    switch (token)
                    {
                        case "+":
                            a = values.Pop();
                            b = values.Pop();
                            values.Push(a + b);
                            break;

                        case "-":
                            a = values.Pop();
                            b = values.Pop();
                            values.Push(b - a);
                            break;

                        case "*":
                            a = values.Pop();
                            b = values.Pop();
                            values.Push(a * b);
                            break;

                        case "/":
                            a = values.Pop();
                            b = values.Pop();
                            values.Push(b / a);
                            break;
                        case "^":
                            a = values.Pop();
                            b = values.Pop();
                            values.Push(Math.Pow(b,a));
                            break;
                    }
                }
            }
            return values.Peek();
        }
    }
}
