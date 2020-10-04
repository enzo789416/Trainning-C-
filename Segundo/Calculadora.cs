using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia( double raio)
        {
            return raio * Pi * 2.0;
        }

        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }

    }
}
