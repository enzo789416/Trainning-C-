using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Segundo
{
    class Banco
    {
        public int NumConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        //public Banco() { }

        

        public Banco(int numConta, string nomeTitular)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
        }

        public Banco(int numConta, string nomeTitular, double depositoInicial) :this ( numConta,  nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double x)
        {
            Saldo += x;
        }

        public void Saque(double y)
        {
            Saldo-=y + 5.0;
        }

        public override string ToString()
        {
            return "Conta: " + NumConta + ", " + "Titular: " + NomeTitular + ", " + "Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
