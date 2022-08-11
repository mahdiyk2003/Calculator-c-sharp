using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculator
    {
        double Plus(double x, double y);
        double Minus(double x, double y);
        double Multiple(double x, double y);
        double Divide(double x, double y);
        double Power(double x, double y);

    }
}
