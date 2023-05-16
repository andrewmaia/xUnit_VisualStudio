using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_VisualStudio
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public bool NumeroEhPar(int a)
        {
            return a % 2 == 0;
        }
    }
}
