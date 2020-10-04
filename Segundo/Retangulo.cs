using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Segundo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura, 2) + Math.Pow(Altura, 2)));
        }

        public override string ToString()
        {
            return "Area = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n" + "Perimetro = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n" + "Diagonal = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
