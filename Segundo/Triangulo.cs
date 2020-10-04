using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double CalcArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }
    }
}
