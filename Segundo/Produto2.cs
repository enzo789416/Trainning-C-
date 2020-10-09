using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Segundo
{
    class Produto2
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto2(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
