using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Segundo
{
    class SalFun
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            //double x = SalarioBruto +  ;
            SalarioBruto += ((porcentagem / 100) * SalarioBruto);
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
