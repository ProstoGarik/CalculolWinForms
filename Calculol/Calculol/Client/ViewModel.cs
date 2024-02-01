using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculol.Client
{
    internal class ViewModel
    {
        public string Equation;

        public void addToEq(char addToken)
        {
            Equation += " " + addToken;
        }
    }
}
