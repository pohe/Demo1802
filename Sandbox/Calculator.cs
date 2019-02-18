using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Calculator
    {
        public Calculator()
        {
            
        }

        public int Add(int tal1, int tal2)
        {
            int result = tal1 + tal2;
            return result; 
        }

        public double Minus(double tal1, double tal2)
        {
            double result = tal1 - tal2;
            return result;
        }

        public double Divide(int t1, int t2)
        {
            double result = t1 / t2;
            return result; 
        }

    }
}
