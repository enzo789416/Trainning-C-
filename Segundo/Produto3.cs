using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Segundo
{
    class Produto3
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //sobrecarga é colocar mais construtores na sua classe assim chamando-os de acordo com a necessidade

        public Produto3(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto3(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //por padrao fica zero // nem precisa declarar mas deixa ai
        }

        public Produto3()
        {
           
        }
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int x)
        {
            Quantidade += x;
        }

        public void RemoverProduto(int y)
        {
            Quantidade -= y;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
