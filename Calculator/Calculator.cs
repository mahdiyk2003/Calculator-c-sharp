using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator : ICalculator
    {
        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Minus(double x, double y)
        {
            return (x - y);
        }

        public double Plus(double x, double y)
        {
            return (x + y) ;
        }

        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }
        public double Multiple(double x , double y)
        {
            return (x * y);
        }
    }
}
