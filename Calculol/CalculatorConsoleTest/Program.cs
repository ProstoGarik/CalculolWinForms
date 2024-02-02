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


            string Eq = "2 ^ 3 ";
            string Eq2 = Eq.Trim();
            
            Console.WriteLine(Math.Pow(2,3));
            Console.ReadKey();
        }
    }
}
