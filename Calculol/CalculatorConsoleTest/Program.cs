using Calculol.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorParser parser = new CalculatorParser();
            CalculatorEvaluator evaluator = new CalculatorEvaluator();

            List<String> EqOut2 = new List<string>();    


            string Eq = "2 + 2 ";
            string Eq2 = Eq.Trim();
            parser.Parse(Eq);

            Console.WriteLine(Eq + "O");
            Console.WriteLine(Eq2 + "O");
            foreach (var i in parser.Parse(Eq2))
            {
                EqOut2.Add(i);
            }
            foreach (var item in EqOut2)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine(evaluator.EvaluatePostfix(EqOut2));
            Console.ReadKey();
        }
    }
}
